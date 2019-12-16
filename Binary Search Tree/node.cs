using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class node<T>
    {
        public T value;
        public node<T> left;
        public node<T> right;
       
        public node(T data)
        {
            value = data;
            
            
        }
    }
}
