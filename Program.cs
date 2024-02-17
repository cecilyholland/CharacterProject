namespace ClassProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScores generator = new AbilityScores();

            Console.WriteLine("Choose a method to generate ability scores:");
            Console.WriteLine("1. Method 1 - Sum of 3d6 (Min/Max = 3/18)");
            Console.WriteLine("2. Method 2 - Sum of best 3 of 5d6 (Min/Max = 3/18)");
            Console.WriteLine("3. Method 3 - Sum of best 3 of 5d6 plus 1d3 (Min/Max = 4/21)");

            int method;
            while (true)
            {
                Console.Write("Enter your choice (1, 2, 3): ");
                method = Convert.ToInt32(Console.ReadLine());
                if (method >= 1 && method <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                }
            }

            int[] abilityScores = generator.GenerateScores(method);

            Console.WriteLine("Generated ability scores:");
            foreach (int score in abilityScores)
            {
                Console.WriteLine(score);
            }

            // Create a character with generated ability scores
            CharacterChoice character = CreateCharacter();

            // Display character details
            Console.WriteLine("Character Details:");
            Console.WriteLine($"Name: {character.Name}");
            Console.WriteLine($"Gender: {character.Gender}");
            Console.WriteLine($"Alignment: {character.Alignment}");
            Console.WriteLine($"Race: {character.Race}");
            Console.WriteLine($"Age: {character.Age}");
            Console.WriteLine($"Height: {character.Height}");
            Console.WriteLine($"Weight: {character.Weight}");
        }

        static CharacterChoice CreateCharacter()
        {
            Console.Write("Enter character name: ");
            string name = Console.ReadLine();

            Console.Write("Enter character gender (M/F): ");
            string gender = Console.ReadLine();

            Console.Write("Enter character alignment: ");
            string alignment = Console.ReadLine();

            Console.Write("Enter character race: ");
            string race = Console.ReadLine();

           
            return new CharacterChoice(name, gender, alignment, race);
        }
    }
}