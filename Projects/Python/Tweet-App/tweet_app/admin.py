from django.contrib import admin
from tweet_app.models import Tweet

# Register your models here.

class TweetAdmin(admin.ModelAdmin):
    fieldsets = [
        ('Username Group', {'fields': ['username']}),
        ('Tweet Group', {'fields': ['text']}),
    ]
    #fields = ['username', 'text']

admin.site.register(Tweet, TweetAdmin)