using System.Linq;
using Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class GraphUnitTests
	{
		private readonly Graph<Node<int>, int> graph = new Graph<Node<int>, int>();
		private readonly Node<int> node1 = new Node<int>(42);

		private readonly Node<int> node2 = new Node<int>(39);
		private readonly Graph<Node<int>, int> graph2 = new Graph<Node<int>, int>(new Node<int>(42));

		[TestMethod]
		public void Graph_AddNode()
		{
			Assert.IsTrue(graph.Add(node1));
		}

		[TestMethod]
		public void Graph_AddNodes()
		{
			Assert.IsTrue(graph.Add(node2));

		}
	}
}
