public class RotateStringClass{
      public bool RotateString(string s, string goal) {          
        string mix = s + s;
        Console.WriteLine("Mixed String "+mix + " Length of goal "+ goal.Length  + " Length of string s " +s.Length);
        return (mix.Contains(goal) && goal.Length >= s.Length);
        
    }
}