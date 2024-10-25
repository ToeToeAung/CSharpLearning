public class CSharp8Feature{

    public void function1(){
        string A= null;
        string B= "Hello B";
        string C = null;
        string D = null;
        string E = A ?? C ?? D ?? B;

        Console.WriteLine (E);
        Console.ReadLine();
    }
}