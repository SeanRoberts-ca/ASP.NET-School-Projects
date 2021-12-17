using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Lion : Animal, IAnimal
    {

        public string ManeColour;

        public Lion(int Age, string Species, string ManeColour)
        {
            this.Age = Age;
            this.Species = Species;
            this.ManeColour = ManeColour;
        }
        public string RequestUniqueCharacteristic()
        {
            string value;
            Console.Write("What colour is its mane? ");
            value = Console.ReadLine();
            return value;

        }
        public string GetDescription(string CageNumber)
        {
            return "Cage " + CageNumber + " contains a " + this.Age + "-year-old " + this.Species + " with a " + this.ManeColour + " mane.";
        }

        void IAnimal.Age()
        {
            throw new NotImplementedException();
        }

        void IAnimal.Species()
        {
            throw new NotImplementedException();
        }
    }
}
