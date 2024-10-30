public class UseInterfaces : IStudent,ISchool{
public static void Main(string[] args){
UseInterfaces myTest =new UseInterfaces();
myTest.Name();

IStudent student= myTest;
student.DressCode();

ISchool school = myTest;
school.DressCode();
Console.ReadLine();

}
public void Name(){
    Console.WriteLine("Student 1");
}

}

// public class MyTest{
//     public void Name(){
//         Console.WriteLine("Student Test");
//     }
// }