from django.shortcuts import render
from rest_framework import views
from .serializers import LoginSerializer
from django.contrib.auth import login, authenticate, logout, get_user_model
from rest_framework_simplejwt.tokens import RefreshToken


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
                username=serializer.data["email"], password=serializer.data["password"]
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

