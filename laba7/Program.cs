using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Чтение содержимого файла Inlet.in
        string[] lines = File.ReadAllLines("Inlet.in");

        // Преобразование каждой строки
        string[] transformedLines = new string[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            string transformedLine = TransformLine(line);
            transformedLines[i] = transformedLine;
        }

        // Запись преобразованных строк в файл Outlet.out
        File.WriteAllLines("Outlet.out", transformedLines);
    }

    static string TransformLine(string line)
    {
        // Удаление пробелов в начале и конце строки
        line = line.Trim();

        // Замена множественных пробелов между словами на одиночные пробелы
        line = string.Join(" ", line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        return line;
    }
}
