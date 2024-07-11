from django.urls import path
from . import views

app_name = 'tweet_app'

urlpatterns = [
    path('', views.list_tweets, name='list_tweets'),
    path('create/', views.create_tweet, name='create_tweet'), 
    path('create_tweet_by_form/', views.createTweetByForm, name='create_tweet_by_form'), 
    path('create_tweet_by_model_form/', views.createTweetByModelForm, name='create_tweet_by_model_form'),
    path('signup/', views.SignUpView.as_view(), name='signup'),
    path('delete_tweet/<int:tweet_id>/', views.delete_tweet, name='delete_tweet'),
]