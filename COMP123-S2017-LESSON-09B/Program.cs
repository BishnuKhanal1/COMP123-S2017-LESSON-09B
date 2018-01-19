using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Bishnu Khanal
 * Date: Jan 18, 2017
 * Description: Demo for Lesson 9
 * Version: 0.2- Instantiated an object of type superhuman
 * */
namespace COMP123_S2017_LESSON_09B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Spider Climbing", 50));
        }
    }
}
