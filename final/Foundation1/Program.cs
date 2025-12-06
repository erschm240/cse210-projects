using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video dragons = new Video("Types of Dragons", "Fantasy Enthusiast", 10);
        videos.Add(dragons);
        Comment dragonComment1 = new Comment("DragonsareCool11", "Fascinating! Y Ddraig Goch is my favorite!");
        Comment dragonComment2 = new Comment("SweetiePie6", "Where did you find this information?");
        Comment dragonComment3 = new Comment("AwesomeSauce78", "Wow! I didn't know dragon stories existed in so many parts of the world!");
        dragons._comments.Add(dragonComment1);
        dragons._comments.Add(dragonComment2);
        dragons._comments.Add(dragonComment3);
        
        Video krakens = new Video("All About Krakens", "Mythical Menagerie", 8);
        videos.Add(krakens);
        Comment krakenComment1 = new Comment("AnnaGooding4753", "Those krakens were so big!");
        Comment krakenComment2 = new Comment("BuggieBeats879", "All those tentacles are so slimy. Ew!");
        Comment krakenComment3 = new Comment("KassandraM23", "My grandfather swears up and down that he saw a kraken once in the Atlantic Ocean.");
        krakens._comments.Add(krakenComment1);
        krakens._comments.Add(krakenComment2);
        krakens._comments.Add(krakenComment3);

        Video yeti = new Video("The Mysterious Yetis", "Your Local Cryptid", 20);
        videos.Add(yeti);
        Comment yetiComment1 = new Comment("KaylaHamilton", "I've been fascinated with the Yeti since I was a kid.");
        Comment yetiComment2 = new Comment("TreeRoots33", "Whoa, it looks so cool! It definitely looks warm in that fur.");
        Comment yetiComment3 = new Comment("ChickenNugget666", "I didn't know the Yeti comes from the Himalayas. Interesting!");
        yeti._comments.Add(yetiComment1);
        yeti._comments.Add(yetiComment2);
        yeti._comments.Add(yetiComment3);

        Video boogeyman = new Video("Creatures that Go Bump In the Night #3: The Boogeyman", "Creepy Creatures", 5);
        videos.Add(boogeyman);
        Comment boogeymanComment1 = new Comment("ItsLanie54", "My dad told me a story about the boogeyman when I was little.");
        Comment boogeymanComment2 = new Comment("7GoldenDrachmas", "AAH! So creepy. I was on the edge of my seat the whole video!");
        Comment boogeymanComment3 = new Comment("BeepBoop000", "I remember having a creepy feeling one night when I was seven years old. I wonder if it was him?");
        boogeyman._comments.Add(boogeymanComment1);
        boogeyman._comments.Add(boogeymanComment2);
        boogeyman._comments.Add(boogeymanComment3);

        int count = 1;
        foreach (Video video in videos)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Video #{count}");
            video.DisplayVideo();
            count++;
        }
    }
}