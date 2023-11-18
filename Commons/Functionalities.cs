using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrambledWord_v2.Commons
{
    public class Functionalities
    {
        static WordAttributes[] WordsInfo = WordAttributes.GetArrayOfWords();
        static Random random = new Random();
        static List <int> UsedNumber = new List<int>();//List of Used index
        public static string print()
        {
            return ScrambleWord(WordsInfo[radomNumberGenerator()].WORD);
        }

        static int radomNumberGenerator()// index randomizer
        {
            var numbers = new List<int>();
            for (int i = 0; i <= 1; i++)
                numbers.Add(i);

            int index = random.Next(numbers.Count);

            while (UsedNumber.Contains(numbers[index]))
                index = random.Next(numbers.Count);

            UsedNumber.Add(numbers[index]);
            return numbers[index];
        }
        public static string ScrambleWord(string word)
        {
            string randomizedWord;
            do
            {
                if (word.Contains(' '))// Check if the word contains spaces
                {
                    string[] words = word.Split(' ');// Split the word into two words

                    
                    string randomizedWord1 = ScrambleWord(words[0]);
                    string randomizedWord2 = ScrambleWord(words[1]);

                    randomizedWord = randomizedWord1 + " " + randomizedWord2;// Combine the randomized words with the space
                }
                else
                {
                    char[] characters = word.ToCharArray(); // Randomize the characters of the word

                    for (int i = 0; i < characters.Length; i++)
                    {
                        int randomIndex = random.Next(characters.Length);
                        char temp = characters[i];
                        characters[i] = characters[randomIndex];
                        characters[randomIndex] = temp;
                    }

                    randomizedWord = new string(characters);
                }
            } while (IsSimilar(randomizedWord, word)); // Check if randomized word is similar to original word

            return randomizedWord;
        }
        private static bool IsSimilar(string word1, string word2)// Check if the lengths of the words differ by more than 2 characters
        {          
            if (Math.Abs(word1.Length - word2.Length) > 2)
            {
                return false;
            }
            int matchingCharacters = 0;// Count the number of matching characters
            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                if (word1[i] == word2[i])
                {
                    matchingCharacters++;
                }
            }
            double similarityScore = (double)matchingCharacters / Math.Min(word1.Length, word2.Length); // Calculate the similarity score based on the number of matching characters
            return similarityScore > 0.7;// Consider the words similar if the similarity score is above 0.7
        }

    }
}
