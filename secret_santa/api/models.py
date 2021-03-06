import string
import random
from django.db import models

# Create your models here.


def generate_unique_code():
    length = 6

    while True:
        code = ''.join(random.choices(string.ascii_uppercase, k=length))
        if Party.objects.filter(code=code).count() == 0:
            break

        return code


class Party(models.Model):
    code = models.CharField(max_length=8, default="", unique=True)
    host = models.CharField(max_length=50, unique=True)
    enable_wishlist = models.BooleanField(null=False, default=False)
    date_created = models.DateTimeField(auto_now_add=True)
