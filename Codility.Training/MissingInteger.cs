using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// solution of Codility problem:
	/// https://codility.com/demo/take-sample-test/missing_integer
	/// and my solution:
	/// https://codility.com/demo/results/demoCJS5D6-K9G/
	/// </summary>
	public sealed class MissingInteger
	{
		public Int32 Solve(Int32[] input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (input.Length <= 0)
			{
				return 1;
			}

			HashSet<Int32> items = new HashSet<Int32>();

			Boolean allNonpositive = true;

			for (Int32 q = 0; q < input.Length; q++)
			{
				Int32 currentItem = input[q];

				if (currentItem > 0)
				{
					allNonpositive = false;

					if (!items.Contains(currentItem))
					{
						items.Add(currentItem);
					}
				}
			}

			if (allNonpositive)
			{
				return 1;
			}

			for (Int32 q = 1; ; q++)
			{
				if (!items.Contains(q))
				{
					return q;
				}
			}

			throw new ApplicationException("How did it happen ??");
		}
	}
}
