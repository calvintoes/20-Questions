/* 20 Questions Game - by Al Biles
 * Implements classic 20 questions binary decision tree with learning.
 * This is the "final" version of the Main method.  As you develop your
 * code, you'll comment out parts of of it and insert temporary code
 * to debug your classes, as I've done in building our class demos.
 * In particular, the last thing you should build is the ReadTree() method
 * in the BinTree class. Use the Hardwire() method instead to debug the rest
 * of the program.
 */

using System;
using System.IO;

namespace _20_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            BinTree tqTree = new BinTree();
            //tqTree.HardCode();                      //  Used until ReadTree() works
            tqTree.ReadTree();

            //tqTree.Traverse();                    //  Uncomment for debug

            //  Check if the tree is empty
            if (tqTree.Root == null)
            {
                Console.WriteLine("Sorry we can't play a game right now.\nCome back later after I learn something.");
            }
            else
            {
                string answer;
                Console.WriteLine("Welcome to 20 questions!\nI'll try to guess your person.");

                do
                {
                    Console.WriteLine();

                    Play20Q.PlayOneGame(tqTree);

                    Console.Write("\nHow about another game?(y, n) ");
                    answer = Console.ReadLine();

                } while (answer.Equals("y"));

               
                tqTree.SaveTheTree();
                //tqTree.Traverse();			        //  Uncomment for debug
            }

            Console.WriteLine("Bye Bye!");
            Console.ReadKey();
        }
    }
}
