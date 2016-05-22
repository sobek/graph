using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
	public class Graph<T> where T : new()
	{
		public Graph() { }
		/// <summary>
		/// Adds a node to the end of a graph. This method will
		/// add a node to all nodes defined as the current 'end' 
		/// by determining whether they have any 'next' nodes.
		/// </summary>
		/// <param name="graph"></param>
		/// <param name="node"></param>
		/// <returns></returns>
		public static Graph<T> Add(Graph<T> graph, Node<T> node)
		{
			throw new NotImplementedException();
		}

		public Graph<T> Remove(Graph<T> graph, Node<T> node)
		{
			throw new NotImplementedException();
		}
	}


}
