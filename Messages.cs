using System;
using System.Collections.Generic;

namespace SimpleSlideShow.Bot
{
    class Messages
    {
        private static Dictionary<string, List<string>> thankYouMessages = new Dictionary<string, List<string>> 
        {
            {
                "de", new List<string> 
                {
                    "Cooles Bild! 😎",
                    "Toller Schnappschuss 😍",
                    "Ein Schnappschuss, der seinen Namen verdient.",
                    "😄 Starkes Foto",
                    "Das macht sich sicher super auf der Fotowand. Danke.👍",
                    "Danke, mein Engel!",
                    "Bitte recht freundlich! 📷",
                    "Cheeeeeeeese! 🧀"
                }
            },
            {
                "en", new List<string> 
                {
                    "Cool pic! 😎",
                    "Cheeeeeeeese! 🧀",
                    "Thanks, darling!",
                    "😄 Great photo",
                    "This will look awesome on the picture wall. Thanks. 👍",
                    "A snapshot, worthy of the name.",
                    "Smile! 📷",
                    "Nice snapshot 😍"
                }
            }
        };

        internal static string GetEnabledConfirmationMessage(string language)
        {
            if (ENABLED_CONFIRMATION_MESSAGES.ContainsKey(language))
            {
                return ENABLED_CONFIRMATION_MESSAGES[language];
            }
            return ENABLED_CONFIRMATION_MESSAGES["en"];
        }

        internal static string GetNotYetStartedMessage(string language)
        {
            if (NOT_YET_STARTED_MESSAGES.ContainsKey(language))
            {
                return NOT_YET_STARTED_MESSAGES[language];
            }
            return NOT_YET_STARTED_MESSAGES["en"];
        }

        private static Dictionary<string, string> WELCOME_MESSAGES = new Dictionary<string, string> 
        {
            {
                "en", @"Welcome to the digital picture wall.

Thank you for sharing your photos 📷 of our party with all of us.

So, go an take some pictures! 😃👍"
            },
            {
                "de", @"Herzlichen willkommen zur digitalen Fotowand.

Vielen Dank, dass du dich mit deinen Schnappschüssen 📷 an unserer tollen Pary beteiligst.

Dann knips mal drauf los! 😃👍"
            }
        };

        private static Dictionary<string, string> HELP_MESSAGES = new Dictionary<string, string> 
        {
            {"en", "No magic or special knowledge required. Just take a picture 📷 with your phone and send it to me. I'll put it on the picture wall. 😃👍"},
            {"de", "Da gibt es nichts zu können. Schick mir einfach deine Fotos 📷 und ich packe sie auf die digitale Fotowand! 😃👍"}
        };

        private static Dictionary<string, string> NOT_YET_STARTED_MESSAGES = new Dictionary<string, string> 
        {
            {"en", "\"Patience you must have, my young padawan.\"\n -Yoda"},
            {"de", "\"Geduld du haben must, junger Padawan.\"\n -Yoda"}
        };

        private static Dictionary<string, string> ENABLED_CONFIRMATION_MESSAGES = new Dictionary<string, string> 
        {
            {"en", "Aye, aye, captian!"},
            {"de", "Aye, aye, Käpt'n!"}
        };

        public static string GetWelcomeMessage(string language)
        {
            if (WELCOME_MESSAGES.ContainsKey(language))
            {
                return WELCOME_MESSAGES[language];
            }
            return WELCOME_MESSAGES["en"];
        }

        public static string GetHelpMessage(string language)
        {
            if (HELP_MESSAGES.ContainsKey(language))
            {
                return HELP_MESSAGES[language];
            }
            return HELP_MESSAGES["en"];
        }

        public static string GetThankYou(string language)
        {
            var random = new Random();
            if (thankYouMessages.ContainsKey(language))
            {
                return thankYouMessages[language][random.Next(thankYouMessages[language].Count)];
            }
            return thankYouMessages["en"][random.Next(thankYouMessages["en"].Count)];
        }
    }
}