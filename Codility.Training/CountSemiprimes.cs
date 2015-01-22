using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of the task CountSemiprimes
	/// https://codility.com/demo/take-sample-test/count_semiprimes
	/// and here are results
	/// https://codility.com/demo/results/demoFGQSZ4-QTP/
	/// </summary>
	public sealed class CountSemiprimes
	{
		private class NumberInfo
		{
			internal Int32 Value { get; set; }

			internal Int32 CurrentValue { get; set; }
		}

		public Int32[] Solve(Int32 maxN, Int32[] rangeP, Int32[] rangeQ)
		{
			if (null == rangeP)
			{
				throw new ArgumentNullException("rangeP");
			}

			if (null == rangeQ)
			{
				throw new ArgumentNullException("rangeQ");
			}

			if (rangeP.Length != rangeQ.Length)
			{
				throw new ArgumentOutOfRangeException("rangeQ");
			}

			if (rangeP.Length == 0)
			{
				return new Int32[0];
			}

			Int32[] result = new Int32[rangeP.Length];

			Dictionary<Int32, NumberInfo> semiPrimesList = GetSemiPrimes(maxN);

			Int32[] subs = new Int32[maxN + 2];

			Int32 currentSemiprimes = 0;

			for (Int32 q = 0; q < subs.Length; q++)
			{
				subs[q] = currentSemiprimes;

				if (semiPrimesList.ContainsKey(q))
				{
					currentSemiprimes++;
				}
			}

			for (Int32 ix = 0; ix < rangeP.Length; ix++)
			{
				Int32 p = rangeP[ix];

				Int32 q = rangeQ[ix];

				result[ix] = subs[q + 1] - subs[p];
			}

			return result;
		}

		private static Dictionary<Int32, NumberInfo> GetSemiPrimes(Int32 maxN)
		{
			Dictionary<Int32, NumberInfo> primes = new Dictionary<Int32, NumberInfo>();

			Dictionary<Int32, NumberInfo> semiPrimes = new Dictionary<Int32, NumberInfo>();

			List<Int32> numbersList = new List<Int32>();

			for (Int32 q = 2; q <= maxN; q++)
			{
				primes.Add(q, new NumberInfo
				{
					Value = q,
					CurrentValue = q
				});

				numbersList.Add(q);
			}

			List<Int32> itemsToMove = new List<Int32>();

			Int32 limit = (Int32)Math.Ceiling(Math.Sqrt(maxN));

			while (numbersList.Count > 0)
			{
				Int32 currentItem = numbersList[0];

				if (!primes.ContainsKey(currentItem))
				{
					numbersList.RemoveAt(0);

					continue;
				}

				if (currentItem > limit)
				{
					break;
				}

				itemsToMove.Clear();

				foreach (KeyValuePair<Int32, NumberInfo> pair in primes)
				{
					if (pair.Value.CurrentValue % currentItem == 0 && pair.Key != currentItem)
					{
						pair.Value.CurrentValue /= currentItem;

						itemsToMove.Add(pair.Key);
					}
				}

				foreach (Int32 item in itemsToMove)
				{
					semiPrimes.Add(item, primes[item]);

					primes.Remove(item);
				}

				numbersList.RemoveAt(0);
			}

			itemsToMove.Clear();

			foreach (KeyValuePair<Int32, NumberInfo> pair in semiPrimes)
			{
				if (!primes.ContainsKey(pair.Value.CurrentValue))
				{
					itemsToMove.Add(pair.Key);
				}
			}

			foreach (Int32 item in itemsToMove)
			{
				semiPrimes.Remove(item);
			}

			return semiPrimes;
		}
	}
}
