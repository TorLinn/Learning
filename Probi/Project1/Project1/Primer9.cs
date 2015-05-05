//  применение побитового оператора И, для преобразования числа в четное

using System;

class Primer9 {
    static public void Prim9() {
        ushort num;
        ushort i;

        for (i = 1; i <= 10; i++)
        {
            num = i;

            Console.WriteLine("num = " + num);

            num = (ushort) (num & 0xfffe);

            Console.WriteLine("num после сброса младшего разряда = " + num + "\n");
        }
    }
}