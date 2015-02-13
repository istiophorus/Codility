using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of the task GenomicRangeQuery
	/// https://codility.com/demo/take-sample-test/genomic_range_query
	/// and here are results
	/// https://codility.com/demo/results/demoPSXTCR-WK2/
	/// </summary>
	public sealed class GenomicRangeQuery
	{
		private static Int32[] EmptyResult = new Int32[0];

		public Int32[] Solve(String input, Int32[] p, Int32[] w)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (String.IsNullOrWhiteSpace(input))
			{
				throw new ArgumentException("input");
			}

			if (null == p && null == w)
			{
				return EmptyResult;
			}

			if (p.Length != w.Length)
			{
				throw new ArgumentOutOfRangeException("w");
			}

			if (p.Length == 0 && w.Length == 0)
			{
				return EmptyResult;
			}

			Char[] chars = input.ToCharArray();

			//////////////////////////////////////////////////////////////////////////////////////
			//// prepare summaries
			////

			Int32[,] summaries = new Int32[chars.Length, 4];

			for (Int32 q = 0; q < chars.Length; q++)
			{
				Char current = chars[q];

				if (q > 0)
				{
					summaries[q, 0] = summaries[q - 1, 0];
					summaries[q, 1] = summaries[q - 1, 1];
					summaries[q, 2] = summaries[q - 1, 2];
					summaries[q, 3] = summaries[q - 1, 3];
				}

				summaries[q, GetIndex(current)]++;
			}

			Int32[] result = new Int32[p.Length];

			Int32[] currentDiff = new Int32[4];

			for (Int32 q = 0; q < result.Length; q++)
			{
				Int32 indexP = p[q];

				Int32 indexW = w[q];

				if (indexP < 0 || indexP >= chars.Length)
				{
					throw new ArgumentOutOfRangeException("p " + q);
				}

				if (indexW < 0 || indexW >= chars.Length)
				{
					throw new ArgumentOutOfRangeException("w " + q);
				}

				for (Int32 ix = 0; ix < 4; ix++)
				{
					currentDiff[ix] = summaries[indexW, ix] - summaries[indexP, ix];
				}

				currentDiff[GetIndex(chars[indexP])]++;

				for (Int32 ix = 0; ix < 4; ix++)
				{
					if (currentDiff[ix] > 0)
					{
						result[q] = ix + 1;
						break;
					}
				}
			}

			return result;
		}

		private static Int32 GetIndex(Char ch)
		{
			switch (ch)
			{
				case 'a':
				case 'A':
					return 0;

				case 'c':
				case 'C':
					return 1;

				case 'g':
				case 'G':
					return 2;

				case 't':
				case 'T':
					return 3;

				default:
					throw new ArgumentOutOfRangeException("ch");
			}
		}

		private static Int32 GetImpactFactor(Char ch)
		{
			switch (ch)
			{
				case 'a':
				case 'A':
					return 1;

				case 'c':
				case 'C':
					return 2;

				case 'g':
				case 'G':
					return 3;

				case 't':
				case 'T':
					return 4;

				default:
					throw new ArgumentOutOfRangeException("ch");
			}
		}
	}
}
