// System namespace needed to use Console class.
using System;
// System.Collections.Generic namespace needed to use Console class.
using System.Collections.Generic;
// System.Text namespace needed to use Console class.
using System.Text;

// My collection of classes for this project
namespace Properties_Sadler_Madison
{
    // Main class for the program
    class Car
    {
        // Creates a private string called model
        private string model;

        // Creates a public string called Model
        public string Model
        {
            // Sets the getter
            get { return model; }
            // Sets the setter
            set { model = value; }
        }

        // Creates a public string called Make
        public string Make
        {
            // Sets the getter
            get;
            // Sets the setter
            set;
        }
    }
}
