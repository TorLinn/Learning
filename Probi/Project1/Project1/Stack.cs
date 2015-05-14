//  продемонстрировать применение класса хранящего символы в стеке

using System;

//  класс для хранения символов в стеке

class Stack { 
    //  эти члены класса являются закрытими
    char[] stck;        //  массив, содержащий стек
    int tos;            //  индекс вершины стека

    //конструктор. построить пустой класс Stack для реализации стека заданного размера
    public Stack (int size) {
        stck = new char [size];
        tos = 0;
    }

    //  поместить символы в стек
    public void Push(char ch) {
        if (tos == stck.Length)
        {
            Console.WriteLine(" - Стек заполнен.");
            return;
        }

        stck[tos] = ch;
        tos++;
    }

    //  извлечь символ из стека
    public char Pop() {
        if (tos == 0)
        {
            Console.WriteLine(" - Стек пуст");
            return (char) 0;
        }

        tos--;
        return stck[tos];
    }

    //  возвратить значение true если стек заполнен
    public bool IsFull() {
        return tos == stck.Length;
    }

    //  возвратить значение true если стек пуст
    public bool IsEmpty() {
        return tos == 0;
    }

    //  возвратить общую емкость стека
    public int Capacity() {
        return stck.Length;
    }

    //  возвратить количество элементво, находящихся в данный момент в стеке
    public int GetNum() {
        return tos;
    }
}

//  продемонстрировать применение класса хранящего символы в стеке

class StackDemo {
    static public void St() {
        Stack stk1 = new Stack(10);
        Stack stk2 = new Stack(10);
        Stack stk3 = new Stack(10);
        char ch;
        int i;

        //  поместить ряд символов в стек stk1
        Console.WriteLine("Поместить символы A-J в stk1.");
        for (i = 0; !stk1.IsFull(); i++)
            stk1.Push((char) ('A' + i));   
        if (stk1.IsFull())
            Console.WriteLine("Стек stk1 заполнен.");

        //  вывести содержимое стека stk1
        Console.Write("Содержимое стека stk1 : ");
        while (!stk1.IsEmpty())
        {
            ch = stk1.Pop();
            Console.Write(ch);
        }
        Console.WriteLine();
        if (stk1.IsEmpty())
            Console.WriteLine("Стек stk1 пуст. \n");

        //  поместить дополнительные символы в стек stk1
        Console.WriteLine("Вновь поместим символы A-J в стек stk1.");
        for (i = 0; !stk1.IsFull(); i++)
            stk1.Push((char) ('A' + i));
        //  а теперь извлечь элементы из стека stk1 и поместить их в стек stk2.
        //  в итоге элементы сохраняются в stk2 в обратном порядке.
        Console.WriteLine("А теперь извлечь элементы из стека stk1 и поместить их в стек stk2");
        while (!stk1.IsEmpty())
        {
            ch = stk1.Pop();
            stk2.Push(ch);
        }
        Console.Write("Содержимое стека stk2 : ");
        while (!stk2.IsEmpty())
        {
            ch = stk2.Pop();
            Console.Write(ch);
        }
        Console.WriteLine("\n");

        //  поместить 5 символов в стек
        Console.WriteLine("Поместить 5 символов в стек stk3.");
        for (i = 0; i < 5; i++)
            stk3.Push((char) ('A' + i));
        Console.WriteLine("Емкость стека stk3 : " + stk3.Capacity());
        Console.WriteLine("Количество елементов в стеке stk3 : " + stk3.GetNum());
    }
}