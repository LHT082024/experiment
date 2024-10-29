﻿using experiment.Klasser;

namespace experiment;

class Program
{
    static void Main(string[] args)
    {
        //implementing classes into main
        View view = new View();
        Model model = new Model();
        Controller controller = new Controller(model, view);

        Console.WriteLine(view.GetMessage1());
        controller.giveName();

    }
}
