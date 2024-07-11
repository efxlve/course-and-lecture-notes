from django import forms
from django.forms import ModelForm
from tweet_app.models import Tweet

class CreateTweetForm(forms.Form):
    username = forms.CharField(label='Username', max_length=50)
    tweet = forms.CharField(label='Text', max_length=320, widget=forms.Textarea(attrs={'rows': 5}))

class CreateTweetModelForm(ModelForm):
    class Meta:
        model = Tweet
        fields = ['username', 'text']