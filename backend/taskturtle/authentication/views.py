from django.shortcuts import render, HttpResponse
from rest_framework import views
from rest_framework.response import Response
from .serializers import LoginSerializer
from rest_framework import status
from django.contrib.auth import login, authenticate, logout, get_user_model
from rest_framework_simplejwt.tokens import RefreshToken


def is_logged_in(request):
    return HttpResponse(request.user.is_authenticated)


class LoginViewSet(views.APIView):
    authentication_classes = []
    permission_classes = []

    def post(self, request, format=None):
        # data = request.data
        # username = data.get('username', None)
        # password = data.get('password', None)
        serializer = LoginSerializer(data=request.data)

        if serializer.is_valid():
            user = authenticate(
                username=serializer.data["username"], password=serializer.data["password"]
            )

            if user is not None:
                if user.is_active:
                    refresh = RefreshToken.for_user(user)
                    login(request, user)
                    return Response(
                        {
                            "type": user.get_user_type_display(),
                            "refresh": str(refresh),
                            "access": str(refresh.access_token),
                        },
                        status=status.HTTP_200_OK,
                    )
                else:
                    return Response(
                        {"detail": "404 not found."}, status=status.HTTP_404_NOT_FOUND
                    )
            else:
                return Response(
                    {"detail": "404 not found."}, status=status.HTTP_404_NOT_FOUND
                )
        return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)


class LogoutViewSet(views.APIView):
    permission_classes = []

    def post(self, request, format=None):
        # simply delete the token to force a login
        logout(request)
        return Response(status=status.HTTP_200_OK)
