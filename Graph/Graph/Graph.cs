using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO - Methods to implmenet: Truncate, InsertAfter, InsertBefore
namespace Graph
{
	public class Graph<T, U> : IEnumerable<T> where T : Node<U> 
	{
		private List<T> nodes;

		IEnumerator<T> IEnumerable<T>.GetEnumerator() =>
			nodes.GetEnumerator();

		public IEnumerator GetEnumerator() =>
			nodes.GetEnumerator();

		public Graph()
		{
			nodes = new List<T>();
		}

		public Graph(T node)
		{
			nodes = new List<T> { node };
		}

		/// <summary>
		/// Adds a node to the end of a graph. This method will
		/// add a node to all nodes defined as the current 'end' 
		/// by determining whether they have any 'next' nodes.
		/// </summary>
		/// <param name="node"></param>
		/// <returns>Returns true if node was successfully added.</returns>
		public bool Add(T node)
		{
			if (!(nodes.Count > 0))
			{
				try
				{
					nodes.Add(node);
				}
				catch (Exception) //TODO Specify exception types.
				{
					return false;
				}
				return true;
			}

			try
			{
				var endNodes = nodes.Where(t => (t.NextNodes?.Count ?? 0) == 0).ToList();

				foreach (var terminus in endNodes)
				{
					terminus.NextNodes.Add(node);
				}

				node.PreviousNodes.AddRange(endNodes);
				nodes.Add(node);
			}
			catch (Exception) //TODO Specify exception types.
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// Removes the first occurrence of a given node. If node occurs
		/// in different paths, it will only be removed from the first path.
		/// </summary>
		/// <param name="node"></param>
		/// <returns>Returns true if item removed successfully.</returns>
		public bool Remove(T node)
		{
			if (nodes.All(t => t != node))
				return false;

			foreach (var previousItem in nodes.Find(t => t == node).PreviousNodes)
			{
				previousItem.NextNodes.RemoveAll(t => t == node);
				previousItem.NextNodes.AddRange(node.NextNodes);
			}

			foreach (var nextItem in nodes.Find(t => t == node).NextNodes)
			{
				nextItem.PreviousNodes.RemoveAll(t => t == node);
				nextItem.PreviousNodes.AddRange(node.PreviousNodes);
			}

			return nodes.Remove(node);
		}

		/// <summary>
		/// Finds the first occurrence of a node and removes the next node(s). 
		/// If node occurs in different paths, it will only be removed from the first path.
		/// </summary>
		/// <param name="node"></param>
		/// <returns></returns>
		public bool RemoveAfter(T node) => 
			node.NextNodes.Aggregate(true, (current, nodule) => current && Remove(nodule as T));
	}


}
