using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	public sealed class CountDiv
	{
		/// <summary>
		/// my solution of the codility task:
		/// https://codility.com/demo/take-sample-test/count_div
		/// with results
		/// https://codility.com/demo/results/demo2ZCSZK-UTQ/
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="k"></param>
		/// <returns></returns>
		public Int32 Solve(Int32 a, Int32 b, Int32 k)
		{
			if (a < 0)
			{
				throw new ArgumentOutOfRangeException("a");
			}

			if (b < 0)
			{
				throw new ArgumentOutOfRangeException("b");
			}

			if (k < 1)
			{
				throw new ArgumentOutOfRangeException("k");
			}

			if (a > b)
			{
				throw new ArgumentOutOfRangeException("a");
			}

			Int32 rangeLength = b - a + 1;

			if (k == 1)
			{
				return rangeLength;
			}

			if (rangeLength % k == 0) /// if range length is a multiple of k 
			{
				return rangeLength / k;
			}
			else
			{
				if (a % k == 0)
				{
					return rangeLength / k + 1;
				}

				if (a % k + rangeLength % k> k)
				{
					return rangeLength / k + 1;
				}
				else
				{
					return rangeLength / k;
				}
			}
		}
	}
}
