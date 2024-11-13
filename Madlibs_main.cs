/*This program is a basic and random madlibs in C#.*/

//Define a namespace for use of it later.
namespace madlibs
{
    // Make a class for Game.
    public class Game
    {
        // The main body of the code.
        static void Main(string[] args)
        {
            //Handle user input.
            Console.WriteLine("Please Enter a verb: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string verb = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("Please Enther an adverb: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string adverb = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("Please Enter a pronouns: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string pronouns = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            // Output the stuff the user put to this random short story.
            Console.WriteLine($"The person {verb} is running away from {adverb} and she want her {pronouns} mom to help with the bakeing of the pizza.");
        }
    }
}
