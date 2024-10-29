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

        public void GiveName()
        {
            string? newName = Console.ReadLine();
            Console.WriteLine($"Your name is {newName}");

        }

        public void BloodStatus()
        {

            string? bloodStatus = Console.ReadLine();

            if (bloodStatus == "Pureblood")
            {
                Console.WriteLine("A proper Wizard then not one of those filthy mudbloods");
            }
            else if (bloodStatus == "Halfblood")
            {
                Console.WriteLine("Like, thats okay.. like you are a wizard, but like, punch your mother or something will you?");

            }
            else if (bloodStatus == "Muggleborn")
            {
                Console.WriteLine("Okay.. okay... like... sure...");
            }

        }



    }
}