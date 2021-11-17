using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class TreeMap
    {
        private TreeMapNode topNode = null;

        public void Add(IComparable key, object value)
        {
            if(topNode == null)
            {
                topNode = new TreeMapNode(key, value);
            }
            else
            {
                topNode.Add(key, value);
            }
        }

        public object Get(IComparable key)
        {
            return topNode == null ? null : topNode.Find(key);
        }
    }

    public class TreeMapNode
    {
        private IComparable key;
        private object value;
        private static readonly int LESS = 0;
        private static readonly int GREATER = 1;
        private TreeMapNode[] nodes = new TreeMapNode[2];

        public TreeMapNode(IComparable key, object value)
        {
            this.key = key;
            this.value = value;
        }

        public void Add(IComparable key, object value)
        {
            if(key.CompareTo(this.key) == 0)
            {
                this.value = value;
            }
            else
            {
                AddSubNode(SelectSubNode(key), key, value);
            }
        }

        private int SelectSubNode(IComparable key)
        {
            return (key.CompareTo(this.key) < 0) ? LESS : GREATER;
        }

        private void AddSubNode(int node, IComparable key, object value)
        {
            if(nodes[node] == null)
            {
                nodes[node] = new TreeMapNode(key, value);
            }
            else
            {
                nodes[node].Add(key, value);
            }
        }

        public object Find(IComparable key)
        {
            if (key.CompareTo(this.key) == 0)
                return value;
            return FindSubNodeForKey(SelectSubNode(key), key);
        }

        private object FindSubNodeForKey(int node, IComparable key)
        {
            return nodes[node] == null ? null : nodes[node].Find(key);
        }
    }

}
