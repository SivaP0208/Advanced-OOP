using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        MultipleMethods methodOverloading=new MultipleMethods();

        methodOverloading.Method(2);
        methodOverloading.Method(2,3);
        methodOverloading.Method("Hi","Good","Morning !");
        methodOverloading.Method(2001,"Birth Year");
        methodOverloading.Method(10,10,'=');
    }
}