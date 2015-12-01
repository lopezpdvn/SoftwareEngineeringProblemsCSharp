using System;
using System.Collections.Generic;
using Xunit;
using SoftwareEngineeringProblems.Problems;
using System.Collections;
using DataStructuresAlgorithms.DataStructures.Tree;

namespace SoftwareEngineeringProblems.Tests
{
    public class TreesAndGraphsTests
    {
        BinaryTree<char> treeLetters;
        IDictionary treeLetter = new Hashtable();

        public TreesAndGraphsTests()
        {
            var _J = new Node<char>('J');
            var _I = new Node<char>(_J, null, 'I');
            var _H = new Node<char>(null, _I, 'H');
            var _D = new Node<char>(_H, null, 'D');
            var _M = new Node<char>(null, null, 'M');
            var _L = new Node<char>(null, _M, 'L');
            var _K = new Node<char>(_L, null, 'K');
            var _E = new Node<char>(_K, null, 'E');
            var _B = new Node<char>(_D, _E, 'B');
            var _F = new Node<char>(null, null, 'F');
            var _S = new Node<char>(null, null, 'S');
            var _R = new Node<char>(_S, null, 'R');
            var _N = new Node<char>(_R, null, 'N');
            var _Q = new Node<char>(null, null, 'Q');
            var _P = new Node<char>(null, _Q, 'P');
            var _O = new Node<char>(null, _P, 'O');
            var _G = new Node<char>(_N, _O, 'G');
            var _C = new Node<char>(_F, _G, 'C');
            var _A = new Node<char>(_B, _C, 'A');
            treeLetters = new BinaryTree<char>(_A);
            treeLetter["tree"] = treeLetters;
            treeLetter["bf_traversal_char_array"] =
                "ABCDEFGHKNOILRPJMSQ".ToCharArray();

        }
    }
}