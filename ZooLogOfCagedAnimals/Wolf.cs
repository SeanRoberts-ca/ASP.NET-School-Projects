using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Wolf : Animal, IAnimal
    {
        public int Speed;

        public Wolf(int Age, string Species)
        {
            this.Age = Age;
            this.Species = Species;
        }
        public Wolf(int Age, string Species, int Speed)
        {
            this.Age = Age;
            this.Species = Species;
            this.Speed = Speed;
        }
        public string RequestUniqueCharacteristic()
        {
            string value;
            Console.Write("How fast can it run (in km/h)? ");
            value = Console.ReadLine();
            return value;
        }

        public string GetDescription(string CageNumber)
        {
            return "Cage " + CageNumber + " contains a " + this.Age + "-year-old " + this.Species + " that runs " + this.Speed + " km/h.";
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
