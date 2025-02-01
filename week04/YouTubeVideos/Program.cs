using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("10 Mind-Blowing Facts About Space!", "Science Explorer", 1200);
        Video video2 = new Video("The Ultimate Guide to C# Programming", "CodeMaster", 2500);
        Video video3 = new Video("Beginner’s Guide to Video Editing", "EditPro Academy", 1200);
        Video video4 = new Video("How to Cook the Perfect Steak", "Chef Gordon’s Kitchen", 1400);
        Video video5 = new Video("Top 5 Most Expensive Cars in the World", " Auto Elite", 1150);
        Video video6 = new Video("The History of Artificial Intelligence Explained", "TechTalks",2600);

        video1.AddComment(new Comment("Andrews", "Wow! I had no idea black holes could evaporate over time! 🤯"));
        video1.AddComment(new Comment("Mobius", "This video made me feel so small yet so inspired. The universe is amazing! 🌌"));
        video1.AddComment(new Comment("Zius", "The visuals and explanations were on point! Keep up the great content. 🚀"));
        video1.AddComment(new Comment("Kojo", "Can you do a video on exoplanets next? This was super informative!"));
        video1.AddComment(new Comment("Jane", "I love space facts! Number 7 blew my mind. Great work! 👍"));

        video2.AddComment(new Comment("Jude", "This tutorial was exactly what I needed! Super clear explanations. 💻"));
        video2.AddComment(new Comment("Tony", "Great breakdown of concepts. Can you make a video on advanced C# topics?"));
        video2.AddComment(new Comment("Angel", "The examples were really helpful! Looking forward to more coding content. 🚀"));
        video2.AddComment(new Comment("Morph", "Wow, this is better than most online courses! Thanks for the effort. 🙌"));
        video2.AddComment(new Comment("Ivy", "I'm finally starting to understand C#! Thanks to your video!"));

        video3.AddComment(new Comment("William", "As a beginner, this was exactly what I needed! Thanks for making it so easy to follow. 🎬"));
        video3.AddComment(new Comment("Isaac", "Great tips! Which editing software would you recommend for a beginner?"));
        video3.AddComment(new Comment("Zoe", "The transitions and effects section really helped me improve my videos! 🔥"));

        video4.AddComment(new Comment("Catherine", "Finally, I can cook a steak without turning it into a piece of rubber! 🥩"));
        video4.AddComment(new Comment("Juliana", "Great tips! I tried this and my steak turned out amazing. 🍽️"));
        video4.AddComment(new Comment("Emily", "I never knew resting the steak was so important! Thanks for the pro tips. 👨‍🍳"));
        video4.AddComment(new Comment("Maria", "This method is way better than what I was doing before. You saved my dinners!"));
        video4.AddComment(new Comment("Edwin", "Now I just need a good sauce recipe to go with it. Any suggestions?"));

        video5.AddComment(new Comment("Marcus", "That Bugatti looks insane! I wish I could afford even the wheels. 😂"));
        video5.AddComment(new Comment("Jaden", "I love how you included historical facts about each car. Great video!"));
        video5.AddComment(new Comment("Onnel", "My dream car is the Rolls-Royce Boat Tail. Absolutely stunning! 🚗💨"));
        video5.AddComment(new Comment("Liam", "Imagine having a garage with all 5 of these… One can dream! 😍"));
        video5.AddComment(new Comment("Kyle", "The price tags on these cars are wild. Who even buys these?!"));

        video6.AddComment(new Comment("Elton", "AI has come so far, it's crazy to think where it will be in 10 years! 🤖"));
        video6.AddComment(new Comment("Dallington", "This was such a well-researched video! The timeline of AI was fascinating."));
        video6.AddComment(new Comment("Luisa", "I love learning about AI. Could you do a video on machine learning next?"));
        video6.AddComment(new Comment("George", "It's amazing how AI started with simple logic and now we have ChatGPT!"));
        video6.AddComment(new Comment("Cameroon", "The section on AI ethics was really thought-provoking. Great discussion!"));


        // adding to video list

        List<Video> videos = new List<Video>{video1,video2,video3,video4,video5,video6};

        foreach(var video in videos){
            Console.WriteLine(">>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<\n");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Numbet of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            Console.WriteLine("Comments: \n");
            foreach(var comment in video.GetComments()){
                Console.WriteLine($"# {comment.GetCommenterName()}: {comment.GetText()}\n");
            }
            Console.WriteLine();
        }

    }
}