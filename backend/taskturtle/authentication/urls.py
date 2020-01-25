from django.urls import include, path
from rest_framework import routers
from .views import (
    LoginViewSet,
    LogoutViewSet,
    is_logged_in
)

router = routers.DefaultRouter()


urlpatterns = [
    path("is_logged_in/", is_logged_in),
    path("login/", LoginViewSet.as_view(), name="login_email"),
    path("logout/", LogoutViewSet.as_view(), name="logout"),
]