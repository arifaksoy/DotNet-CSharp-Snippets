using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccessModifier
{
    public class Cat
    {
        
        public Cat() 
        {
        }
        public void GetInternalMethod()
        {
            var animal = new Animal("linda", 4, "Domesticc");
            //this is internal method
            animal.SetWildStatus(true);

           
            animal.Name = "adsad";
            //this is protected method and we didn't derive animal class so we cannot access to it 
            ChangeHabitat("testtt");

           



        }
    }
}
