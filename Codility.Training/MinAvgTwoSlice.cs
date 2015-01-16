using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of the task FrogRiverOne
	/// https://codility.com/demo/take-sample-test/min_avg_two_slice
	/// and here are results
	/// https://codility.com/demo/results/demo8WQ2PM-NMU/
	/// </summary>
	public sealed class MinAvgTwoSlice
	{
		public static Int32 Solve(Int32[] input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (input.Length < 2)
			{
				throw new ArgumentException("input is empty");
			}

			Int32 sliceStartStop = input.Length - 1;

			Int32 minSliceIndex = 0;

			Int32 sliceStart = 0;

			Int32 sliceEnd = 1;

			Int64 currentSliceSum = input[sliceStart] + input[sliceEnd];

			Int32 currentSliceLength = sliceEnd - sliceStart + 1;

			Double minSliceAvg = (currentSliceSum * 1.0) / currentSliceLength;

			while (sliceEnd < input.Length && sliceStart < sliceStartStop)
			{
				if (currentSliceLength == 2)
				{
					if (sliceEnd < sliceStartStop) //// there can be a longer slice
					{
						sliceEnd++;

						currentSliceLength++;

						currentSliceSum += input[sliceEnd];

						Double currentSliceAvg = currentSliceSum * 1.0 / currentSliceLength;

						if (currentSliceAvg < minSliceAvg)
						{
							minSliceAvg = currentSliceAvg;

							minSliceIndex = sliceStart;
						}
					}
					else
					{
						break;
					}
				}
				else if (currentSliceLength == 3)
				{
					currentSliceSum -= input[sliceStart];

					sliceStart++;

					currentSliceLength--;

					Double currentSliceAvg = currentSliceSum * 1.0 / currentSliceLength;

					if (currentSliceAvg < minSliceAvg)
					{
						minSliceAvg = currentSliceAvg;

						minSliceIndex = sliceStart;
					}
				}
				else
				{
					throw new ApplicationException("How did it happen ??");
				}
			}

			return minSliceIndex;
		}
	}
}
