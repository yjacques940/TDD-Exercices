using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TestsUnitairesExercices.FilePriseUn
{
	[TestFixture]
	class FilePriseUnTests
	{
		[Test]
		public void EmptyList_AddElement_ReturnElement()
		{
			var list = new List<int>();
			list.Add(1);
			Assert.AreEqual(1, list.First());
		}

		[Test]
		public void EmptyList_RemoveElement_ReturnElement()
		{
			var list = new List<int>();
			list.Remove(1);
			Assert.AreEqual(false, list.Any());
		}

		[Test]
		public void ListWithValues_AddElement_ReturnElement()
		{
			var list = new List<int>();
			list.Add(1);
			list.Add(2);
			Assert.AreEqual(1, list.First());
		}

		[Test]
		public void ListWithValues_RemoveElement_ReturnElement()
		{
			var list = new List<int>();
			list.Add(1);
			list.Add(2);
			list.Remove(list.First());
			Assert.AreEqual(1, list.Count);
		}
	}
}
