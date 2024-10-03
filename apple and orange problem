using System;
using System.Linq;

class Solution
{
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        int applesCount = 0;
        int orangesCount = 0;

        foreach (var apple in apples) {
            int distance = a + apple;
            if (distance >= s && distance <= t) {
                applesCount++;
            }
        }
        
        foreach (var orange in oranges) {
            int distance = b + orange;
            if (distance >= s && distance <= t) {
                orangesCount++;
            }
        }

        Console.WriteLine(applesCount);
        Console.WriteLine(orangesCount);
    }

    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int s = Convert.ToInt32(firstMultipleInput[0]);
        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int a = Convert.ToInt32(secondMultipleInput[0]);
        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int m = Convert.ToInt32(thirdMultipleInput[0]);
        int n = Convert.ToInt32(thirdMultipleInput[1]);

        int[] apples = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToArray();
        int[] oranges = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToArray();

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
