using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>
        {
            new Video("The Weirdest Kind of Lightning You've Never Heard Of", "SciShow", 1534)
            {
                comments = new List<Comment>
                {
                    new Comment("Infinite_Omniverse", "What a coincidence. I was looking up pictures of red sprites just 20 minutes before this video got uploaded."),
                    new Comment("danr1920", "Those of us old enough to have listened to AM radio will remember that you heard a lighting bolt on the radio as loud static if close and less loud the farther away the lighting was."),
                    new Comment("KitsukiiPlays", "Thunderbolt and lightning, very very frightening"),
                    new Comment("amymandeville8342", "I've always been fascinated by lightning, even more so with volcanic lightning and Sprites.")
                }
            },
            new Video("Why Royal Quinoa Is So Expensive", "Business Insider", 617)
            {
                comments = new List<Comment>
                {
                    new Comment("kgothatsongobeni2991", "This thing grows in my garden, I always thought it was alien vegetation. Never knew it was edible."),
                    new Comment("davidswanson5669", "To hear about families finally being able to build homes and send their kids to college, wow that’s inspiring."),
                    new Comment("Enucentro", "Easy answer - cause of hipsters."),
                    new Comment("Ese_osa", "This channel is known for why everything is expensive.")
                }
            },
            new Video("Zelda's Lofi Kingdom", "GameChops", 2439)
            {
                comments = new List<Comment>
                {
                    new Comment("GrahamLikeTheCrackers", "Late night housework is about to get a lot more groovy."),
                    new Comment("caspianc16", "Oh my, this background art is absolutely insane! Can’t wait to listen to this one."),
                    new Comment("Ramenko1", "Sky Labyrinth is one of the coolest sounds I've ever heard in my entire life."),
                    new Comment("MuffinsRYummy117E", "It’s dangerous to go without vibes, take this!")
                }
            },
            new Video("Cream Cheese Pull-Apart Garlic Bread", "Babish Culinary Universe", 693)
            {
                comments = new List<Comment>
                {
                    new Comment("Bryce_the_Woomy_Boi", "I'm convinced they created this channel just to make whatever food they want and eat it, I don't blame them."),
                    new Comment("davyjones3105", "I still hope Andrew makes the various “foods in a cup” from Wall-E for his Binging series."),
                    new Comment("mattbas-vi7750", "Kinda forgot to give a conclusion regarding fresh vs jar garlic, but I guess that's an statement on itself."),
                    new Comment("gregoryflores3178", "So was the fresh garlic different from the pre-minced garlic?")
                }
            }
        };
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
            v.GetNumComments();
            v.DisplayComments();
        }
    }
}