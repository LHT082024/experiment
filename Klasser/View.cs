using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace experiment.Klasser
{
    public class View
    {
        //questions asked by the console
        string Message1 = @"Welcome to Hogwarts here you will either learn magic or die
the possiblites are endless :) now lets start with your name";
        string Message2 = "and what is your bloodstatus? pick one of the following\nPureblood, Halfblood, Muggleborn";
        string Message3 = "What magic do you excel at pick one of the following\nCharms, Curses, Transfiguration, healing-magic, Jinxes, Hexes, Counter-Spells";
        string Message4 = "Now remember no one is perfcet tell me what are you terrible at\nCharms, Curses, Transfiguration, healing-magic, Jinxes, Hexes, Counter-Spells";
        string Message5 = "How powerful of a sorcerer are you pick between 1-10";
        string Message6 = "Finally we are at your last choice, Your house. Which house do you belong to?\n Slythering, Gryffindor, Hufflepuff, Ravenclaw";
        string Message7 = $"Congratulations you are now an offical student at Hogwarts, your character sheet can be found in the newly created txt file";


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

    }
}