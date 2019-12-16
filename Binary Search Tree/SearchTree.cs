using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{

    class SearchTree<T> where T : IComparable
    {
        T tempValue;
        node<T> root;
        node<T> current;
        public SearchTree()
        {



        }
        public void Add(T value)
        {
            tempValue = value;
            current = root;
            if (root == null)
            {
                root = new node<T>(value);
                return;
            }

            else
            {
                Check(current);
            }

        }




        public void Check(node<T> node)
        {
            if (node.value.CompareTo(tempValue) == 1 || node.value.CompareTo(tempValue) == 0)
            {
                if (node.left == null)
                {
                    node.left = new node<T>(tempValue);
                }
                else
                {
                    node = node.left;
                    Check(node);
                }

            }
            if (node.value.CompareTo(tempValue) == -1)

            {
                if (node.right == null)
                {
                    node.right = new node<T>(tempValue);
                }
                else
                {
                    node = node.right;
                    Check(node);
                }

            }
        }
        public T Search(T value)
        {
            return iSearch(root, value);
        }
        public T iSearch(node<T> node, T value)
        {
            if (node == null)
            {
                return default;
            }
            else if (value.CompareTo(node.value) == 0)
            {
                return node.value;
            }
            else if (value.CompareTo(node.value) == -1)
            {
               return iSearch(node.left, value);
            }
            else 
            {
                return iSearch(node.right, value);
            }
        }

    }
       
}
