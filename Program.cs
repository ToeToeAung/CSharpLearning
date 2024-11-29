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

// var lstNumbers = new List<int>() { 8,7,9,1,2,2,4,5,6,6};
// var lstEmpty = new List<int>(){};
// var lstNotEvens =new List<int>() {3,5,7,,9};

// var distinctNum = lstNumbers.Distinct();
// var filterEven = lstNumbers.Where(x => x % 2 == 0);
// var filterOdd  = lstNumbers.Where(x => x % 2 != 0);

// var numAsc =  lstNumbers.OrderBy(x => x);
// var numDesc = lstNumbers.OrderByDescending(x => x);

// var first = lstNumbers.FirstOrDefault();
// var firstEmpty = lstEmpty.FirstOrDefault();

// var last = lstNumbers.LastOrDefault();
// var lastEmpty = lstEmpty.LastOrDefault();

// foreach(var a in distinctNum){
// Console.WriteLine("Numbers are "+ a);
// }

// foreach(var a in filterEven){
//   Console.WriteLine("Even numbers are " + a);
// }

// foreach(var a in filterOdd){
//   Console.WriteLine("Odd numbers are " + a);
// }

// foreach(var a in numAsc){
//   Console.WriteLine("Asc numbers are " + a);
// }

// foreach(var a in numDesc){
//   Console.WriteLine("Desc numbers are " + a);
// }


// Console.WriteLine("First " + first);
// Console.WriteLine("First Empty " + firstEmpty);

// Console.WriteLine("Last " + last);
// Console.WriteLine("Last Empty " + lastEmpty);


// var checkEven = lstNumbers.Any(x => x % 2 == 0);
// var checkEven1 = lstNotEvens.Any(x => x % 2 == 0);
// Console.WriteLine("CHeck Eveny with Any 1" + checkEven);

// Console.WriteLine("CHeck Eveny with Any  2" + checkEven1);


// var checkAll= lstNumbers.All(x => x % 2 != 0);
// var checkAll1 = lstNotEvens.All(x => x % 2 != 0);

// Console.WriteLine("CHeck Eveny with All 1" + checkAll);

// Console.WriteLine("CHeck Eveny with All  2" + checkAll1);


// StringCompression obj=new StringCompression();
// string word = "abcde";
// string result =obj.CompressedString(word);

// Console.WriteLine("Result "+ result);

// SplitArrayintoConsecutiveSubsequences obj =new SplitArrayintoConsecutiveSubsequences();
// int[] nums = {1,2,3,3,4,4,5,5};
// bool flag=false;
// flag=obj.IsPossible(nums);

// Console.WriteLine("Is possible to split arrays "+ flag);

// MakeBinaryStringBeautiful obj =new MakeBinaryStringBeautiful();
// int result =0;
// string  s = "1001";
// result = obj.MinChanges(s);

// Console.WriteLine("Result of Min Changes is " + result);


//MaxNumXOr obj =new MaxNumXOr();


// int[] nums= {0,1,1,3};
// int[] result =new int[nums.Length];
// result = obj.GetMaximumXor(nums,2);
// foreach(var x in result){
// Console.WriteLine("Result of Min Changes is " + x);
// }


// LargestCombinationClass obj1 =new LargestCombinationClass();
// int[] candidates = {6,17,71,62,12,24,14};
// int result1=obj1.LargestCombination(candidates);

// Console.WriteLine("Largest Combination " + result1);

// ShortestSubarrayWithORatLeastKII obj1 =new ShortestSubarrayWithORatLeastKII();
// int[] nums = {1,2,3};int k = 2;
// int minNo=obj1.MinimumSubarrayLength(nums,2);
// Console.WriteLine("Minimum Sub Array Length " + minNo);

// PrimeSubtractionOperation obj1 =new PrimeSubtractionOperation();
// int[] nums = {4,9,6,10};
// bool flag =obj1.PrimeSubOperation(nums);

//foreach(int num in nums){
//onsole.WriteLine("Result  "+ flag);
//}

// CounttheNumberofFairPairs obj =new CounttheNumberofFairPairs();
// int[] nums = {0,1,7,4,4,5}, lower = 3, upper = 6;
// long result =obj.CountFairPairs(nums,lower,upper);

// Console.WriteLine("The result is "+ result);

// MinimizedMaximumClass obj=new MinimizedMaximumClass();

//  int n = 6;
//  int[] quantities = {11,6};
// int result = obj.MinimizedMaximum(6,quantities);

// Console.WriteLine("The result is "+ result);

// ShortestSubarrayToBeRemovedMakeArraySorted obj =new ShortestSubarrayToBeRemovedMakeArraySorted();
// int result =0;
// int[] arr= {1,2,3,10,4,2,3,5};
// result=obj.FindLengthOfShortestSubarray(arr);

// Console.WriteLine("The result is " + result);
// ShortestSubArrayWithSumAtLeastK obj=new ShortestSubArrayWithSumAtLeastK();
// int [] nums = {1,2}; int k = 4;
// int result= obj.ShortestSubarray(nums,k);

// Console.WriteLine("Result " + result);


// MaximumMatrixSum obj=new MaximumMatrixSum();
//  int[][] matrix = {
//             new int[] { 1, 2, 3 },  
//             new int[] { 4, 5, 6 },  
//             new int[] { 7, 8, 9 }   
//         };
// long result =obj.MaxMatrixSum(matrix);

// SlidingPuzzleClass obj=new SlidingPuzzleClass();
// int[][] board = new int[2][];
// board[0] = new int[] { 1, 2, 3 };
// board[1] = new int[] { 4, 0, 5 };
// int result =obj.SlidingPuzzle(board);

// Console.WriteLine("Result " +result);

// int[][] grid = new int[][] 
// {
//     new int[] { 0,1,1 },
//     new int[] { 1,1,0 },
//     new int[] { 1,1,0}
// };
// MinimumObstacleRemovaltoReachCorner obj=new MinimumObstacleRemovaltoReachCorner();
// int result =obj.MinimumObstacles(grid);


//   Console.WriteLine("Result is " +result);



int[][] grid =new int[][]  {
    new int[] { 0, 1, 3, 2 },
    new int[] { 5, 1, 2, 5 },
    new int[] { 4, 3, 8, 6 }
};


MinimumTimetoVisitaCellInaGrid obj=new MinimumTimetoVisitaCellInaGrid();
int result=obj.MinimumTime(grid);

Console.WriteLine("Result is " + result);