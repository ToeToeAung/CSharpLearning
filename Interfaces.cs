public interface IStudent{
    void DressCode(){
      Console.WriteLine("While and Blue");  
    }
    void Name();
}

public interface ISchool: IStudent{
    void DressCode(){
      Console.WriteLine("While and Orange Overwritten");  
    }
}