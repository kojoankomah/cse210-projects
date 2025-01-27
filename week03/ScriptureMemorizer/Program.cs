using System;
using Microsoft.VisualBasic;

namespace ScriptureMemorizer

// To exceed requirement I included a line of code that helps the 
// use to know exactly where the scripture to be memorised begins and ends
// I also made it more interesting/challenging by making the code 
// randomly removing up t 6 words whenever the user presses enter
// I also added enough scriptures
{
    class Program
    {
        public static List<Reference> scripturesVerses = new List<Reference>();
        static void Main(string[] args)
        {
            setScriptures();
            Random random = new Random();
            int randomIndex = random.Next(0, scripturesVerses.Count);
            Reference randomScripture = scripturesVerses[randomIndex];
            Scripture scripture = new Scripture(randomScripture);
            Console.WriteLine();

            Console.WriteLine("Memorize the following scripture:");
            Console.WriteLine();
            do
            {
                Console.Clear();
                Console.WriteLine("\n---------------START------------\n");

                scripture.GetDisplayText();
                Console.WriteLine("\n-------------END--------------");

                Console.Write("\nPress enter to Hide a word or type \"quit\" to exit: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    scripture.HideRandomWords(random.Next(1, 6));
                }
            } while (!scripture.isCompletelyHidden());
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine();
            Console.Write("\nPress enter to to exit: ");
        }
        private static void setScriptures()
        {
            scripturesVerses.Add(new Reference("Mosiah", 3, 19, "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."));
            scripturesVerses.Add(new Reference("Doctrine and Covenants", 130, 20, 21, "There is a law, irrevocably decreed in heaven before the foundations of this world, upon which all blessings are predicated. And when we obtain any blessing from God, it is by obedience to that law upon which it is predicated."));
            scripturesVerses.Add(new Reference("1 Nephi", 3, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
            scripturesVerses.Add(new Reference("Doctrine and Covenants", 4, 1, 3, "Now behold, a marvelous work is about to come forth among the children of men.Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day. Therefore, if ye have desires to serve God ye are called to the work;"));
            scripturesVerses.Add(new Reference("Doctrine and Covenants", 59, 1, 2, "Behold, the Lord’s hand is not shortened, that it cannot save; neither his ear heavy, that it cannot hear: But your iniquities have separated between you and your God, and your sins have hid his face from you, that he will not hear."));
            scripturesVerses.Add(new Reference("James", 1, 27, "Pure religion and undefiled before God and the Father is this, To visit the fatherless and widows in their affliction, and to keep himself unspotted from the world."));
            scripturesVerses.Add(new Reference("Moroni", 7, 12, 13, "Wherefore, all things which are good cometh of God; and that which is evil cometh of the devil; for the devil is an enemy unto God, and fighteth against him continually, and inviteth and enticeth to sin, and to do that which is evil continually. But behold, that which is of God inviteth and enticeth to do good continually; wherefore, every thing which inviteth and enticeth to do good, and to love God, and to serve him, is inspired of God."));
            scripturesVerses.Add(new Reference("Alma", 32, 40, 41, "And thus, if ye will not nourish the word, looking forward with an eye of faith to the fruit thereof, ye can never pluck of the fruit of the tree of life. But if ye will nourish the word, yea, nourish the tree as it beginneth to grow, by your faith with great diligence, and with patience, looking forward to the fruit thereof, it shall take root; and behold it shall be a tree springing up unto everlasting life."));

        }

    }
}