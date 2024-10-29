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

        //the first method GivenName makes the string newName and gives it the value of the userinput then it assaigns the Name varible 
        //and assign it the value of the newName variable
        public void GiveName()
        {
            string? newName = Console.ReadLine();
            ControllerModel.Name = newName;

        }

        //the BloodStatus method does the same thing that GivenName does with the Bloodstatus varible from model. It also adds a while loop to make sure
        //that the user actually inputs one of the correct bloodstatuses #pureblood for the winnnnnnnn
        public void BloodStatus()
        {

            string? bloodStatus = Console.ReadLine();
            ControllerModel.BloodStatus = bloodStatus;
 
            while(bloodStatus != "Pureblood" | bloodStatus != "Halfblood" | bloodStatus != "Muglleborn")
            {
                Console.WriteLine("invalid input please write Pureblood, Halfblood, Muggleborn. Remember it is case sensetive");

                bloodStatus = Console.ReadLine();

                if(bloodStatus == "Pureblood" | bloodStatus == "Halfblood" | bloodStatus == "Muglleborn")
                break;
            }

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
            ControllerModel.Speciality = speciality;

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

                case "Healing": case "healing-magic":
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

        public void Weakness()
        {
            string? weakness = Console.ReadLine();
            ControllerModel.Weakness = weakness;

            switch (weakness)
            {
                case "Charms":
                    Console.WriteLine("Pretty sure you need that for combat\n");
                    break;

                case "Curses":
                    Console.WriteLine("ARE YOU INSANE YOU NEED THAT TO FIGHT!\n");
                    break;

                case "Transfiguration":
                    Console.WriteLine("I once saw somene transfigure a wizard into a explodiong barrel but you dont need it\n");
                    break;

                case "healing-magic":
                    Console.WriteLine("You dont need to heal if everyone around you dies first\n");
                    break;

                case "Jinxes":
                    Console.WriteLine("pretty sure some of thsoe are lethal\n");
                    break;

                case "Hexes":
                    Console.WriteLine("be better\n");
                    break;

                case "Counter-Spells":
                    Console.WriteLine("the best defence is offence anyway why counter when you can attack)");
                    break;
                    //  case weakness !=
            }
        }

        public void PowerLevel()
        {
            if (int.TryParse(Console.ReadLine(), out int powerLevel))
            {
                ControllerModel.PowerLevel = powerLevel;
            }

        }

        public void Houses()
        {
            string? houses = Console.ReadLine();
            ControllerModel.House = houses;

            switch (houses)
            {
                case "Slytherin":
                    Console.WriteLine("The best house parseltongue is bae <3");
                    break;

                case "Gryffindor":
                    Console.WriteLine("ewww you basic jock please stay away from me");
                    break;

                case "Hufflepuff":
                    Console.WriteLine("thats cute");
                    break;

                case "Ravenclaw":
                    Console.WriteLine("ha nerd");
                    break;
            }
        }

        public void FinalList()
        {
            // return $"Your name: {GiveName}\n Your bloodstatus: {BloodStatus}\n You excel at:{Speciality}\n You are terrible at{Weakness}\n Your powerlevel is{PowerLevel}\n Your house is{Houses}";
            Console.WriteLine($"Your name: {ControllerModel.Name}\n Your bloodstatus: {ControllerModel.BloodStatus}\n You excel at: {ControllerModel.Speciality}\n You are terrible at {ControllerModel.Weakness}\n Your powerlevel is {ControllerModel.PowerLevel}\n Your house is {ControllerModel.House}");
        }

      public void Filegenerating() 
      {
        string completedCharacter = $"Name: {ControllerModel.Name}\nBloodstatus: {ControllerModel.BloodStatus}\nbest at: {ControllerModel.Speciality}\nWorst at: {ControllerModel.Weakness}\nPowerlever: {ControllerModel.House}";
         string filePath = $"Character{ControllerModel.Name}.txt";
        //  _{DateTime.Now:yyyyMMdd_HHmmss}.txt";
           File.WriteAllText(filePath, completedCharacter);
      }
    }
}