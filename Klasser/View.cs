using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace experiment.Klasser
{
    public class View
    {
        string Message1 = @"Welcome to Hogwarts here you will either learn magic or die
            the possiblites are endless :) now lets start with your name";

        public string GetMessage1()
        {
            return Message1;
        }

    }
}