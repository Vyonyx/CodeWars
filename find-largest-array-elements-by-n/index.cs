using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static List<int> Largest(int n, List<int> xs)
  {
    xs.Sort();
    return xs.Skip(xs.Count - n).ToList();
  }
}
