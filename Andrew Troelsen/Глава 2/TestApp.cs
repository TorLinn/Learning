// ѕростое приложение C#.
using System;
// Ёта строка больше не нужна:
// using System.Windows.Forms;

class TestApp
  {
    static void Main()
      {
        Console.WriteLine("Testing! 1, 2, 3");
        
        // Ёта строка тоже больше не нужна:
        // MessageBox.Show("Hello...");
        
        // »спользовать класс HelloMessage!
        HelloMessage h = new HelloMessage();
        h.Speak();
      }
  }
