/* Play20Q class - Plays a single game.
 */

using System;
using System.IO;

namespace _20_Questions
{
    public static class Play20Q
    {
        public static void PlayOneGame(BinTree tree)
        {
            /*
             * Algorithm to play a game
             * --------------------------
             *  Start at the root
             *  While we're not at a leaf node
             *      Ask the node's question
             *      Get the answer
             *      Based on the answer, follow either yes or no pointer
             *  Guess the name at the leaf node
             *  If the guess is correct
             *      Program won
             *  Else
             *      Program asks who it was and how to tell the difference
             *      Program grows the tree to learn the new name
             */

            Node currNode = null;

            if (tree.Root != null)
            {
                 currNode = tree.Root;
                 while( currNode.yesPtr != null && currNode.noPtr != null)
                { 
                    Console.WriteLine("Is this person " + currNode.Data + "?");
                    string input = Console.ReadLine();
                    input.ToLower();

                    if (input == "y")
                    {
                        //Console.WriteLine("Is it " + tree.Root.yesPtr);
                        currNode = currNode.yesPtr;
                    }
                    else
                    {
                        //Console.WriteLine("Is it " + tree.Root.noPtr);
                        currNode = currNode.noPtr;
                    }         
                }
                Console.WriteLine("Is it " + currNode.Data);
                string answer = Console.ReadLine();
                answer.ToLower();

                if (answer == "y")
                {
                    Console.WriteLine("Hurray! I win!");
                }
                else
                {
                    Console.WriteLine("I give up. Who is it?");
                    string newAnswer = Console.ReadLine();

                    Console.WriteLine("What is " + newAnswer + " that " + currNode.Data + " isn't?");
                    string explaination = Console.ReadLine();
                    Console.WriteLine("I love learning new things!");

                    tree.learnNewName(newAnswer, explaination, currNode);
                    //currNode = currNode.noPtr;
                }

            }
            else
            {
                Console.WriteLine("It's Empty");
            }
            
        }
    }
}
