/*LeetCode obj =new LeetCode();
int[][] grid1 = {
      new int[] {1, 3, 5},
      new int[] {2, 4, 6},
      new int[] {3, 7, 9}
  };

int[][]  grid = {new int[] {2,4,3,5},
  new int[] {5,4,9,3},
  new int[] {3,4,2,11},
  new int[] {10,9,13,15}
  };

  Console.WriteLine("Max Moves (Test Case 1): " + obj.MaxMoves(grid)); 

*/


using System.Numerics;
using System.Runtime.ExceptionServices;

// MinDistanceRobot b=new MinDistanceRobot();
// List<int> lst= new List<int>();
// lst.Add(0);
// lst.Add(4);
// lst.Add(6);

//  int[][] factory1 = new int[][]
//         {
//             new int[] { 2, 2 },
//             new int[] { 6, 2 }
//         };
// long result = b.MinimumTotalDistance(lst,factory1);

// Console.WriteLine("The result is " + result);

// SplitarrayLargestSum obj=new SplitarrayLargestSum();
// int[] nums = {7,2,5,10,8};
// int largestSum = obj.SplitArray(nums,2);

// Console.WriteLine("Largest Sum value is "+ largestSum);

// RotateStringClass obj = new RotateStringClass();
// string  s = "abcde", goal = "cdeab";
// obj.RotateString(s,s);

var lstNumbers = new List<int>() { 8,7,9,1,2,2,4,5,6,6};
var lstEmpty = new List<int>(){};

var distinctNum = lstNumbers.Distinct();
var filterEven = lstNumbers.Where(x => x % 2 == 0);
var filterOdd  = lstNumbers.Where(x => x % 2 != 0);

var numAsc =  lstNumbers.OrderBy(x => x);
var numDesc = lstNumbers.OrderByDescending(x => x);

var first = lstNumbers.FirstOrDefault();
var firstEmpty = lstEmpty.FirstOrDefault();

var last = lstNumbers.LastOrDefault();
var lastEmpty = lstEmpty.LastOrDefault();

foreach(var a in distinctNum){
Console.WriteLine("Numbers are "+ a);
}

foreach(var a in filterEven){
  Console.WriteLine("Even numbers are " + a);
}

foreach(var a in filterOdd){
  Console.WriteLine("Odd numbers are " + a);
}

foreach(var a in numAsc){
  Console.WriteLine("Asc numbers are " + a);
}

foreach(var a in numDesc){
  Console.WriteLine("Desc numbers are " + a);
}


Console.WriteLine("First " + first);
Console.WriteLine("First Empty " + firstEmpty);

Console.WriteLine("Last " + last);
Console.WriteLine("Last Empty " + lastEmpty);


var checkEven = lstNumbers.Any(x => x % 2 == 0);

Console.WriteLine("CHeck Eveny with Any " + checkEven);