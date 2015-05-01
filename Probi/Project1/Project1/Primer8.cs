//  Продеменстрировать различия между префиксной
//  и постфиксной формами оператора инкремента (++)

using System;

class Primer8 {
    static public void Prim8() {
        int x, y;
        int i;

        x = 1;
        y = 0;

        Console.WriteLine("Ряд чисел, полученных с помощью оператора y = y + x++;");

        for (i = 0; i < 10; i++)
        {
            y = y + x++;    //  постфиксная форма оператора ++
            Console.WriteLine(y + " ");
        }
        Console.WriteLine();

        x = 1;
        y = 0;

        Console.WriteLine("Ряд чесел, полученных с помощью оператора y = y + ++x;");

        for (i = 0; i < 10; i++)
        {
            y = y + ++x;    //  префиксная форма оператора ++
            Console.WriteLine(y + " ");
        }
        Console.WriteLine();
    }
}