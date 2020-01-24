from django.db import models
from django.conf import settings
from django.contrib.auth.models import AbstractUser


class User(AbstractUser):
    TYPE_CHOICES = (("TR", "Tasker"), ("TE", "Taskee"), ("SP", "Support"), ("MR", "Manager"))
    user_type = models.CharField(max_length=2, choices=TYPE_CHOICES)

# Create your models here.
