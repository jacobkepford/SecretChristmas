from rest_framework import serializers
from .models import Party


class PartySerializer(serializers.ModelSerializer):
    class Meta:
        model = Party
        fields = ('id', 'code', 'host', 'enable_wishlist', 'date_created')
