using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    // It's internal, which means that
    // it can only be accessed from
    // within the same assembly.
    internal class Car
    {

        // member variable
        // private hides the variable from the other classes

       private string _model = "";
       private string _brand = "";
        private bool _isLuxury;

        // Property

        //public string Model { get; set; }
        // With lambda expression
        public string Model { get => _model; set => _model = value; }

      
        // normal expression
        /*
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
       */

        public string Brand
        {
            get
            { 
                if(_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                } else
                {
                    return _brand;
                }
            }

            set {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing!");
                    _brand = "DEFAULTVALUE";
                } else
                {
                    _brand = value;
                }
                
        }
    }

        public bool IsLuxury { get => _isLuxury; 
            set => _isLuxury = value; }


        // Constructor
        public Car(string model, string brand, bool isLuxury) 
        {
            _model = model;
            Brand = brand;
            Console.WriteLine($"A {Brand} of the" + 
              $" model {_model} has been created.");
            IsLuxury = isLuxury;
        }



        public void Drive()
        {
            Console.WriteLine($"I am a {Model} and I am driving.");
        }


    }
}
