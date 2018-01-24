using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tester;

namespace Sample
{
  class Program
  {
    /// <summary>
    /// EXERCISE 1: insert a new node with a specified value after a specified node in a doubly linked list
    /// </summary>
    /// <param name="list">the input list</param>
    /// <param name="node">the node after which we want to insert the new value</param>
    /// <param name="value">the value we want to insert</param>
    static void DoublyLinkedListInsertAfter(DoublyLinkedList<int> list, DoubleNode<int> node, int value)
    {
     /*
       * NODE = current node = the new value, but needs a next value... easy!  
       * Newnode =  HEAP N: value = int; node = ref(Y); node.Next = ref(Z);
       * DoubleNode = value, prev and next... So, node is prev... just because...
       * Note: node.Next may be ... node.Next = null 
       * We create a newNode... with the new value and the node is prev and we want to insert next
     */
      DoubleNode<int> newNode = new DoubleNode<int>(value, node, node.Next);
      node.Next = newNode; //we want to insert the value after.
     
      //heap heap(4) == heap(4)
      // last = 4 and node = 4, value 
      if (list.Last == node) 
      {
        // TODO: Ex 1.1
        list.Last = newNode;
      }
      else
      {
        // TODO: Ex 1.2
        newNode.Next.Prev = newNode; //the next doesn't have a ref to pref...
      }
    }

    /// <summary>
    /// SUPPORT METHOD FOR EXERCISE 2: return the index of an object in a hash table of a certain size, given a key
    /// </summary>
    /// <returns>the bucket index corresponding to the key</returns>
    static int getIndex(string key, int size)
    {
      int hashCode = Math.Abs(key.GetHashCode());
      int index = hashCode%size; //TODO: Ex 2.1 REPLACE 0 WITH YOUR CODE
      return index;
    }

    /// <summary>
    /// EXERCISE 2: add a new key-value pair in a hash table
    /// </summary>
    /// <param name="table">the hash table in which to insert</param>
    /// <param name="key">the key to insert</param>
    /// <param name="value">the value to insert</param>
    static void HashTableAdd(HashTable<string, int> table, string key, int value)
    {
      var arraySize = table.buckets.Length;
      int index = getIndex(key, arraySize);
      var values = table.buckets;
      if (values[index] == null)
        values[index] = new Entry<string, int>(key,value);  //TODO: Ex 2.2 PLACEHOLDER: REPLACE null WITH YOUR CODE
      else
      {
        if (values[index].Key.Equals(key))
        {
          throw new ArgumentException("Key already exists");
        }
        else
        {
          // TODO: Ex2.3; potentialIndex = ?
          var potentialIndex = index; // PLACEHOLDER: REMOVE AND REPLACE WITH YOUR CODE

          while (values[potentialIndex] != null)
          {
            potentialIndex++;
            if (potentialIndex >= arraySize) 
              potentialIndex = 0;
            if (potentialIndex == index) 
              return;
          }
          values[potentialIndex] = new Entry<string, int>(key, value);  //TODO: Ex 2.4 PLACEHOLDER: REPLACE null WITH YOUR CODE
        }
      }
    }

    /// <summary>
    /// EXERCISE 3: Bubble Sort algorithm
    /// </summary>
    /// <param name="array">the array containing the values to sort</param>
    static void BubbleSort(int[] array)
    {
      var somethingChanged = true;
      // TODO: Ex3.1; while( ? )
      while(somethingChanged)
      {
        somethingChanged = false;
        for (int i = 0; i < array.Length - 1; i++)
        {
          if (array[i].CompareTo(array[i + 1]) > 0)
          {
            var temp = array[i + 1];
                        // TODO: Ex3.2;
                        array[i + 1] = array[i];
                        array[i] = temp;
            somethingChanged = true;
          }
        }
      }
    }

    /// <summary>
    /// SUPPORT METHOD FOR EXERCISE 4
    /// </summary>
    /// <param name="node">the node where the search starts</param>
    /// <param name="value">the value we are searching for</param>
    /// <returns>the node containing the value found</returns>
    private static TreeNode<int> searchStartingFrom(TreeNode<int> node, int value)
    {
      if (node == null)
        throw new Exception("value not found");

      if (node.value.CompareTo(value) == 0)
        return node; // TODO: Ex 4.2 PLACEHOLDER: REPLACE null WITH YOUR CODE

      if (node.value.CompareTo(value) < 0)
        return searchStartingFrom(node.rightChild,value); // TODO: Ex 4.3 PLACEHOLDER: REPLACE null WITH YOUR CODE

      return searchStartingFrom(node.leftChild, value); // TODO: Ex 4.4 PLACEHOLDER: REPLACE null WITH YOUR CODE
    }

    /// <summary>
    /// EXERCISE 4: search of a specified value in a binary search tree
    /// </summary>
    /// <param name="tree">the binary search tree</param>
    /// <param name="value">the value to search</param>
    /// <returns>the node of the tree containing the value found</returns>
    static TreeNode<int> BSTFind(BSTree<int> tree, int value)
    {
      return searchStartingFrom(tree.root,value); // TODO: Ex 4.1 PLACEHOLDER: REPLACE null WITH YOUR CODE
    }

    /// <summary>
    /// EXERCISE 5: Dijkstra algorithm
    /// </summary>
    /// <param name="adjacencyMatrix">the adjacency matrix representing the graph</param>
    /// <param name="source">the source node for the shortest paths</param>
    /// <returns>a tuple containing: 1) the distance array; 2) the prev array to reconstruct the shortest paths</returns>
    static Tuple<double[], int[]> Dijkstra(double[,] adjacencyMatrix, int source)
    {
      int Count = adjacencyMatrix.GetLength(0);
      double[] distance = new double[Count];
      int[] prev = new int[Count];
      List<int> vertexSet = new List<int>(Count);

      for (int i = 0; i < Count; i++)
      {
        // TODO: Ex 5.1; distance[i] = ?
        //distance[i] = adjacencyMatrix[i,i]; // infinity
        distance[i] = double.PositiveInfinity;
        // TODO: Ex 5.2; prev[i] = ?;
        prev[i] = -1; //undefined ?
        // TODO: Ex 5.3; vertexSet.Add(?);
        vertexSet.Add(i); //add "V to Q"
      }

      distance[source] = 0;
      while (vertexSet.Count > 0)
      {
        int firstUnvisited = vertexSet.First();
        double min = distance[firstUnvisited];
        int minIndex = firstUnvisited;
        foreach(var v in vertexSet)
        {
          if (distance[v] < min)
          {
            // TODO: Ex 5.4 
            min = distance[v];
            minIndex = v;
          }
        }
        vertexSet.Remove(minIndex);
        List<int> neighbors = new List<int>();
        for (int i = 0; i < Count; i++)
        {
          if (adjacencyMatrix[minIndex, i] < Double.PositiveInfinity)
            neighbors.Add(i);
        }

        foreach (var n in neighbors)
        {
          double alternativeDist = distance[minIndex] + adjacencyMatrix[minIndex, n];
          if (alternativeDist < distance[n])
          {
            // TODO: Ex 5.5
            distance[n] = alternativeDist;
            prev[n] = minIndex; 
          }
        }
      }

      return new Tuple<double[], int[]>(distance, prev);

    }

    static void Main(string[] args)
    {
      try
      {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB", false);
        /*Sample1718.TestListInsertAfter(DoublyLinkedListInsertAfter);
        Sample1718.TestHashAdd(HashTableAdd);
        Sample1718.TestSort(BubbleSort);
        Sample1718.TestBSTFind(BSTFind);
        Sample1718.TestDijkstra(Dijkstra);*/

            Sample1718.TestAll(DoublyLinkedListInsertAfter, HashTableAdd, BubbleSort, BSTFind, Dijkstra);
      }
      catch (Exception e)
      {
        Console.WriteLine("Your code gave the following exception: " + e.Message);
      }
    }
  }
}
