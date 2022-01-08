using System;

public class Program
{  
  public static string HighAndLow(string numbers)
  {
    string[] arr = numbers.Split(' ');
    int max = int.MinValue, min = int.MaxValue;

    for (int i = 0; i < arr.Length; i++)
    {
      int result = Int32.Parse(arr[i]);
      if (max < result) max = result;
      if (min > result) min = result;
    }

    return $"{max} {min}";
  }
}