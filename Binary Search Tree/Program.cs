using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    { 

        static void Main(string[] args)
        {
            SearchTree<int> searchTree = new SearchTree<int>();
            searchTree.Add(100);
            searchTree.Add(90);
            searchTree.Add(110);
            searchTree.Add(70);
            searchTree.Search(70);



        }
    }
}
