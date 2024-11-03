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

RotateStringClass obj = new RotateStringClass();
string  s = "abcde", goal = "cdeab";
obj.RotateString(s,s);
