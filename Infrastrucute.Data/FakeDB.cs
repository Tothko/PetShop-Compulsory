﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastrucute.Data
{
    public static class FakeDB

    {
        
        public static List<Pet> Pets;
        private static Random random = new Random();
        
    

        public static void InitData()
        {
            Random rnd = new Random();
            Pets = new List<Pet>();
            for (int i = 0; i < 8; i++)
            {
                Pets.Add(
                new Pet
                {
                    ID = i,
                    Name = RandomString(8),
                    Type = "Dog",
                    Birthdate = System.DateTime.Now,
                    SoldDate = System.DateTime.Now,
                    Color = "Orange",
                    PreviousOwner = "Marecek",
                    Price = rnd.Next(0, 1000)

                }) ;
                    
            }
            
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
