using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTwo
{
    public interface IAnimal
    {
        string Name { set; get; }
        void MakeSound();
        void Move();
    }
}
