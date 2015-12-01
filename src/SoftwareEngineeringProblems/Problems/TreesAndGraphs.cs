using System;
using System.Collections.Generic;
using DataStructuresAlgorithms.DataStructures.Tree;

namespace SoftwareEngineeringProblems.Problems
{
    public class TreesAndGraphs
    {
        private static void AddToLevelLinkedLists<T>(
            List<DataStructuresAlgorithms.DataStructures.LinkedList.SinglyLinkedList<Node<T>>> lists,
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
                    lists.Add(new DataStructuresAlgorithms.DataStructures.LinkedList.SinglyLinkedList<Node<T>>());
                }
                lists[depth].Add(node);
            }
        }
    }
}