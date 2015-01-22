using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of the task EquiLeader
	/// https://codility.com/demo/take-sample-test/equi_leader
	/// and here are results
	/// https://codility.com/demo/results/demoN4WJES-YZU/
	/// </summary>
	public sealed class EquiLeader
	{
		public Int32 Solve(Int32[] input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (input.Length <= 1)
			{
				return 0;
			}

			Nullable<Int32>[] equiLeadersA = new Nullable<Int32>[input.Length - 1];

			Dictionary<Int32, Int32> counters = new Dictionary<Int32, Int32>();

			Nullable<Int32> currentLeader = null;

			Int32 previousLeaderCount = 0;

			for (Int32 q = 0; q < equiLeadersA.Length; q++)
			{
				Int32 currentItem = input[q];

				if (!counters.ContainsKey(currentItem))
				{
					counters.Add(currentItem, 0);
				}

				Int32 half = (q + 1) / 2;

				Int32 newValue = counters[currentItem] + 1;

				counters[currentItem] = newValue;

				if (newValue > half)
				{
					currentLeader = currentItem;

					previousLeaderCount = newValue;
				}
				else if (currentLeader.HasValue && previousLeaderCount > half)
				{
					///
				}
				else
				{
					currentLeader = null;
				}

				equiLeadersA[q] = currentLeader;
			}

			Nullable<Int32>[] equiLeadersB = new Nullable<Int32>[input.Length - 1];

			previousLeaderCount = 0;

			counters.Clear();

			currentLeader = null;

			for (Int32 q = equiLeadersB.Length - 1; q >= 0; q--)
			{
				Int32 currentItem = input[q + 1];

				if (!counters.ContainsKey(currentItem))
				{
					counters.Add(currentItem, 0);
				}

				Int32 half = (input.Length - q - 1) / 2;

				Int32 newValue = counters[currentItem] + 1;

				counters[currentItem] = newValue;

				if (newValue > half)
				{
					currentLeader = currentItem;

					previousLeaderCount = newValue;
				}
				else if (currentLeader.HasValue && previousLeaderCount > half)
				{
					///
				}
				else
				{
					currentLeader = null;
				}

				equiLeadersB[q] = currentLeader;
			}

			Int32 counter = 0;

			for (Int32 q = 0; q < equiLeadersA.Length; q++)
			{
				if (equiLeadersA[q].HasValue && equiLeadersB[q].HasValue)
				{
					if (equiLeadersA[q].Value == equiLeadersB[q].Value)
					{
						counter++;
					}
				}
			}

			return counter;
		}
	}
}
