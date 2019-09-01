
using Infrastrucute.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IPetRepository
    {
        IEnumerable<Pet> ReadPets();
    }
}
