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
        controller.GiveName();

        if (model.Name == "bax")
        {
            controller.BloodStatus();
            controller.Speciality();
            controller.Weakness();
            controller.PowerLevel();
            controller.Houses();

            Console.WriteLine(view.GetMessage8());

            controller.Filegenerating();


        }
        else
        {
            Console.WriteLine(view.GetMessage2());
            controller.BloodStatus();

            Console.WriteLine(view.GetMessage3());
            controller.Speciality();

            Console.WriteLine(view.GetMessage4());
            controller.Weakness();

            Console.WriteLine(view.GetMessage5());
            controller.PowerLevel();

            Console.WriteLine(view.GetMessage6());
            controller.Houses();

            controller.FinalList();

            Console.WriteLine(view.GetMessage8());

            controller.Filegenerating();



        }

    }
}
