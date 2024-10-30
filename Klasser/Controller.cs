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
            string? newName = Console.ReadLine().ToLower();
            ControllerModel.Name = newName;
            switch (newName)
            {
                case "bax":
                    Console.WriteLine("\nYou are Bax THE MOST POWERFUL WIZARD EVER");
                    ControllerModel.Name = "bax";
                    ControllerModel.BloodStatus = "Pureblood";
                    ControllerModel.Speciality = "Curses";
                    ControllerModel.Weakness = "forgetting to sleep";
                    ControllerModel.PowerLevel = 10;
                    ControllerModel.House = "Gryffindor";
                    Console.WriteLine($"Your name: {ControllerModel.Name}\n Your bloodstatus: {ControllerModel.BloodStatus}\n You excel at: {ControllerModel.Speciality}\n You are terrible at {ControllerModel.Weakness}\n Your powerlevel is {ControllerModel.PowerLevel}\n Your house is {ControllerModel.House}");
                    Console.WriteLine("press any key to contrinue");
                    Console.ReadKey();
                    break;

                case "sigrid":
                    ControllerModel.BloodStatus = "Pureblood";
                    ControllerModel.Speciality = "Charms";
                    ControllerModel.Weakness = "Chocolate";
                    ControllerModel.PowerLevel = 10;
                    ControllerModel.House = "Hufflepuff";
                    Console.WriteLine($"Your name: {ControllerModel.Name}\n Your bloodstatus: {ControllerModel.BloodStatus}\n You excel at: {ControllerModel.Speciality}\n You are terrible at {ControllerModel.Weakness}\n Your powerlevel is {ControllerModel.PowerLevel}\n Your house is {ControllerModel.House}");
                    Console.WriteLine("press any key to contrinue");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine($"\nYour name is {ControllerModel.Name}");
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    break;
            }
        }

        //the BloodStatus method does the same thing that GivenName does with the Bloodstatus varible from model. It also adds a while loop to make sure
        //that the user actually inputs one of the correct bloodstatuses #pureblood for the winnnnnnnn
        public void BloodStatus()
        {

            string? bloodStatus = Console.ReadLine().ToLower();
            ControllerModel.BloodStatus = bloodStatus;

            while (bloodStatus != "pureblood" && bloodStatus != "halfblood" && bloodStatus != "muggleborn")
            {
                Console.WriteLine("invalid input please write Pureblood, Halfblood, Muggleborn.");

                bloodStatus = Console.ReadLine().ToLower();

                if (bloodStatus == "pureblood" | bloodStatus == "halfblood" | bloodStatus == "muggleborn")
                    break;
            }

            if (bloodStatus == "pureblood")
            {
                Console.WriteLine("A proper Wizard then not one of those filthy mudbloods\n");
                Console.WriteLine("press any key to continue");
                Console.ReadKey();
            }
            else if (bloodStatus == "halfblood")
            {
                Console.WriteLine("Like, thats okay.. like you are a wizard, but like, punch your mother or something will you?\n");
                Console.WriteLine("press any key to continue");
                Console.ReadKey();

            }
            else if (bloodStatus == "muggleborn")
            {
                Console.WriteLine("Okay.. okay... like... sure...I guess you are a person..\n");
                Console.WriteLine("press any key to continue");
                Console.ReadKey();
            }

        }






        //Speciality method has a boolean set to false. When the user have typed something into the console the breakflag bool is set to true. 
        //it then loops through the switch statment seeing if user input matches any of the cases. If user input dosent match any of the cases
        //it uses the default cause making the bool false again and asking the user to try again and type something matching the other cases
        public void Speciality()
        {
            bool breakFlag = false;

            while (!breakFlag)
            {
                string? speciality = Console.ReadLine().ToLower();
                ControllerModel.Speciality = speciality;

                breakFlag = true;

                switch (speciality)
                {
                    case "charms":
                        Console.WriteLine("cool\n");
                        break;

                    case "curses":
                        Console.WriteLine("there we go a sorcerer after my own heart curse those Mud- those dark wizards\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "transfiguration":
                        Console.WriteLine("Booooring\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "healing":
                        Console.WriteLine("Could you be more boooooooooooooooring you know you never have to heal if you dont get hit right?\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "jinxes":
                        Console.WriteLine("that works :)\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "hexes":
                        Console.WriteLine("yes offence is the best defence\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "counter-Spells":
                        Console.WriteLine("I dont think those are lethal :()");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine(@"Type out an actual subject you muggle the subjects are
                Charms, Curses, Transfiguration, Healing, Jinxes, Hexes, Counter-spells");
                        breakFlag = false;
                        break;

                }

            }

        }




        //same method as Specailty just the names changed
        public void Weakness()
        {
            bool breakFlag = false;

            while (!breakFlag)
            {
                string? weakness = Console.ReadLine().ToLower();
                ControllerModel.Weakness = weakness;

                breakFlag = true;

                while (ControllerModel.Speciality == ControllerModel.Weakness)
                {
                    Console.WriteLine("mate you can't be the best and the worst at something");
                    weakness = Console.ReadLine().ToLower();
                    ControllerModel.Weakness = weakness;
                    if (ControllerModel.Speciality != ControllerModel.Weakness)
                        break;
                }
                switch (weakness)
                {

                    case "charms":
                        Console.WriteLine("Pretty sure you need that for combat\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "curses":
                        Console.WriteLine("ARE YOU INSANE YOU NEED THAT TO FIGHT!\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "transfiguration":
                        Console.WriteLine("I once saw somene transfigure a wizard into a explodiong barrel but you dont need it\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "healing":
                        Console.WriteLine("You dont need to heal if everyone around you dies first\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "jinxes":
                        Console.WriteLine("pretty sure some of thsoe are lethal\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "hexes":
                        Console.WriteLine("be better\n");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    case "counter-Spells":
                        Console.WriteLine("the best defence is offence anyway why counter when you can attack)");
                        Console.WriteLine("press any key to continue");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine(@"Type out an actual subject you muggle the subjects are
                Charms, Curses, Transfiguration, Healing, Jinxes, Hexes, Counter-spells");
                        breakFlag = false;
                        break;

                }

            }


        }




        //The powerlevel method. The Powerlevel variable in model is set to int. So I have to use parsing to convert user input to int. 
        //The if statment checks if the user types a valid number (between 1-7) if the user did so the Powerlevel variable from model is assigned the value of powerlevel and we continue. 
        //if the user dosent type a valid number we go to an else statment that has a while that tells the user to type a proper number and will keep asking until the user does so
        public void PowerLevel()
        {
            if (int.TryParse(Console.ReadLine(), out int powerLevel))
            {
                if (powerLevel >= 1 && powerLevel <= 7)
                {
                    ControllerModel.PowerLevel = powerLevel;
                }

                else
                {
                    while (powerLevel < 1 || powerLevel > 7)
                    {
                        Console.WriteLine("Invalid input please type a number between 1 and 7");
                        if (int.TryParse(Console.ReadLine(), out powerLevel) && powerLevel >= 1 && powerLevel <= 7)
                        {
                            ControllerModel.PowerLevel = powerLevel;
                            break;

                        }
                    }

                }
            }

        }




        //Same deal as the two other switchcases in the controller
        public void Houses()
        {
            bool breakFlag = false;
            bool isHouseRight = false;

            string? houses = Console.ReadLine().ToLower();
            ControllerModel.House = houses;

            while (!isHouseRight)
            {
                if (ControllerModel.BloodStatus == "muggleborn" && ControllerModel.House == "slytherin")
                {
                    Console.WriteLine("FILTHY MUDBLO-..... muggleborns can not be a slytherin");
                    houses = Console.ReadLine().ToLower();
                    ControllerModel.House = houses;
                }
                else
                {
                    isHouseRight = true;

                    while (!breakFlag)
                    {

                        breakFlag = true;

                        switch (houses)
                        {
                            case "slytherin":
                                Console.WriteLine("The best house parseltongue is bae <3");
                                Console.WriteLine("press any key to continue");
                                Console.ReadKey();
                                break;

                            case "gryffindor":
                                Console.WriteLine("ewww you basic jock please stay away from me");
                                Console.WriteLine("press any key to continue");
                                Console.ReadKey();
                                break;

                            case "hufflepuff":
                                Console.WriteLine("thats cute");
                                Console.WriteLine("press any key to continue");
                                Console.ReadKey();
                                break;

                            case "ravenclaw":
                                Console.WriteLine("ha nerd");
                                Console.WriteLine("press any key to continue");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine("whatever you put is not one of the great houses of hogwarts.\n try again and remember there is Slytherin, Gryffindor, Hufflepuff and Ravenclaw");
                                Console.WriteLine("press any key to continue");
                                Console.ReadKey();
                                breakFlag = false;
                                break;

                        }
                    }

                }
            }

        }

        //prints out a final list for the user.
        public void FinalList()
        {
            // return $"Your name: {GiveName}\n Your bloodstatus: {BloodStatus}\n You excel at:{Speciality}\n You are terrible at{Weakness}\n Your powerlevel is{PowerLevel}\n Your house is{Houses}";
            Console.WriteLine($"Your name: {ControllerModel.Name}\n Your bloodstatus: {ControllerModel.BloodStatus}\n You excel at: {ControllerModel.Speciality}\n You are terrible at {ControllerModel.Weakness}\n Your powerlevel is {ControllerModel.PowerLevel}\n Your house is {ControllerModel.House}");
        }


        //generates a text file saving the character data of the user called Character(whatever the user called their character)
        public void Filegenerating()
        {
            string completedCharacter = $"Name: {ControllerModel.Name}\nBloodstatus: {ControllerModel.BloodStatus}\nbest at: {ControllerModel.Speciality}\nWorst at: {ControllerModel.Weakness}\nPowerlevel: {ControllerModel.PowerLevel}\nYour house: {ControllerModel.House}";
            string filePath = $"Character{ControllerModel.Name}.txt";
            //  _{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            File.WriteAllText(filePath, completedCharacter);
        }
    }
}