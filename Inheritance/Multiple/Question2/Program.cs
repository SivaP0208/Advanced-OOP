using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        // Creating objects for ShiftDezire
        ShiftDezire shift1=new ShiftDezire("ABC1001","CBA12001","Audi","A5","Petrol",4,"Black",35,315);
        ShiftDezire shift2=new ShiftDezire("FED1002","FED12002","BMW","BM3","Petrol",4,"White",29,289);

        // Creating objects for Eco
        Eco eco1=new Eco("GHI1003","IHG12003","RollsRoyce","RR1","Petrol",6,"Brown",45,376);
        Eco eco2=new Eco("JKL1003","LKJ12004","Jaguar","JG99","Petrol",5,"Red",30,265);
    
        // Printing the Details
        shift1.ShowDetails();
        shift2.ShowDetails();
        eco1.ShowDetails();
        eco2.ShowDetails();
    }
}