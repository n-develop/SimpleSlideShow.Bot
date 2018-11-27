# SimpleSlideShow.Bot

## What is SimpleSlideShow.Bot?

I created this Telegram bot for my wedding. The idea was, that the guests should be able to put pictures, taken with their smartphones, on a digital photo wall. To avoid writing an entire app, I decided to go with a [Telegram](https://telegram.org/) bot. If you don't know Telegram, go and get it. It's awesome.

So, everybody can send their pictures to the bot. The bot will save the images to a specific folder and respond with a friendly message. And that's it. I created a [separate little project](https://github.com/n-develop/SimpleSlideShow) to implement the photo wall / slide show. 

## How to use?

### Step 1 - Create your own bot

Follow the intstructions of the [BotFather](https://core.telegram.org/bots#6-botfather) to create your own bot.
At the end of the process, the BotFather will send you an API-token. We will use it later.

### Step 2 - Checkout this repository

Get the sources of `SimpleSlideShow.Bot` and execute `dotnet restore`.

### Step 3 - Update the appsettings.json

Insert the Telegram API-token into the `api-token` property of the `appsettings.json` file.
You can also insert the path to the directory, where the images should be stored.

```json
{
    "api-token": "YOUR_API_TOKEN_GOES_HERE",
    "saveImagesTo": "c:\\store\\images\\here"
}
```

### Step 4 - Build

`dotnet build`

### Step 5 - Run

`dotnet run`
