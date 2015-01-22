using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Training.Tests
{
	[TestClass]
	public sealed class CountSemiprimesTest
	{
		[TestMethod]
		public void TestEmpty()
		{
			Int32[] result = new CountSemiprimes().Solve(30, new Int32[0], new Int32[0]);

			Assert.AreEqual(0, result.Length);
		}

		[TestMethod]
		public void TestExample01()
		{
			Int32[] result = new CountSemiprimes().Solve(30, new Int32[] { 0, 4, 11, 11, 11, 14 }, new Int32[] { 30, 9, 16, 23, 25, 25 });

			Int32[] expected = new Int32[] { 10, 3, 2, 4, 5, 5 };

			Assert.AreEqual(6, result.Length);

			for (Int32 q = 0; q < result.Length; q++)
			{
				Assert.AreEqual(expected[q], result[q]);
			}
		}

		[TestMethod]
		public void TestExample02()
		{
			Int32[] result = new CountSemiprimes().Solve(26, new Int32[] { 1, 4, 16 }, new Int32[] { 26, 10, 20 });

			Int32[] expected = new Int32[] { 10, 4, 0 };

			Assert.AreEqual(3, result.Length);

			for (Int32 q = 0; q < result.Length; q++)
			{
				Assert.AreEqual(expected[q], result[q]);
			}
		}
	}
}
