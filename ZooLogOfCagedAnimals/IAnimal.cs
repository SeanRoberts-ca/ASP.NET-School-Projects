using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public interface IAnimal
    {
       void Age();
       void Species();
       string GetDescription(string i);
    }
}