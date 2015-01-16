using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of the task FrogRiverOne
	/// https://codility.com/demo/take-sample-test/frog_river_one
	/// and here are results
	/// https://codility.com/demo/results/demo6KZW2R-W9A/
	/// </summary>
	public sealed class FrogRiverOne
	{
		public Int32 Solve(Int32 x, Int32[] input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (x <= 0)
			{
				throw new ArgumentOutOfRangeException("x");
			}

			HashSet<Int32> leaves = new HashSet<Int32>();

			Int32 steps = 0;

			for (Int32 q = 0, qMax = input.Length; q < qMax; q++)
			{
				Int32 currentLeave = input[q];

				if (currentLeave < 1 || currentLeave > x)
				{
					throw new ArgumentOutOfRangeException("currentLeave");
				}

				if (!leaves.Contains(currentLeave))
				{
					leaves.Add(currentLeave);

					steps++;

					if (steps >= x)
					{
						return q;
					}
				}
			}

			return -1;
		}
	}
}
