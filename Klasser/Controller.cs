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
                Console.WriteLine("A proper Wizard then not one of those filthy mudbloods\n");
            }
            else if (bloodStatus == "Halfblood")
            {
                Console.WriteLine("Like, thats okay.. like you are a wizard, but like, punch your mother or something will you?\n");

            }
            else if (bloodStatus == "Muggleborn")
            {
                Console.WriteLine("Okay.. okay... like... sure...\n");
            }
        }

        public void Speciality()
        {
            string? speciality = Console.ReadLine();

            switch (speciality)
            {
                case "Charms":
                    Console.WriteLine("cool\n");
                    break;

                case "Curses":
                    Console.WriteLine("there we go a sorcerer after my own heart curse those Mud- those dark wizards\n");
                    break;

                case "Transfiguration":
                    Console.WriteLine("Booooring\n");
                    break;

                case "Healing":
                    Console.WriteLine("Could you be more boooooooooooooooring you know you never have to heal if you dont get hit right?\n");
                    break;

                case "Jinxes":
                    Console.WriteLine("that works :)\n");
                    break;

                case "Hexes":
                    Console.WriteLine("yes offence is the best defence\n");
                    break;

                case "Counter-Spells":
                    Console.WriteLine("I dont think those are lethal :()");
                    break;

            }
        }



    }
}