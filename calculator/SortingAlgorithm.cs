namespace calculator
{
    internal class SortingAlgorithm
    {
        public static void Sort(List<string> toSort)
        {
            string? current = null;
            string? compare = null;

            string? leftNum = null;
            string? rightNum = null;

            for (int i = 0; i < toSort.Count; i++)
            {
                for (int j = 0; j < toSort.Count; j++)
                {
                    current = toSort[i];
                    compare = toSort[j];

                    if (int.Parse(current[0].ToString()) > int.Parse(compare[0].ToString()))
                    {
                        toSort[i] = compare;
                        toSort[j] = current;
                    }
                    else if (int.Parse(current[0].ToString()) == int.Parse(compare[0].ToString()))
                    {
                        for (int k = 2; k < current.Length; k++)
                        {
                            leftNum += current[k];
                        }
                        for (int k = 2; k < compare.Length; k++)
                        {
                            rightNum += compare[k];
                        }

                        if (int.Parse(leftNum) < int.Parse(rightNum))
                        {
                            toSort[i] = compare;
                            toSort[j] = current;
                        }
                    }
                    leftNum = "";
                    rightNum = "";
                }
            }
        }
    }
}
