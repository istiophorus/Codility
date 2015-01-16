using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// solution of the Codility task
	/// https://codility.com/demo/take-sample-test/perm_check
	/// and my results
	/// https://codility.com/demo/results/demoG8UJRV-RAD/
	/// </summary>
	public sealed class PermCheck
	{
		public Int32 Solve(Int32[] elements)
		{
			if (null == elements)
			{
				throw new ArgumentNullException("elements");
			}

			if (elements.Length <= 0)
			{
				return 0;
			}

			Boolean[] flags = new Boolean[elements.Length];

			for (Int32 q = 0, qMax = elements.Length; q < qMax; q++)
			{
				Int32 currentItem = elements[q];

				if (currentItem <= 0 || currentItem > elements.Length)
				{
					return 0;
				}

				if (flags[currentItem - 1])
				{
					return 0;
				}

				flags[currentItem - 1] = true;
			}

			return 1;
		}
	}
}
