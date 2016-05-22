using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Graph
{
	public class Node<T> : IEquatable<Node<T>>
	{
		#region constructors
		public Node(T data, List<Node<T>> previousNodes = null, List<Node<T>> nextNodes = null)
		{
			Data = data;
			PreviousNodes = previousNodes ?? new List<Node<T>>();
			NextNodes = nextNodes ?? new List<Node<T>>();
		}


		#endregion
		public T Data { get; set; }
		public List<Node<T>> PreviousNodes { get; set; }
		public List<Node<T>> NextNodes { get; set; }


		public bool Equals(Node<T> other)
		{
			try
			{
				return Data.Equals(other.Data) &&
				       PreviousNodes.Select(t => t.Data).SequenceEqual(other.PreviousNodes.Select(t => t.Data)) &&
				       NextNodes.Select(t => t.Data).SequenceEqual(other.NextNodes.Select(t => t.Data));
			}
			catch(Exception)
			{
				return false;
			}
		}

		public static bool operator == (Node<T> firstNode, Node<T> secondNode) =>
			firstNode?.Equals(secondNode) ?? false;

		public static bool operator !=(Node<T> firstNode, Node<T> secondNode) =>
			!firstNode?.Equals(secondNode) ?? false;
	}
}
