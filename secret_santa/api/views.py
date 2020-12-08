from django.shortcuts import render
from rest_framework import generics
from .serializers import PartySerializer
from .models import Party

# Create your views here.


class PartyView(generics.ListAPIView):
    queryset = Party.objects.all()
    serializer_class = PartySerializer
