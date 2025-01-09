using System;
using System.IO;

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
      Console.Clear();
      Console.WriteLine("Type your text down below. (Press ESC to exit text edition)");

      Console.WriteLine("----------/--------/--------");

      string inputedText = "";

      do {
        inputedText += Console.ReadLine();
        inputedText += Environment.NewLine;
      }
      while(Console.ReadKey().Key != ConsoleKey.Escape);

      SaveFile(inputedText);
    }

    static void SaveFile(string inputedText) {
      Console.Clear();
      Console.WriteLine("In which path would you like to save the file?");
      var savePath = Console.ReadLine();

      using (var createdFile = new StreamWriter(savePath)) {
        createdFile.Write(inputedText);
      }

      Console.WriteLine($"File successfuly saved at {savePath}");
      Console.ReadLine();
      Menu();
    }
  }
}