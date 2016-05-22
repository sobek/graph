using System;
using System.Collections.Generic;

namespace Graph
{
	public class Node<T>
	{
		#region constructors
		public Node(T data, List<Node<T>> previousNodes = null, List<Node<T>> nextNodes = null)
		{
			Data = data;
			PreviousNodes = previousNodes;
			NextNodes = nextNodes;
		}


		#endregion
		public T Data { get; set; }
		public List<Node<T>> PreviousNodes { get; set; }
		public List<Node<T>> NextNodes { get; set; }
	}
}
