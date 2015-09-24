using System;
using System.Collections.Generic;
using DataStructures.Tree;
using AbstractDataType;

namespace SoftwareEngineeringProblems.Problems
{
    public class TreesAndGraphs
    {
        private static void AddToLevelLinkedLists<T>(
            List<DataStructures.LinkedList.SinglyLinkedList<Node<T>>> lists,
            Node<T> node, int depth)
        {
            try
            {
                lists[depth].Add(node);
            }
            catch (ArgumentOutOfRangeException)
            {
                for(var i = lists.Count; i <= depth; i++)
                {
                    lists.Add(new DataStructures.LinkedList.SinglyLinkedList<Node<T>>());
                }
                lists[depth].Add(node);
            }
        }
    }
}