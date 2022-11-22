using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRochelleGuestLecture
{
    public class Person
    {

        public Address Address { get; set; }

       public Dictionary<string, double> Shoes { get; init; }

        //private string _name;
        //private int _letter;


        /*
        public char Letter {
            get
            {
                return (char) _letter;
            }
            set
            { 
                //you do some converstion of you own doing to get the number you wanted
                //use value

                _letter = value;
            } 
        }
        
        public string Name 
        {
            get { return _name; }
           
            set { 
                    if (value is null)
                    {
                        _name = "Is not Set!";
                    }
                    else
                    {
                        _name = value;
                    }

                }
                 
        }*/
        public string Name { get; set; }
        public string SSN { get; init; }

        //public decimal BankAccountBalance { get; }

        //private string name;

        public Person()
        {
            //some method call out to a database to see what hte enxt free social security number if you where the Department of HLS
            SSN = "000-00-0000";

            Shoes = new Dictionary<string, double>(2);

            Address = new Address();
        }

        public Person(Person otherObj)
        {
            Name = otherObj.Name;
            SSN = otherObj.SSN;
            
            //Shoes = new Dictionary<string, double>(otherObj.Shoes);
            Shoes = new Dictionary<string, double>();
            foreach (var item in otherObj.Shoes)
            {
                Shoes.Add(item.Key, item.Value);
            }

            Address = new Address(otherObj.Address);

        }

        public Person(string name)
        {
           Name = name;
           SSN = "000-00-0000";
        }


        
       
        /*
        public void SetName(string name)
        {
            //validation
            if(name is null)
            {
                this.Name = "No name set";
            }
            this.Name = name;
        }
        */
        
    }
}
