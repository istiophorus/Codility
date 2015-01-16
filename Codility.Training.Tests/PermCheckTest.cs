using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Training.Tests
{
	[TestClass]
	public sealed class PermCheckTest
	{
		private readonly PermCheck _target = new PermCheck();

		[TestMethod]
		public void TestEmpty()
		{
			Assert.AreEqual(0, _target.Solve(new Int32[] { }));
		}

		[TestMethod]
		public void Test01()
		{
			Assert.AreEqual(0, _target.Solve(new Int32[] { 1,3 }));
		}

		[TestMethod]
		public void Test02()
		{
			Assert.AreEqual(1, _target.Solve(new Int32[] { 2, 1 }));
		}

		[TestMethod]
		public void Test03()
		{
			Assert.AreEqual(1, _target.Solve(new Int32[] { 2, 1, 3 }));
		}

		[TestMethod]
		public void Test04()
		{
			Assert.AreEqual(0, _target.Solve(new Int32[] { 2, 1, 4 }));
		}
	}
}
