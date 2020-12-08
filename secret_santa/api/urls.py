from django.urls import path
from .views import PartyView

urlpatterns = [
    path('party', PartyView.as_view()),
]
