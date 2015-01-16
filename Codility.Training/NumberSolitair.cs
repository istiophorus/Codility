using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my soution of the Codility problem:
	/// https://codility.com/demo/take-sample-test/number_solitaire
	/// with results
	/// https://codility.com/demo/results/demoWVAR9N-333/
	/// </summary>

	public sealed class NumberSolitair
	{
		public Int32 Solve(Int32[] input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (input.Length <= 0)
			{
				throw new ArgumentException();
			}

			Nullable<Int32>[] maxValues = new Nullable<Int32>[input.Length];

			for (Int32 q = 0; q < input.Length; q++)
			{
				Nullable<Int32> previousMax = GetMaxValue(maxValues, q);

				if (previousMax.HasValue)
				{
					maxValues[q] = previousMax.Value + input[q];
				}
				else
				{
					maxValues[q] = input[q];
				}
			}

			return maxValues[input.Length - 1].Value;
		}

		private static Nullable<Int32> GetMaxValue(Nullable<Int32>[] maxValues, Int32 index)
		{
			Nullable<Int32> currentMax = null;

			for (Int32 q = 1; q <= 6; q++)
			{
				Int32 backItem = index - q;

				if (backItem >= 0)
				{
					if (!currentMax.HasValue || (currentMax.HasValue && maxValues[backItem].Value > currentMax.Value))
					{
						currentMax = maxValues[backItem];
					}
				}
			}

			return currentMax;
		}
	}
}
