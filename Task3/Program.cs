namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            for (int i = 0; i<firstWord.Length;i++)
            {
                for (int j = i+1;j<firstWord.Length;j++)
                {
                    if (char.ToLower(firstWord[i]) == char.ToLower(firstWord[j]))
                    {
                        firstWord=firstWord.Remove(j, 1);
                        j--;
                    }
                }
            }

            string result = "";
            bool detected = false;
            for (int i = 0;i<firstWord.Length;i++)
            {
                for (int j =0;j<secondWord.Length;j++)
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
            Console.WriteLine(result);
        }
    }
}
