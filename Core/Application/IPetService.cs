
using Infrastrucute.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace Core
{
    public interface IPetService
    {
        List<Pet> GetPets();
    }
}
