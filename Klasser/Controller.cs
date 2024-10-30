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
            switch (newName)
            {
                case "Bax":
                    Console.WriteLine("You are Bax THE MOST POWERFUL WIZARD EVER");
                    ControllerModel.Name = "Bax";
                    // ControllerModel.BloodStatus = "Pureblood";
                    // ControllerModel.Speciality = "Charms";
                    // ControllerModel.Weakness = "Communication";
                    // ControllerModel.PowerLevel = 10;
                    // ControllerModel.House = "Gryffindor";
                    // Console.WriteLine($"Your name: {ControllerModel.Name}\n Your bloodstatus: {ControllerModel.BloodStatus}\n You excel at: {ControllerModel.Speciality}\n You are terrible at {ControllerModel.Weakness}\n Your powerlevel is {ControllerModel.PowerLevel}\n Your house is {ControllerModel.House}");
                    // string completedCharacter = $"Name: {ControllerModel.Name}\nBloodstatus: {ControllerModel.BloodStatus}\nbest at: {ControllerModel.Speciality}\nWorst at: {ControllerModel.Weakness}\nPowerlever: {ControllerModel.House}";
                    // string filePath = $"Character{ControllerModel.Name}.txt";
                    // File.WriteAllText(filePath, completedCharacter);
                    break;

                default:
                    Console.WriteLine($"Your name is {ControllerModel.Name}");
                    break;
            }
        }

        //the BloodStatus method does the same thing that GivenName does with the Bloodstatus varible from model. It also adds a while loop to make sure
        //that the user actually inputs one of the correct bloodstatuses #pureblood for the winnnnnnnn
        public void BloodStatus()
        {
            if (ControllerModel.Name == "Bax")
            {
                ControllerModel.BloodStatus = "Pureblood";
            }
            else
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


        }


        //Speciality method has a boolean set to false. When the user have typed something into the console the breakflag bool is set to true. 
        //it then loops through the switch statment seeing if user input matches any of the cases. If user input dosent match any of the cases
        //it uses the default cause making the bool false again and asking the user to try again and type something matching the other cases
        public void Speciality()
        {
            if (ControllerModel.Name == "Bax")
            {
                ControllerModel.Speciality = "Charms";
            }
            else
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
                            break;

                        case "transfiguration":
                            Console.WriteLine("Booooring\n");
                            break;

                        case "healing":
                            Console.WriteLine("Could you be more boooooooooooooooring you know you never have to heal if you dont get hit right?\n");
                            break;

                        case "jinxes":
                            Console.WriteLine("that works :)\n");
                            break;

                        case "hexes":
                            Console.WriteLine("yes offence is the best defence\n");
                            break;

                        case "counter-Spells":
                            Console.WriteLine("I dont think those are lethal :()");
                            break;

                        default:
                            Console.WriteLine(@"Type out an actual subject you muggle the subjects are
                Charms, Curses, Transfiguration, Healing, Jinxes, Hexes, Counter-spells");
                            breakFlag = false;
                            break;

                    }

                }

            }



        }

        //same method as Specailty just the names changed
        public void Weakness()
        {
            if (ControllerModel.Name == "Bax")
            {
                ControllerModel.Weakness = "Going to bed at a reasonble time";
            }
            else
            {
                bool breakFlag = false;

                while (!breakFlag)
                {
                    string? weakness = Console.ReadLine().ToLower();
                    ControllerModel.Weakness = weakness;

                    breakFlag = true;

                    switch (weakness)
                    {
                        case "charms":
                            Console.WriteLine("Pretty sure you need that for combat\n");
                            break;

                        case "curses":
                            Console.WriteLine("ARE YOU INSANE YOU NEED THAT TO FIGHT!\n");
                            break;

                        case "transfiguration":
                            Console.WriteLine("I once saw somene transfigure a wizard into a explodiong barrel but you dont need it\n");
                            break;

                        case "healing":
                            Console.WriteLine("You dont need to heal if everyone around you dies first\n");
                            break;

                        case "jinxes":
                            Console.WriteLine("pretty sure some of thsoe are lethal\n");
                            break;

                        case "hexes":
                            Console.WriteLine("be better\n");
                            break;

                        case "counter-Spells":
                            Console.WriteLine("the best defence is offence anyway why counter when you can attack)");
                            break;

                        default:
                            Console.WriteLine(@"Type out an actual subject you muggle the subjects are
                Charms, Curses, Transfiguration, Healing, Jinxes, Hexes, Counter-spells");
                            breakFlag = false;
                            break;

                    }
                }

            }

        }


        //The powerlevel method. The Powerlevel variable in model is set to int. So I have to use parsing to convert user input to int. 
        //The if statment checks if the user types a valid number (between 1-7) if the user did so the Powerlevel variable from model is assigned the value of powerlevel and we continue. 
        //if the user dosent type a valid number we go to an else statment that has a while that tells the user to type a proper number and will keep asking until the user does so
        public void PowerLevel()
        {
            if (ControllerModel.Name == "Bax")
            {
                ControllerModel.PowerLevel = 10;
            }
            else
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



        }


        //Same deal as the two other switchcases in the controller
        public void Houses()
        {
            if (ControllerModel.Name == "Bax")
            {
                ControllerModel.House = "Gryffindor";
            }
            else
            {
                bool breakFlag = false;

                while (!breakFlag)
                {
                    string? houses = Console.ReadLine().ToLower();
                    ControllerModel.House = houses;

                    breakFlag = true;

                    switch (houses)
                    {
                        case "slytherin":
                            Console.WriteLine("The best house parseltongue is bae <3");
                            break;

                        case "gryffindor":
                            Console.WriteLine("ewww you basic jock please stay away from me");
                            break;

                        case "hufflepuff":
                            Console.WriteLine("thats cute");
                            break;

                        case "ravenclaw":
                            Console.WriteLine("ha nerd");
                            break;

                        default:
                            Console.WriteLine("whatever you put is not one of the great houses of hogwarts.\n try again and remember there is Slytherin, Gryffindor, Hufflepuff and Ravenclaw");
                            breakFlag = false;
                            break;

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
            string completedCharacter = $"Name: {ControllerModel.Name}\nBloodstatus: {ControllerModel.BloodStatus}\nbest at: {ControllerModel.Speciality}\nWorst at: {ControllerModel.Weakness}\nPowerlever: {ControllerModel.House}";
            string filePath = $"Character{ControllerModel.Name}.txt";
            //  _{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            File.WriteAllText(filePath, completedCharacter);
        }
    }
}