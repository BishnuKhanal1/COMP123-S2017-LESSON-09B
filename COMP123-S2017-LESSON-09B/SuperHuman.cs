using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bishnu Khanal
 * Date: Jan 18, 2017
 * Description: This is the superhuman class that extends the human abstract class
 * Version: 0.3- Added AddPower method to Superhuman class
 * */
namespace COMP123_S2017_LESSON_09B
{
    /// <summary>
    /// This is the superhuman class
    /// </summary>

    public class SuperHuman : Human
    {
        //Private instance variables
        private List<Power> _powers; //we need to initialize to make it a list

        //public properties

        public List<Power> Powers
        {
            get
            {
                return this._powers; //this returns the reference
            }
        }
           

        //constructor

            /// <summary>
            /// this is the main constructor for the superhuman class
            /// it takes one parameter - name(string)
            /// </summary>
            /// <param name="name"></param>
        public SuperHuman(string name)
            :base(name)
        {
            _initialize(); //calling _initialize method
        }


        //private methods

        /// <summary>
        /// this method initializes, instantiates and assigns values to class properties
        /// </summary>
        
        private void _initialize()
        {
            this._powers = new List<Power>(); //this creates an empty list
        }

        //public methods

            /// <summary>
            /// this method adds the power to the power list
            /// it takes two parameters - name(string) - rank(int)
            /// </summary>
            /// <param name="name"></param>
            /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
    }
}