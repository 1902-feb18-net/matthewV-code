using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimals.Library
{
    public interface IAnimal
    {
        //implied for all of an interface to be public

        //we don't have fields but we do have properties. 
        //Not auto-implemented in an interface.
        int AnimalId { get; set; }
        string name { get; set; }

        void MakeNoise();
        void GoTo(string location);
    }
}
