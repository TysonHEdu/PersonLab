﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab
{
    internal class Main
    {
        static void Data(string[] args)
        {
            Person person1;
            person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);
            Person person2;
            person2 = new Person(2, "Gina", "James", 18, "Green", false);
            Person person3;
            person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Person person4;
            person4 = new Person(4, "Mary", "Beals", 28, "Yellow", true);
        }
    }
}
