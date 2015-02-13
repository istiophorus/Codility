using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.Training.Tests
{
	[TestClass]
	public sealed class GenomicRangeQueryTest
	{
		private readonly GenomicRangeQuery _target = new GenomicRangeQuery();

		[TestMethod]
		public void TestNull()
		{
			Int32[] result = _target.Solve("ACGT", null, null);

			Assert.IsNotNull(result);

			Assert.AreEqual(0, result.Length);
		}

		[TestMethod]
		public void TestEmpty()
		{
			Int32[] result = _target.Solve("ACGT", new Int32[0], new Int32[0]);

			Assert.IsNotNull(result);

			Assert.AreEqual(0, result.Length);
		}

		[TestMethod]
		public void SampleTest()
		{
			Int32[] result = _target.Solve("CAGCCTA", new Int32[] { 2, 5, 0 }, new Int32[] { 4, 5, 6});

			Assert.IsNotNull(result);

			Int32[] expected = new Int32[] { 2, 4, 1 };

			Assert.AreEqual(3, result.Length);

			for (Int32 q = 0; q < result.Length; q++)
			{
				Assert.AreEqual(expected[q], result[q]);
			}
		}

		[TestMethod]
		public void SampleTest2()
		{
			Int32[] result = _target.Solve("CAGCCTA", new Int32[] { 0, 0, 0, 2 }, new Int32[] { 0, 1, 2, 6 });

			Assert.IsNotNull(result);

			Int32[] expected = new Int32[] { 2, 1, 1, 1 };

			Assert.AreEqual(4, result.Length);

			for (Int32 q = 0; q < result.Length; q++)
			{
				Assert.AreEqual(expected[q], result[q]);
			}
		}
	}
}
