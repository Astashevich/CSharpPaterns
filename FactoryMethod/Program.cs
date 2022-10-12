using FactoryMethod;
using FactoryMethod.Factory.Messangers;

var messanger = new TestMessanger("Arseniy", "password");
messanger.SendMessage("Hello, World", "Arseniy", "Friend");

var twitter = new TwitterMessanger("Areniy", "passwordTwitter");
var twit = twitter.CreateMessage("Hi, Bro! It's twitter!", "Arseniy", "Friend1");
twit.Send();

var instagram = new InstagramMessanger("Astash", "instagramPassword");
var inst = instagram.CreateMessage("Image.png", "Astash", "Friends");
inst.Send();

var telegram = new TelegramMessanger("Areniy", "passwordTelegram");
var telega = telegram.CreateMessage("Hi, Bro! It's Telegram for you!", "Arseniy", "Friend3");
telega.Send();

Console.ReadLine();

