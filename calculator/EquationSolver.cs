namespace calculator
{
    internal class EquationSolver
    {
        static char[] numArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.' };

        public static void Solve(List<string> order, ref string equation)
        {
            string? temp = null;
            int pos;
            int endLeft = 0;
            int endRight = 0;

            for (int i = 2; i < order[0].Length; i++)
            {
                temp += order[0][i];
            }
            pos = int.Parse(temp);

            string? numberA = null;
            int j = 1;
            while (pos - j >= 0)
            {
                if (numArray.Contains(equation[pos - j]))
                {
                    numberA = equation[pos - j] + numberA;
                }
                else { break; }
                endLeft = pos - j;
                j++;
            }

            string? numberB = null;
            j = 1;
            while (pos + j < equation.Length)
            {
                if (numArray.Contains(equation[pos + j]))
                {
                    numberB += equation[pos + j];
                }
                else { break; }
                endRight = pos + j;
                j++;
            }

            //Console.WriteLine("A = " + numberA);
            //Console.WriteLine("B = " + numberB);

            //Console.WriteLine("endL = " + endLeft);
            //Console.WriteLine("endR = " + endRight);

            char operation = order[0][1];
            double? result = null;

            Console.WriteLine("Before calc A:" + numberA + "| B:" + numberB);

            switch (operation)
            {
                case '+':
                    result = double.Parse(numberA) + double.Parse(numberB);
                    break;
                case '-':
                    result = double.Parse(numberA) - double.Parse(numberB);
                    break;
                case '*':
                    result = double.Parse(numberA) * double.Parse(numberB);
                    break;
                case '/':
                    result = double.Parse(numberA) / double.Parse(numberB);
                    break;
            }

            //Console.WriteLine(result);

            equation = equation.Remove(endLeft, endRight - endLeft + 1);

            equation = equation.Insert(endLeft, Convert.ToString(result));

            Console.WriteLine(order[0] + " | " + numberA + operation + numberB);
            order.RemoveAt(0);

            //Console.WriteLine(order[0]);
            Console.WriteLine("Result = " + equation);
        }
    }
}
