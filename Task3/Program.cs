namespace Task3
{
    public class Logic
    {
        public static string clearSameSymbols(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (char.ToLower(word[i]) == char.ToLower(word[j]))
                    {
                        word = word.Remove(j, 1);
                        j--;
                    }
                }
            }
            return word;
        }

        public static string checkSameElements(string firstWord, string secondWord)
        {
            string result = "";
            bool detected = false;
            for (int i = 0; i < firstWord.Length; i++)
            {
                for (int j = 0; j < secondWord.Length; j++)
                {
                    if (char.ToLower(firstWord[i]) == char.ToLower(secondWord[j]))
                    {
                        detected = true;
                        break;
                    }
                }
                if (detected)
                {
                    result = result + "да ";
                    detected = false;
                }
                else
                {
                    result = result + "нет ";
                }
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            string firstClearedWord = Logic.clearSameSymbols(firstWord);
            string result = Logic.checkSameElements(firstClearedWord, secondWord);
            
            Console.WriteLine(result);
        }
    }
}
