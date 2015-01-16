using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// solution of the codility training task
	/// https://codility.com/demo/take-sample-test/tape_equilibrium
	/// and here are my results:
	/// https://codility.com/demo/results/demoPG98CP-UQA/
	/// </summary>
	public sealed class TapeEquilibrium
    {
		public Int32 Solve(Int32[] input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (input.Length <= 0)
			{
				return 0;
			}

			if (input.Length == 1)
			{
				return input[0];
			}

			List<Int64> sums = new List<Int64>();

			Int64 sumOfAll = 0;

			for (Int32 q = 0; q < input.Length - 1; q++)
			{
				sumOfAll += input[q];

				sums.Add(sumOfAll);
			}

			sumOfAll += input[input.Length - 1];

			Int64 minSum = Int32.MaxValue;

			for (Int32 q = 0; q < sums.Count; q++)
			{
				Int64 currentValue = Math.Abs(2 * sums[q] - sumOfAll);

				if (currentValue < minSum)
				{
					minSum = currentValue;
				}
			}

			return (Int32)minSum;
		}
    }
}
