using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of the codility task:
	/// https://codility.com/demo/take-sample-test/chocolates_by_numbers
	/// with results
	/// https://codility.com/demo/results/demoX7HBP9-4NJ/
	/// </summary>
	public sealed class ChocolatesByNumbers
	{
		public Int32 Solve(Int32 n, Int32 m)
		{
			return (Int32)SolveImpl(n, m);
		}

		private Int64 SolveImpl(Int64 n, Int64 m)
		{
			Console.WriteLine("{0} {1}", n, m);

			if (n <= 0)
			{
				throw new ArgumentOutOfRangeException("n");
			}

			if (m <= 0)
			{
				throw new ArgumentOutOfRangeException("m");
			}

			if (n >= m)
			{
				if (n % m == 0)
				{
					return n / m;
				}
				else
				{
					Int64 mult = (Int64)LeastCommonMultiplication(n, m);

					return (mult / m);
				}
			}
			else
			{
				if (m % n == 0)
				{
					return 1;
				}
				else
				{
					return SolveImpl(n, m % n);
				}
			}
		}

		public static Int64 LargestCommonDivisor(Int64 a, Int64 b)
		{
			if (a <= 0)
			{
				throw new ArgumentOutOfRangeException("a");
			}

			if (b <= 0)
			{
				throw new ArgumentOutOfRangeException("b");
			}

			if (a == b)
			{
				return a;
			}

			if (a > b)
			{
				if (a % b == 0)
				{
					return b;
				}

				return LargestCommonDivisor(a % b, b);
			}
			else
			{
				if (b % a == 0)
				{
					return a;
				}

				return LargestCommonDivisor(b % a, a);
			}
		}

		public static Int64 LeastCommonMultiplication(Int64 a, Int64 b)
		{
			if (a <= 0)
			{
				throw new ArgumentNullException("a");
			}

			if (b <= 0)
			{
				throw new ArgumentOutOfRangeException("b");
			}

			if (a == b)
			{
				return a;
			}

			if (a >= b)
			{
				if (a % b == 0)
				{
					return a;
				}
				else
				{
					return (Int64)a * (Int64)b / (Int64)LargestCommonDivisor(a, b);
				}
			}
			else
			{
				return LeastCommonMultiplication(b, a);
			}
		}
	}
}
