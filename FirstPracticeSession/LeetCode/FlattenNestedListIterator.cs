using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPracticeSession.LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/flatten-nested-list-iterator/
    /// </summary>
    public class FlattenNestedListIterator
    {
        public void Main(IList<INestedInteger> input)
        {
            var nestedList = (IList<INestedInteger>) input;
            var i = new NestedIterator(nestedList);
            while (i.HasNext())
                Console.WriteLine(i.Next());
        }
    }

    public class NestedIterator
    {
        private int index = -1;
        private List<int> list = new List<int>();
        public NestedIterator(IList<INestedInteger> nestedList)
        {
            FlattenTheNestedInts(nestedList);
        }

        private void FlattenTheNestedInts(IList<INestedInteger> nestedList)
        {
            foreach (var nestedInteger in nestedList)
            {
                if (nestedInteger.IsInteger())
                    list.Add(nestedInteger.GetInteger());
                else
                    FlattenTheNestedInts(nestedInteger.GetList());
            }
        }

        public bool HasNext()
        {
            if(index < list.Count)
                return true;

            return false;
        }

        public int Next()
        {
            index++;
            return list[index];
        }
    }


    // This is the interface that allows for creating nested lists.
    // You should not implement it, or speculate about its implementation
    public interface INestedInteger
    {

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<INestedInteger> GetList();
    }

}
