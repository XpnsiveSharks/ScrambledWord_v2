using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ScrambledWord_v2.Commons
{
    public class Functionalities
    {
        static WordAttributes[] EasyWordsInfo = WordAttributes.GetArrayOfEasyWords();
        static WordAttributes[] HardWordsInfo = WordAttributes.GetArrayOfDifficultWords();

        static Random random = new Random();
        static List <int> UsedNumber = new List<int>();//List of Used index
        static int TrackCorrectGuess = 0;
        static int Score = 0;
        static bool IsNotCorrectAns = false;

        public static string Scoring()
           => Score.ToString();
        public static string TrackLevel()
           => TrackCorrectGuess.ToString();
         
        public static string WrongGuessMessage()
        {
            if (IsNotCorrectAns == true)
            {
                IsNotCorrectAns = false;
                return "test";
            }
            else
            {
                return null;
            }
        }
        public static string printWord()
        {
            if (TrackCorrectGuess <= 5)
                return ScrambleWord(EasyWordsInfo[radomNumberGenerator()].WORD);
            else if(TrackCorrectGuess >= 6 &&  TrackCorrectGuess <= 10)
                return ScrambleWord(HardWordsInfo[radomNumberGenerator()].WORD);
            else
                return "Congratulations You Completed the Jumblr Game";
        }
        public static string printHint()
        {
            if (TrackCorrectGuess <= 5)
                if (Score >= 3)
                {
                    Score -= 3;
                    return EasyWordsInfo[UsedNumber[UsedNumber.Count - 1]].HINT;
                }
                else
                {
                    return "Score must be more than equal to 3";
                } 
            else if(TrackCorrectGuess >= 6 && TrackCorrectGuess <= 10)
                if (Score >= 5)
                {
                    Score -= 5;
                    return HardWordsInfo[UsedNumber[UsedNumber.Count - 1]].HINT;
                }
                else
                {
                    return "Score must be more than equal to 5";
                }
            else
                return null;
        }
        /// <summary>
        /// Reshuffle word
        /// </summary>
        /// <returns></returns>
        public static string ReShuffle()
        {
            if (TrackCorrectGuess <= 5)
                return ScrambleWord(EasyWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORD);
            else if (TrackCorrectGuess >= 6 && TrackCorrectGuess <= 10)
                return ScrambleWord(HardWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORD);
            else
                return "Congratulations You Completed the Jumblr Game";
        }
        /// <summary>
        /// Verify the answer and returns the jumbled word if guess is wrong
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string VerifyAnswer(string input)
        {
            if (TrackCorrectGuess <= 5 && input.Equals(EasyWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORD))
            {
                TrackCorrectGuess += 1;
                Score += 2;
                return printWord();
            }
            else if(TrackCorrectGuess >= 6 && TrackCorrectGuess <= 10 && input.Equals(HardWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORD))
            {
                TrackCorrectGuess += 1;
                Score += 5;
                return printWord();
            }
            else
            {
                IsNotCorrectAns = true;
                if (TrackCorrectGuess <= 5)
                    return ScrambleWord(EasyWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORD);
                else if (TrackCorrectGuess >= 6 && TrackCorrectGuess <= 10)
                    return ScrambleWord(HardWordsInfo[UsedNumber[UsedNumber.Count - 1]].WORD);
                else
                    return null;
            }
        }
        /// <summary>
        /// number randomizer
        /// </summary>
        /// <returns></returns>
        static int radomNumberGenerator()// index randomizer
        {
            var numbers = new List<int>();
            for (int i = 0; i <= 39; i++)
                numbers.Add(i);

            int index = random.Next(numbers.Count);

            while (UsedNumber.Contains(numbers[index]))
                index = random.Next(numbers.Count);

            UsedNumber.Add(numbers[index]);
            return numbers[index];
        }
        /// <summary>
        /// word randomizer
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
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
                return false;
            
            int matchingCharacters = 0;// Count the number of matching characters
            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                if (word1[i] == word2[i])
                    matchingCharacters++;
            }
            double similarityScore = (double)matchingCharacters / Math.Min(word1.Length, word2.Length); // Calculate the similarity score based on the number of matching characters
            return similarityScore > 0.7;// Consider the words similar if the similarity score is above 0.7
        }

    }
}
