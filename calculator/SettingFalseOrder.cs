namespace calculator
{
    internal class SettingFalseOrder
    {
        static char[] symMath = { '+', '-', '*', '/' };

        public static void SetList(List<string> falseOrder, string MathOperation)
        {
            char? step = null;

            for (int i = 0; i < MathOperation.Length; i++)
            {
                if (symMath.Contains(MathOperation[i]))
                {
                    if (MathOperation[i] == '+' || MathOperation[i] == '-') { step = '1'; }
                    else if (MathOperation[i] == '*' || MathOperation[i] == '/') { step = '2'; }
                    falseOrder.Add(Convert.ToString(step) + Convert.ToString(MathOperation[i]) + Convert.ToString(i));
                }
            }
        }
    }
}