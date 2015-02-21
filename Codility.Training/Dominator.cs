using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of the task Dominator
	/// https://codility.com/demo/take-sample-test/dominator
	/// and here are results
	/// https://codility.com/demo/results/demoCJF6R7-673/
	/// </summary>
	public sealed class Dominator
	{
		public Int32 Solve(Int32[] input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (input.Length <= 0)
			{
				return -1;
			}

			if (input.Length == 1)
			{
				return 0;
			}

			Dictionary<Int32, Int32> counters = new Dictionary<Int32, Int32>();

			Int32 currentMaxCount = 0;

			Int32 currentMaxItem = 0;

			Int32 lastMaxIndex = -1;

			for (Int32 q = 0; q < input.Length; q++)
			{
				Int32 current = input[q];

				Int32 itemCounter = 0;

				counters.TryGetValue(current, out itemCounter);

				itemCounter++;

				counters[current] = itemCounter;

				if (itemCounter > currentMaxCount)
				{
					currentMaxCount = itemCounter;

					currentMaxItem = current;

					lastMaxIndex = q;
				}
			}

			Int32 half = input.Length / 2;

			if (currentMaxCount > half)
			{
				return lastMaxIndex;
			}
			

			return -1;
		}
	}
}
