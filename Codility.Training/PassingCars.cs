using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of the task MaxSliceSum
	/// https://codility.com/demo/take-sample-test/passing_cars
	/// and here are results
	/// https://codility.com/demo/results/demoR6FDN6-7BZ/
	/// </summary>
	public sealed class PassingCars
	{
		public Int32 Solve(Int32[] input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (input.Length <= 0)
			{
				throw new ArgumentException("input is empty");
			}

			Int32 passingCars = 0;

			Int32 currentEasters = 0;

			for (Int32 q = 0; q < input.Length; q++)
			{
				Int32 currentCar = input[q];

				if (currentCar >= 0 && currentCar <= 1)
				{
					if (currentCar == 0)
					{
						currentEasters++;
					}
					else //// wester - he should pass all counted easters
					{
						passingCars += currentEasters;

						if (passingCars > 1000000000)
						{
							return -1;
						}
					}
				}
				else
				{
					throw new ApplicationException("Buldozer on the read " + currentCar);
				}
			}

			return passingCars;
		}
	}
}
