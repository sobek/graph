using System.Linq;
using Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class GraphUnitTests
	{
		private readonly Graph<Node<int>, int> graph = new Graph<Node<int>, int>();
		private readonly Node<int> node = new Node<int>(42);

		[TestMethod]
		public void Graph_AddNode()
		{
			graph.Add(node);

			Assert.IsTrue(graph.Contains(node));
		}
	}
}
