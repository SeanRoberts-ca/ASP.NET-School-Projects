using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Bear : Animal, IAnimal
    {

        public bool IsGrizzly;

        public Bear(int Age, string Species, bool IsGrizzly)
        {
            this.Age = Age;
            this.Species = Species;
            this.IsGrizzly = IsGrizzly;
        }
        //public
        public string RequestUniqueCharacteristic()
        {
            string value;
            Console.Write("Is it a grizzly bear (true/false)? ");
            value = Console.ReadLine();
            return value;
        }
        public string GetDescription(string CageNumber)
        {

            string WordJoiner = "";

            if (!IsGrizzly)
            {
                WordJoiner = "non-";
            }

            return "Cage " + CageNumber + " contains a " + this.Age + "-year-old " + WordJoiner + "grizzly bear.";
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
