using System.Globalization;

class Program
{
    public static void Main()
    {
        //{ 3, 0, 1 }
        //{0, 1 }
        int[] nums = {9,6,4,2,3,5,7,0,1};
        var result = FindMissingNumber(nums);
        Console.WriteLine(result);

    }

    public static int FindMissingNumber (int [] arr)
    {
        for(int i = 0; i <= arr.Length; i++)
        {
            if (!arr.Contains(i)) return i; 
        }
        return -1;
    }
}