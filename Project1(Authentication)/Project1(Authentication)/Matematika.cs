namespace Project1_Authentication_
{
    internal class Matematika
    {
        public void PrintEvenOdd(int limit, string choice)
        {
            if (choice != "Ganjil" && choice != "Genap")
            {
                Console.WriteLine("Input pilihan tidak valid!!!");
            }
            else
            {
                Console.WriteLine("Print bilangan 1 - " + limit + " :");
                if (limit < 1)
                {
                    Console.WriteLine("Input limit tidak valid!!!");
                }
                else
                {
                    if (choice == "Ganjil")
                    {
                        for (int i = 1; i < limit; i++)
                        {
                            if (i % 2 == 1)
                            {
                                Console.Write(i + ", ");
                            }
                        }
                        Console.WriteLine();
                    }
                    if (choice == "Genap")
                    {
                        for (int i = 1; i < limit; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(i + ", ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        public string EvenOddCheck(int input)
        {
            if (input >= 1)
            {
                if (input % 2 == 0)
                {
                    return "Genap";
                }
                else if (input % 2 == 1)
                {
                    return "Ganjil";
                }
                else
                {
                    return "Invalid Input!!!";
                }
            }
            else
            {
                return "invalid Input!!!";
            }
        }
    }
}
