//  продемонстрировать применение условного оператора if

using System;

class Primer5 
{
    static public void Prim5() 
    {
        int a, b, c;

        a = 2;
        b = 3;

        if (a < b) Console.WriteLine("a меньше b");

        //  не подлежит выводу
        if (a == b) Console.WriteLine("этого никто не увидит");

        Console.WriteLine();
        c = a - b;  //  c содержит -1
        Console.WriteLine("c содержит -1");
        if (c >= 0) Console.WriteLine("Значение с неотрицательно");
        if (c < 0) Console.WriteLine("Значение с отрицательно");
        
        Console.WriteLine();
        c = b - 1;  //  теперь с содержит 1
        Console.WriteLine("c содержит 1");
        if (c >= 0) Console.WriteLine("Значение с неотрицательно");
        if (c < 0) Console.WriteLine("Значение с отрицательно");
        
    }
}