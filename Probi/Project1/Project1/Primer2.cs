// Эта программа демонстрирует применение переменных.

using System;

class Primer2
{
    static public void Prim2 () 
    {
        int x; // объявление переменной
        int y; // еще одна переменная

        x = 100; // присвоили переменной значение 100

        Console.WriteLine("x = " + x);

        y = x / 2;

        Console.Write("y = ");
        Console.WriteLine(y);
        Console.ReadLine();
    }
}