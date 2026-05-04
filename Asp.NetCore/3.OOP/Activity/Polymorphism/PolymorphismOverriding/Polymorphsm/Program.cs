using Polymorphsm;

internal class Program
{
    private static void Main(string[] args)
    {

        //CompileTimePolymorphism cp=new CompileTimePolymorphism();

        //cp.display();
        //cp.display("welcome");
        //cp.display("hi", 2);


        BaseClass obj=new DerivedClass();
        obj.display();  
    }
}