using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Training.Tests
{
	[TestClass]
	public sealed class ChocolatesByNumbersTests
	{
		private readonly ChocolatesByNumbers _target = new ChocolatesByNumbers();

		[TestMethod]
		public void SampleChockolateTest()
		{
			Int32 result = _target.Solve(10, 4);

			Assert.AreEqual(5, result);
		}

		[TestMethod]
		public void ChockolateTest06()
		{
			Int32 result = _target.Solve(9, 4);

			Assert.AreEqual(9, result);
		}

		[TestMethod]
		public void ChockolateTest07()
		{
			Int32 result = _target.Solve(10, 12);

			Assert.AreEqual(5, result);
		}

		[TestMethod]
		public void ChockolateTest09()
		{
			Int32 result = _target.Solve(1, 2);

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void ChockolateTest01()
		{
			Int32 result = _target.Solve(6, 3);

			Assert.AreEqual(2, result);
		}

		[TestMethod]
		public void ChockolateTest02()
		{
			Int32 result = _target.Solve(6, 1);

			Assert.AreEqual(6, result);
		}

		[TestMethod]
		public void ChockolateTest03()
		{
			Int32 result = _target.Solve(6, 6);

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void ChockolateTest04()
		{
			Int32 result = _target.Solve(6, 7);

			Assert.AreEqual(6, result);
		}

		[TestMethod]
		public void ChockolateTest05()
		{
			Int32 result = _target.Solve(6, 8);

			Assert.AreEqual(3, result);
		}

		[TestMethod]
		public void LargestCommonDivisorTest01()
		{
			Int64 result = ChocolatesByNumbers.LargestCommonDivisor(8, 6);

			Assert.AreEqual(2, result);
		}

		[TestMethod]
		public void LeastCommonMultiplicationTest01()
		{
			Int64 result = ChocolatesByNumbers.LeastCommonMultiplication(2, 3);

			Assert.AreEqual(6, result);
		}

		[TestMethod]
		public void LeastCommonMultiplicationTest02()
		{
			Int64 result = ChocolatesByNumbers.LeastCommonMultiplication(15, 10);

			Assert.AreEqual(30, result);
		}

	}
}
