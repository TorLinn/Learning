/*
 *  Эта программа демонстрирует отличия
 *  между типами данных int и double 
 */

using System;

class Primer3
{
    static public void Prim3() {
        int ivar;       //  объявлена целочисленная переменная
        double dvar;    //  объявлена переменная с плавающей точкой

        ivar = 100;     //  присвоено значение 100
        dvar = 100.0;   //  присвоено значение 100.0

        Console.WriteLine("Исходное значение ivar = " + ivar);
        Console.WriteLine("Исходное значение dvar = " + dvar);

        Console.WriteLine("Разделим значения переменных на 3");

        // разделить значения обеих переменных на 3

        ivar = ivar / 3;
        dvar = dvar / 3;

        Console.WriteLine("Значение после деления ivar = " + ivar);
        Console.WriteLine("Значение после деления dvar = " + dvar);
    }
}