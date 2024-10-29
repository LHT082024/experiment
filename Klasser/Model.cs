using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace experiment.Klasser
{
    public class Model
    {
        public string? Name { get; set; }
        public string? BloodStatus { get; set; }
        public string? Speciality { get; set; }
        public string? Weakness { get; set; }
        public int PowerLevel { get; set; }
        public string? House { get; set; }


        string[] bloodStatus = { "Pureblood", "Halfblood", "Muggleborn" };
        string[] speciality = { "Charms", "Curses", "Transfiguration", "Healing", "Jinxes", "Hexes", "Counter-Spells" };
        int[] powerlevel = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] houses = { "Slytherin", "Gryffindor", "Huffelpuff", "Ravenclaw" };

    }





}