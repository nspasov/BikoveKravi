using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikoveKravi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            String numPC = "";
            String numClient = "";

            Random r = new Random();

            int bik = 0;
            int krava = 0;
            int lifeCount = 0;
            int difficulty = 0;

            Console.WriteLine("Please choose difficulty:\n");
            Console.WriteLine("1.Easy");
            Console.WriteLine("2.Medium");
            Console.WriteLine("3.Hard");

            do
            {
                difficulty = int.Parse(Console.ReadLine());

                switch (difficulty)
                {
                    case 1:
                        lifeCount = 15;
                        Console.WriteLine("Difficulty easy - 15 tries..");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        lifeCount = 10;
                        Console.WriteLine("Difficulty medium - 10 tries.");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        lifeCount = 5;
                        Console.WriteLine("Difficulty hard - 5 tries.");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.");
                        Console.ReadLine();
                        break;
                }
            } while (difficulty < 1 || difficulty > 3);

            do
            {
                int num = r.Next(0, 9);
                if (!numPC.Contains(num.ToString()))
                {
                    numPC += num;
                }
            } while (numPC.Length < 4);

            //Console.WriteLine(numPC);

            do
            {
                Console.WriteLine("Remaining lives: " + lifeCount);
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Please enter 4 digit number.");
                numClient = Console.ReadLine();

                for (int j = 0; j < numClient.Length; j++)
                {
                    if (numPC.Contains(numClient[j]) && numPC[j] == numClient[j])
                    {
                        bik++;
                    }
                    else if (numPC.Contains(numClient[j]) && numPC[j] != numClient[j])
                    {
                        krava++;
                    }
                }

                if (bik == 4)
                {
                    Console.Clear();
                    Console.WriteLine("You win");
                    return;
                }

                Console.WriteLine(krava + " Kravi");
                Console.WriteLine(bik + " Bika");
                krava = 0;
                bik = 0;

                lifeCount--;
                if (lifeCount == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over");
                    return;
                }
            } while (bik != 4);
        }
    }
}