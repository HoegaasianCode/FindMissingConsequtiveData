internal class Program
{
        private static void Main(string[] args)
        {
            int[] intArr = { 9, 2, 4, 5, 6, 7, 1, 8 };
            // {1, 2, 4, 5, 6, 7, 9} after Sort()
            // string path = @"C:\Users\had00bin\Desktop\IdValues.txt";
            // int[] intArr = GetIntArrFromTextFile(path);
            List<int> missingIntList = new();
            IsValidConsequtiveNumber(intArr, missingIntList);
            // MyTestFunc(GetIntArrFromTextFile(path));
        }
        void IsValidConsequtiveNumber(int[] intArr, List<int> missingIntList)
        {
            Array.Sort(intArr);
            int lastInt = intArr[0];
            for (int i = 0; i < intArr.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                int _int = intArr[i];
                if (_int != lastInt + 1)
                {
                    missingIntList.Add(_int - 1);
                }
                lastInt = _int;
            }
            WriteResultsToConsole(missingIntList.ToArray());
        }
        int[] GetIntArrFromTextFile(string path)
        {
            string[] strArr = File.ReadAllLines(path);
            List<int> intList = new();
            foreach (string str in strArr)
            {
                intList.Add(int.Parse(str));
            }
            return intList.ToArray();
        }
        void WriteResultsToConsole(int[] missingIntArr)
        {
            if (missingIntArr.Length < 1)
            {
                Console.Write("OK - All values are ordered by increments of 1");
                return;
            }
            string str = missingIntArr.Length.ToString();
            Console.WriteLine(str + " missing case(s) found:");
            foreach (int _int in missingIntArr)
            {
                Console.WriteLine(_int.ToString());
            }
        }
        void MyTestFunc(int[] intArr)
        {
            foreach (int _int in intArr)
            {
                Console.WriteLine(_int.ToString());
            }
        }
 }
/*
   --- Auxcillary functions go here ---
*/
