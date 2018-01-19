using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bishnu Khanal
 * Date: Jan 18, 2017
 * Description: This is the power class
 * Version: 0.2- Added a constructor
 * */

namespace COMP123_S2017_LESSON_09B
{
    /// <summary>
    /// This is the power class which will be used as a data type
    /// </summary>
    public class Power
    {

        //public properties

        public string Name { get; set; }

        public int Rank { get; set; }


        //constructors

            /// <summary>
            /// This is the main constructor for the power class
            /// it takes two arguments - name (string) and - rank (int)
            /// </summary>
            /// <param name="name"></param>
            /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}