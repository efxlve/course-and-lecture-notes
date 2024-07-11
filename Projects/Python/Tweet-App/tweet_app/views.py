from django.shortcuts import render, redirect
from . import models
from django.urls import reverse, reverse_lazy
from tweet_app.forms import CreateTweetForm, CreateTweetModelForm
from django.contrib.auth.decorators import login_required
from django.contrib.auth.forms import UserCreationForm
from django.views.generic import CreateView

# Create your views here.

def list_tweets(request):
    tweets = models.Tweet.objects.all()
    tweets_dictionary = {'tweets': tweets}
    return render(request, 'tweet_app/list_tweets.html', context=tweets_dictionary)

@login_required(login_url='/login')
def create_tweet(request):
    if request.POST:
        tweet = request.POST["tweet"]
        models.Tweet.objects.create(username=request.user, text=tweet)
        return redirect(reverse('tweet_app:list_tweets'))
    else:
        return render(request, 'tweet_app/create_tweet.html', {})
    
def createTweetByForm(request):
    if request.method == 'POST':
        form = CreateTweetForm(request.POST)
        if form.is_valid():
            username = form.cleaned_data['username']
            tweet = form.cleaned_data['tweet']
            models.Tweet.objects.create(username=username, text=tweet)
            return redirect(reverse('tweet_app:list_tweets'))
        else:
            print("Form is not valid")
            return render(request, 'tweet_app/create_tweet_by_form.html', context={'form': form})
    else:
        form = CreateTweetForm()
        return render(request, 'tweet_app/create_tweet_by_form.html', context={'form': form})
    
def createTweetByModelForm(request):
    if request.method == 'POST':
        form = CreateTweetModelForm(request.POST)
        if form.is_valid():
            username = form.cleaned_data['username']
            tweet = form.cleaned_data['text']
            models.Tweet.objects.create(username=username, text=tweet)
            return redirect(reverse('tweet_app:list_tweets'))
        else:
            print("Form is not valid")
            return render(request, 'tweet_app/create_tweet_by_model_form.html', context={'form': form})
    else:
        form = CreateTweetModelForm()
        return render(request, 'tweet_app/create_tweet_by_model_form.html', context={'form': form})
    
@login_required
def delete_tweet(request, tweet_id):
    tweet = models.Tweet.objects.get(id=tweet_id)
    if request.user == tweet.username:
        models.Tweet.objects.filter(id=tweet_id).delete()
        return redirect(reverse('tweet_app:list_tweets'))

class SignUpView(CreateView):
    form_class = UserCreationForm
    success_url = reverse_lazy('auth:login')
    template_name = 'registration/signup.html'