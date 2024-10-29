using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace experiment.Klasser
{
    public class Model
    {
        public string BloodStatus { get; set; }
        public string Speciality { get; set; }
        public int PowerLevel { get; set; }
        public string House { get; set; }
        public string Name { get; set; }
    }

    // public override string ToString()
    //     {
    //         return $"Your name is: {Name}\n Your BloodStatus: {BloodStatus}\n Your Speciality: {Speciality}\n Your Powerlever: {PowerLevel}\n And your House is: {House}";

    //     }
}