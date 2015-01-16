using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Training.Tests
{
	[TestClass]
	public sealed class BracketsTest
	{
		private readonly Brackets _target = new Brackets();

		[TestMethod]
		public void TestParentheses()
		{
			Assert.AreEqual(1, _target.Solve("{}"));

			Assert.AreEqual(1, _target.Solve("[]"));

			Assert.AreEqual(1, _target.Solve("()"));

			Assert.AreEqual(1, _target.Solve("([])"));

			Assert.AreEqual(0, _target.Solve("([)]"));

			Assert.AreEqual(0, _target.Solve("("));

			Assert.AreEqual(0, _target.Solve("[]("));
		}
	}
}


