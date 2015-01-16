using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of the task MaxSliceSum
	/// https://codility.com/demo/take-sample-test/max_slice_sum
	/// and here are results
	/// https://codility.com/demo/results/demoKGBZ9U-G3Z/
	/// </summary>
	public sealed class MaxSliceSum
	{
		public Int32 Solve(Int32[] input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (input.Length == 0)
			{
				return 0;
			}

			if (input.Length == 1)
			{
				return input[0];
			}

			Int64 maxSliceSum = 0;

			Int64 currentSum = 0;

			Nullable<Int32> maxNegative = null;

			Boolean allNegative = true;

			for (Int32 q = 0; q < input.Length; q++)
			{
				Int32 currentItem = input[q];

				if (currentItem >= 0)
				{
					allNegative = false;

					currentSum += currentItem;
				}
				else
				{
					if (maxNegative.HasValue)
					{
						if (currentItem > maxNegative.Value)
						{
							maxNegative = currentItem;
						}
					}
					else
					{
						maxNegative = currentItem;
					}

					if (currentSum + currentItem > 0)
					{
						currentSum += currentItem;
					}
					else
					{
						currentSum = 0;
					}
				}

				if (currentSum > maxSliceSum)
				{
					maxSliceSum = currentSum;
				}
			}

			if (allNegative)
			{
				return maxNegative.Value;
			}

			return (Int32)maxSliceSum;
		}
	}
}
