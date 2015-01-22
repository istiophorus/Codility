using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Training.Tests
{
	[TestClass]
	public sealed class EquiLeaderTests
	{
		private readonly EquiLeader _target = new EquiLeader();

		[TestMethod]
		public void Test01()
		{
			Assert.AreEqual(2, _target.Solve(new Int32[] { 4, 3, 4, 4, 4, 2 }));
		}

		[TestMethod]
		public void Test02()
		{
			Assert.AreEqual(1, _target.Solve(new Int32[] { 4, 4 }));
		}

		[TestMethod]
		public void Test03()
		{
			Assert.AreEqual(0, _target.Solve(new Int32[] { 1, 4 }));
		}

		[TestMethod]
		public void Test04()
		{
			Assert.AreEqual(3, _target.Solve(new Int32[] { 4, 4, 2, 5, 3, 4, 4, 4 }));
		}

	}
}
