using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Training.Tests
{
	[TestClass]
    public class TapeEquilibriumTests
    {
		private readonly TapeEquilibrium _target = new TapeEquilibrium();

		[TestMethod]
		public void TestTaskExample()
		{
			Assert.AreEqual(1, _target.Solve(new Int32[] { 3, 1, 2, 4, 3}));
		}

		[TestMethod]
		public void TestEmpty()
		{
			Assert.AreEqual(0, _target.Solve(new Int32[] { }));
		}

		[TestMethod]
		public void TestSingle()
		{
			for (Int32 q = -10; q < 10; q++)
			{
				Assert.AreEqual(q, _target.Solve(new Int32[] { q }));
			}
		}
    }
}
