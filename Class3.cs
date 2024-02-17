using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject
{
    public class AbilityScores
    {
        private Random random;

        public AbilityScores()
        {
            random = new Random();
        }

        public int[] GenerateScores(int method)
        {
            int[] abilityScores = new int[6];

            // Method is within valid range (1-3)
            while (method < 1 || method > 3)
            {
                Console.WriteLine("Invalid ability score generation method. Please choose a method between 1 and 3.");
                method = Convert.ToInt32(Console.ReadLine());
            }

            switch (method)
            {
                case 1:
                    GenerateMethod1(abilityScores);
                    break;
                case 2:
                    GenerateMethod2(abilityScores);
                    break;
                case 3:
                    GenerateMethod3(abilityScores);
                    break;
            }

            return abilityScores;
        }

        private void GenerateMethod1(int[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = random.Next(3, 19); // Min/Max = 3/18
            }
        }

        private void GenerateMethod2(int[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                int[] rolls = new int[5];
                for (int j = 0; j < rolls.Length; j++)
                {
                    rolls[j] = random.Next(1, 7);
                }
                Array.Sort(rolls);
                scores[i] = rolls[2] + rolls[3] + rolls[4];
            }
        }

        private void GenerateMethod3(int[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                int[] rolls = new int[5];
                for (int j = 0; j < rolls.Length; j++)
                {
                    rolls[j] = random.Next(1, 7);
                }
                Array.Sort(rolls);
                scores[i] = rolls[2] + rolls[3] + rolls[4] + random.Next(1, 4);
            }
        }
    }
}