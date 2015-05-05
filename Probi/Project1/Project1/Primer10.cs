//  Применить побитовый оператор И для определения нечетности числа

using System;

class Primer10 {
    static public void Prim10() {
        ushort num;

        num = 146;

        if ((num & 1) == 1) Console.WriteLine("Не выводится.");

        num = 133;

        if ((num & 1) == 1) Console.WriteLine(num + " Нечетное число");
    }
}