using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of Codility task:
	/// https://codility.com/demo/take-sample-test/number_of_disc_intersections
	/// with my results
	/// https://codility.com/demo/results/demoHEK58H-ZXF/
	/// </summary>
	public sealed class NumberOfInterSectingDisks
	{
		private class DiscInfo : IComparer<DiscInfo>
		{
			internal Int32 StartPoint { get; set; }

			internal Int32 Radius { get; set; }

			internal Int32 EndPoint { get; set; }

			internal Int32 Center { get; set; }

			public Int32 Compare(DiscInfo x, DiscInfo y)
			{
				return x.EndPoint.CompareTo(y.EndPoint);
			}
		}

		public static Int32 Solve(Int32[] input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (input.Length <= 1)
			{
				return 0;
			}

			List<DiscInfo> discs = new List<DiscInfo>(input.Length);

			for (Int32 q = 0; q < input.Length; q++)
			{
				Int32 currentRadius = input[q];

				if (currentRadius < 0)
				{
					throw new ArgumentException("Invalid radius value " + currentRadius);
				}

				discs.Add(new DiscInfo
				{
					StartPoint = q - currentRadius,
					Radius = currentRadius,
					EndPoint = q + currentRadius,
					Center = q
				});
			}

			discs.Sort((x, y) => x.StartPoint.CompareTo(y.StartPoint));

			List<DiscInfo> closingDiscs = new List<DiscInfo>();

			HashSet<Int32> openedDiscs = new HashSet<Int32>();

			Int32 interSectingDiscs = 0;

			IComparer<DiscInfo> comparer = new DiscInfo();

			for (Int32 q = 0, qMax = discs.Count; q < qMax; q++)
			{
				DiscInfo currentDisc = discs[q];

				Int32 currentStartPoint = currentDisc.StartPoint;

				////////////////////////////////////////////////////////
				//// close pending discs
				////

				while (closingDiscs.Count > 0 && currentStartPoint > closingDiscs[0].EndPoint)
				{
					openedDiscs.Remove(closingDiscs[0].Center);

					closingDiscs.RemoveAt(0);
				}

				interSectingDiscs += openedDiscs.Count;

				if (interSectingDiscs > 10000000)
				{
					return -1;
				}

				openedDiscs.Add(currentDisc.Center);

				if (closingDiscs.Count > 0)
				{
					Int32 index = closingDiscs.BinarySearch(currentDisc, comparer);

					Int32 insertIndex;

					if (index >= 0)
					{
						insertIndex = index;
					}
					else
					{
						insertIndex = ~index;
					}

					closingDiscs.Insert(insertIndex, currentDisc);
				}
				else
				{
					closingDiscs.Add(currentDisc);
				}
			}

			return interSectingDiscs;
		}
	}
}
