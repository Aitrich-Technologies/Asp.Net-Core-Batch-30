using Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        //CompileTimePolymorphism obj = new CompileTimePolymorphism();
        //obj.Display();
        //obj.Display("Hello World!");
        //obj.Display("Hello", 42);


        //BaseClass obj=new BaseClass();
        //obj.Display();


        IShape shape;
        shape = new circle();
        shape.Draw();
        shape=new Rectangle();
        shape.Draw();
    }
}