
using Infrastrucute.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace Core
{
    public interface IPetService
    {
        List<Pet> GetPets();
        List<Pet> GetPetsByType(String type);
        void CreatePet();
        void DeletePet();
        void SortPetsByPrice();
        List<Pet> GetFiveCheapest();
        void UpdatePet(int ID);
    }
}
