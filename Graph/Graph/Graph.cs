using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		/// <summary>
		/// Adds a node to the end of a graph. This method will
		/// add a node to all nodes defined as the current 'end' 
		/// by determining whether they have any 'next' nodes.
		/// </summary>
		/// <param name="node"></param>
		/// <returns>Returns true if node was successfully added.</returns>
		public bool Add(Node<U> node)
		{
			var endNodes = nodes.Where(t => (t.NextNodes?.Count ?? 0) == 0);
			if (!(nodes.Count > 0))
			{
				try
				{
					nodes.Add(node as T);
				}
				catch (Exception) //TODO Specify exception types.
				{
					return false;
				}
				return true;
			}

			return !true;
			//throw new NotImplementedException();

		}


		///// <summary>
		///// Removes the first instance of a given node. If node occurs at the same level 
		///// in different paths, it will only be removed from the first path.
		///// </summary>
		///// <param name="graph"></param>
		///// <param name="node"></param>
		///// <returns></returns>
		//public Graph<T> Remove(Graph<T> graph, Node<T> node)
		//{
		//	throw new NotImplementedException();
		//}
	}


}
