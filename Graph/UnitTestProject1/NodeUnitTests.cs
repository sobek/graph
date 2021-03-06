﻿using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Graph;


namespace GraphTestProject
{
	[TestClass]
	public class NodeUnitTests
	{
		private readonly List<Node<int>> previousNodeList = new List<Node<int>> { new Node<int>(1)};
		private readonly List<Node<int>> nextNodeList = new List<Node<int>> {new Node<int>(2)};

		private readonly List<Node<string>> stringPreviousNodeList = new List<Node<string>> { new Node<string>("1") };
		private readonly List<Node<string>> stringNextNodeList = new List<Node<string>> { new Node<string>("2") };

		private readonly Node<int> node1 = new Node<int>(42);
		private readonly Node<int> node2 = new Node<int>(39);

		[TestMethod]
		public void NodeCreate_InstantiatesAllFieldsInt()
		{
			var newNode = new Node<int>(nextNodes: nextNodeList, previousNodes: previousNodeList, data: 42 );
			Assert.IsTrue(newNode.Data == 42);
			Assert.IsTrue(newNode.PreviousNodes.Count == 1);
			Assert.IsTrue(newNode.NextNodes.Count == 1);
			Assert.IsTrue(newNode.PreviousNodes.Select(t => t.Data).Contains(1));
			Assert.IsTrue(newNode.NextNodes.Select(t => t.Data).Contains(2));
		}

		[TestMethod]
		public void NodeCreate_InstantiatesAllFieldsString()
		{
			var newNode = new Node<string>(nextNodes: stringNextNodeList, previousNodes: stringPreviousNodeList, data: "42");
			Assert.IsTrue(newNode.Data == "42");
			Assert.IsTrue(newNode.PreviousNodes.Count == 1);
			Assert.IsTrue(newNode.NextNodes.Count == 1);
			Assert.IsTrue(newNode.PreviousNodes.Select(t => t.Data).Contains("1"));
			Assert.IsTrue(newNode.NextNodes.Select(t => t.Data).Contains("2"));
		}

		[TestMethod]
		public void Node_AreNoteEqual()
		{
			var testNode = new Node<int>(42);

			Assert.IsTrue(testNode == node1);
			Assert.IsTrue(node1 != node2);
			Assert.IsTrue(testNode.Equals(node1));
		}


	}
}
