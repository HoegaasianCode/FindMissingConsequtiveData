internal class Program
{
    private static void Main(string[] args)
    {
        int nonConsequtiveValue = null;
        int[] intArrTest = { 9, 2, 4, 5, 6, 7, 1, 8 };
        IsValidConsequtiveNumber(intArrTest, nonConsequtiveValue);
        // string path = @"C:\Users\had00bin\Desktop\IdValues.txt";
        // int[] intArr = GetIntArrFromTextFile(path);
        // IsValidConsequtiveNumber(intArr, nonConsequtiveValue);
    }
    void IsValidConsequtiveNumber(int[] intArr, int nonConsequtiveValue)
    {
        Array.Sort(intArr);
        int lastInt = intArr[0];
        for (int i = 0; i < intArr.Length; i++)
        {
            if (i == 0) // this case might be avoided by using ++i instead of i++
            {
                continue;
            }
            int _int = intArr[i];
            if (_int != lastInt + 1)
            {
                nonConsequtiveValue = (_int - 1);
            }
            lastInt = _int;
        }
        WriteResultsToConsole(nonConsequtiveValue);
    }
    void WriteResultsToConsole(int nonConsequtiveValue)
    {
        if (nonConsequtiveValue == null)
        {
            Console.Write("OK - All values are ordered by increments of 1");
            return;
        }
        string str = nonConsequtiveValue.ToString();
        Console.WriteLine("Missing case at: " + str);
    }
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
