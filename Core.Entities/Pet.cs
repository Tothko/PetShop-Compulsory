using System;

namespace Infrastrucute.Data
{
    public class Pet

    {
    public int ID { get; set; }
    public String Name { get; set; }
    public String Type { get; set; }
    public DateTime Birthdate { get; set; }
    public DateTime SoldDate { get; set; }
    public String Color { get; set; }
    public String PreviousOwner { get; set; }
    public double Price { get; set; }

        public override string ToString()
        {
            return "Pet name is: *" + Name + "* Pet tyoe is: *" + Type + "* Pet BirthDate is: *" + Birthdate + "* Pet SoldDate is: *" + SoldDate + 
                "* Pet Color is: *"+ Color + "* Pet PreviuousOwner is: *" + PreviousOwner + "* Pet price is: *"+Price + "* " 
                ;
        }
    }
}
