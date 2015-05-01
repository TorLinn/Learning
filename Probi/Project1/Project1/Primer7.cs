// форматирование вывлдимого текста

using System;

class Primer7 {
    static public void Prim7 () {
        decimal price;
        decimal discount;
        decimal discounted_price;

        //  рассчитать цену со скидкой

        price = 19.95m;
        discount = 0.15m;   //  норма скидки составляет 15%

        discounted_price = price - (price * discount);

        Console.WriteLine("Цена со скидкой: {0:C}", discounted_price);
        Console.WriteLine("3 в формате хх,хх - {0:00.00}", 3);
        Console.WriteLine("Деление 10/3 дает: {0:#.##}", 10.0 / 3.0);
        Console.WriteLine("{0:###,###.##}", 123456.56);
    }
}