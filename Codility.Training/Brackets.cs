using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Training
{
	/// <summary>
	/// my solution of codility Brackets task
	/// https://codility.com/demo/take-sample-test/brackets
	/// with results
	/// https://codility.com/demo/results/demoBPMYF4-ZVZ/
	/// </summary>
	public sealed class Brackets
	{
		public Int32 Solve(String input)
		{
			if (null == input)
			{
				throw new ArgumentNullException("input");
			}

			if (String.IsNullOrWhiteSpace(input))
			{
				return 1;
			}

			Char[] chars = input.ToCharArray();

			Stack<Char> stack = new Stack<Char>();

			Dictionary<Char, Char> map = new Dictionary<Char, Char>()
			{
				{'{', '}'},
				{'[', ']'},
				{'(', ')'}
			};

			for (Int32 q = 0; q < chars.Length; q++)
			{
				Char current = chars[q];

				if (current == '{' || current == '[' || current == '(')
				{
					stack.Push(current);
				}
				else if (current == '}' || current == ']' || current == ')')
				{
					if (stack.Count >= 1)
					{
						Char topItem = stack.Peek();

						if (current == map[topItem])
						{
							stack.Pop();
						}
						else
						{
							return 0;
						}
					}
					else
					{
						return 0;
					}
				}
			}

			if (stack.Count > 0)
			{
				return 0;
			}

			return 1;
		}
	}
}
