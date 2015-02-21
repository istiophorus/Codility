using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Training.Tests
{
	[TestClass]
	public sealed class DominatorTests
	{
		private readonly Dominator _target = new Dominator();

		[TestMethod]
		public void Test01()
		{
			Int32 index = _target.Solve(new Int32[] { 3, 4, 3, 2, 3, -1, 3, 3 });

			Assert.AreEqual(7, index);
		}

		[TestMethod]
		public void TestEmpty()
		{
			Int32 index = _target.Solve(new Int32[] { });

			Assert.AreEqual(-1, index);
		}

		[TestMethod]
		public void TestSingle()
		{
			Int32 index = _target.Solve(new Int32[] { 1 });

			Assert.AreEqual(0, index);
		}

		[TestMethod]
		public void TestNoDominator()
		{
			Int32 index = _target.Solve(new Int32[] { 1, 2, 3, 4});

			Assert.AreEqual(-1, index);
		}

		[TestMethod]
		public void TestNoDominator2()
		{
			Int32 index = _target.Solve(new Int32[] { 1, 2, 2, 4 });

			Assert.AreEqual(-1, index);
		}
	}
}
