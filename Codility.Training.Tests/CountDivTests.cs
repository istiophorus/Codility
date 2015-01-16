using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Training.Tests
{
	[TestClass]
	public sealed class CountDivTests
	{
		private readonly CountDiv _target = new CountDiv();

		[TestMethod]
		public void Test01()
		{
			Assert.AreEqual(1, _target.Solve(5, 6, 5));

			Assert.AreEqual(1, _target.Solve(5, 7, 5));

			Assert.AreEqual(3, _target.Solve(6, 11, 2));

			Assert.AreEqual(1, _target.Solve(4, 6, 3));

			Assert.AreEqual(3, _target.Solve(6, 13, 3));

			Assert.AreEqual(2, _target.Solve(1, 6, 3));

			Assert.AreEqual(1, _target.Solve(6, 14, 5));

			Assert.AreEqual(2, _target.Solve(6, 15, 5));

			Assert.AreEqual(2, _target.Solve(6, 19, 5));

			Assert.AreEqual(2, _target.Solve(7, 15, 5));

			Assert.AreEqual(1, _target.Solve(0, 1, 11));

			Assert.AreEqual(1, _target.Solve(10, 10, 5));
		}
	}
}





