// See https://aka.ms/new-console-template for more information
using Csharp;
bool flag = true;
while(flag)
{
    Console.WriteLine("Select:\n1)Encapsulation\n2)Inheritance\n");
    int op = Convert.ToInt16(Console.ReadLine());
    switch(op)
    {
        case 1:
            Encapsulation num = new Encapsulation();
            num.Numtype = "10";
            Console.WriteLine("Given Number is:" + num.Numtype);
            break;
        case 2:
            Add output = new Add();
            output.Adition();
            output.Adddata();
            break;
        default:
            flag = !flag;
            break;
    }
     
}

