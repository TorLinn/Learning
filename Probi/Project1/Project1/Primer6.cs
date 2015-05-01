//  продемонстрировать применение оператора цикла for

using System;

class Primer6
{
    static public void Prim6()
    {
        int count;
        for (count = 0; count < 5; count ++)
        {
            Console.WriteLine("Это подсчет: " + count);
        }
        Console.WriteLine("Готово!");
    }
}