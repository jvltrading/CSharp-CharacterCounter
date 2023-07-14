namespace Character_Count
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter A New String : ");
            string str = Console.ReadLine().ToLower();

            if (str.Length > 0)
            {
                foreach(char key in str)
                {
                    int frequency = 0;
                    foreach(char c in str)
                        if (c == key)
                        {
                            frequency++;
                        }

                    Console.WriteLine(key + "   " + frequency);
                    Console.WriteLine("-------------");
                }
            } else
            {
                Console.WriteLine("Input is too short, Please Try Again");
            }
            Main();
        }
    }
}