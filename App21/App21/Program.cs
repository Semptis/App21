using App21;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq.Expressions;

Console.WriteLine("Welcome");
while (true)
{
    try
    {
        Console.WriteLine("If you want add grade to BookInFile: 1");
        Console.WriteLine("If you want add grade to BookInMemory: 2");
        Console.WriteLine("If tou want exit: Exit");
        var inputOpcion = Console.ReadLine();
        if (inputOpcion == "Exit" || inputOpcion == "exit")
        {
            break;
        }
        switch (inputOpcion)
        {
            case "1":
                {
                    Console.WriteLine("Please add title: ");
                    var inputTitle = Console.ReadLine();
                    var book = new BookInFile(inputTitle);
                    while (true)
                    {
                        Console.WriteLine("Please add grade or X: ");
                        var inputGrade = Console.ReadLine();
                        if (inputGrade == "X")
                        {
                            break;
                        }
                        book.AddGrade(inputGrade);
                    }
                    var result = book.GetStatistics();
                    Console.WriteLine($"Title: {book.Title} Min: {result.Min}, Max: {result.Max}, Avg: {result.Avg}");
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Please add title: ");
                    var inputTitle = Console.ReadLine();
                    var book2 = new BookInMemory(inputTitle);
                    while (true)
                    {
                        Console.WriteLine("Please add grade or X: ");
                        var inputGrade = Console.ReadLine();
                        if (inputGrade == "X")
                        {
                            break;
                        }
                        book2.AddGrade(inputGrade);
                    }
                    var result = book2.GetStatistics();
                    Console.WriteLine($"Title: {book2.Title} Min: {result.Min}, Max: {result.Max}, Avg: {result.Avg}");
                    break;
                }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
