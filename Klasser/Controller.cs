using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace experiment.Klasser
{
    public class Controller
    {
        Model ControllerModel;
        View ControllerView;
        public Controller(Model model, View view)
        {
            ControllerModel = model;
            ControllerView = view;
        }

        public void giveName()
        {
            string? newName = Console.ReadLine();
            Console.WriteLine($"Your name is {newName}");

        }



    }
}