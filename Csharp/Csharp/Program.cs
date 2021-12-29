// See https://aka.ms/new-console-template for more information
using Csharp;
bool flag = true;
while (flag)
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
            Console.WriteLine("Select:\n1)Single Ineritance\n2)Hirarchical Inheritance\n3)Multilevel Inheritance");
            int op1 = Convert.ToInt16(Console.ReadLine());
            switch (op1)
            {
                case 1:
                    Add output = new Add();
                    output.Adition(3, 4);
                    output.Adddata();
                    break;
                case 2:
                    Squre s1 = new Squre();
                    s1.CalculateArea();
                    s1.CalculatePerimeter(s1.lenght, s1.sides);

                    Rectangle r1 = new Rectangle();
                    r1.CalculateArea();
                    r1.CalculatePerimeter(r1.lenght, r1.sides);
                    break;
                case 3:
                    canera c1 = new canera();
                    Console.WriteLine("Enter Amount you want to invest");
                    int am = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("For how many years you want to invest");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your amount according to canera bank policies after " + year + " years will be " + c1.CaluclateBalnce_canera(am, year));
                    Console.WriteLine("Your amount according to RBI bank policies after " + year + " years will be " + c1.CalculateBalnce_RBI(am, year));
                    Console.WriteLine("Your amount according to SBI bank policies after " + year + " years will be " + c1.CalculateBalnce_SBI(am, year));
                    break;
            }
            break;
        default:
            flag = !flag;
            break;
    }
     
}

