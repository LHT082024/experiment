using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace experiment.Klasser
{
    public class View
    {
        Controller viewController;
        //questions asked by the console
        string Message1 = @"Welcome to Hogwarts here you will either learn magic or die
the possiblites are endless :) now lets start with your name";
        string Message2 = "\nand what is your bloodstatus? pick one of the following\nPureblood, Halfblood, Muggleborn\n";
        string Message3 = "\nWhat magic do you excel at pick one of the following\nCharms, Curses, Transfiguration, healing-magic, Jinxes, Hexes, Counter-Spells\n";
        string Message4 = "\nNow remember no one is perfcet tell me what are you terrible at\nCharms, Curses, Transfiguration, healing-magic, Jinxes, Hexes, Counter-Spells\n";
        string Message5 = "\nHow powerful of a sorcerer are you pick between 1-10\n";
        string Message6 = "\nFinally we are at your last choice, Your house. Which house do you belong to?\n Slythering, Gryffindor, Hufflepuff, Ravenclaw\n";
        string Message7 = $"\nCongratulations you are now an offical student at Hogwarts, your character sheet can be found in the newly created txt file\n";


        public string GetMessage1()
        {
            return Message1;
        }
        public string GetMessage2()
        {
            return Message2;
        }
        public string GetMessage3()
        {
            return Message3;
        }
        public string GetMessage4()
        {
            return Message4;
        }
        public string GetMessage5()
        {
            return Message5;
        }
        public string GetMessage6()
        {
            return Message6;
        }
        public string GetMessage7()
        {
            return Message7;
        }

        public string GetMessage8()
        {
            return $"Your name: {viewController.GiveName}\n Your bloodstatus: {viewController.BloodStatus}\n you excel at: {viewController.Speciality}\n you are terrible at: {viewController.Weakness}\n your powerlevel is: {viewController.PowerLevel}\n and your house is: {viewController.Houses}";
        }

    }
}