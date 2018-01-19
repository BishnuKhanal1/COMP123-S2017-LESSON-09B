using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Bishnu Khanal
 * Date: Jan 18, 2017
 * Description: this is the abstract human class
 * Version: 0.1- Created the abstract human class
 * */

namespace COMP123_S2017_LESSON_09B
{
    /// <summary>
    /// this is the abstract human class
    /// </summary>
    
    public abstract class Human
    {
        //private instance variables
        private string _name;


        //public properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        //constructors
        /// <summary>
        /// This is the main constructor for the human class, takes one parameter- name(string)
        /// 
        /// </summary>
        /// <param name="name"></param>
         public Human(string name)
        {
            this.Name = name;
        }

        //private methods


        //public methods
    }
}