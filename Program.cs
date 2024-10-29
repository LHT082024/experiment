using experiment.Klasser;

namespace experiment;

class Program
{
    static void Main(string[] args)
    {
        //implementing classes into main
        Controller controller = new Controller();
        View view = new View();

        Console.WriteLine(view.GetMessage1());

    }
}
