using System;

namespace csharpTextEditor {
  class Program {
    static void Main(string[] args) {
      Menu();
    }

    static void Menu() {
      Console.Clear();
      Console.WriteLine("What would you like to do?");
      Console.WriteLine("");
      Console.WriteLine("1 -> Open file");
      Console.WriteLine("2 -> Create new file");
      Console.WriteLine("3 -> Exit app");

      Console.WriteLine("----------/--------/--------");

      Console.WriteLine("Select one of the options above: ");

      short selectedOption = short.Parse(Console.ReadLine());

      switch (selectedOption) {
        case 1:  OpenFile(); break;
        case 2: CreateFile(); break;
        case 3: Environment.Exit(0); break;
      }
    }

    static void OpenFile() {

    }

    static void CreateFile() {

    }
  }
}