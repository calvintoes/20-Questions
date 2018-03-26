using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Node class - Nodes have a string and 2 child Node pointers.
 * The children are either both null (a leaf node => string is a name)
 * or they're both non-null (an branch node => string is a phrase)
 * BinTree needs access to all the Node attributes, which means that
 * they all have public properties.
 */

namespace _20_Questions
{
    public class Node
    {
        private string data;
        private Node yes;
        private Node no;

        public Node(string i)
        {
            data = i;
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        //yes - left nodes
        public Node yesPtr
        {
            get { return yes; }
            set { yes = value; }
        }

        //no - right nodes
        public Node noPtr
        {
            get { return no; }
            set { no = value; }
        }


        public void Display()
        {
            Console.WriteLine(Data);
        }

        
    }
}
