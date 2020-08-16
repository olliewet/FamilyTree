using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTreeC
{
    class Program
    {
        static void Main(string[] args)
        {
 
            //Delcaring New Person 
            var myAncestor = new Person()
            {           
                // Setting Properties Of The Main Ancestor (Grandad) 
                Name = TreeStructure.personname(),
                DateOfBirth = TreeStructure.persondob(),

                // Creating New List of Children of Grandad
                Children = new List<Person>()
                {           
                    new Person() { Name = "Ollie" },
                    new Person() { Name = "Izzy" },
                    new Person()
                    {
                        Name = "Bart",
                        Children = new List<Person>()
                        {
                            //Children Of Bart 
                            new Person()
                            {
                                Name = "Liza",
                                //New List for Children Of Lizza 
                                Children = new List<Person>()
                                {
                                    new Person() { Name = "Raymondo" },
                                    new Person()
                                    {
                                        Name = "Muna",
                                        //Children of Muna
                                        Children = new List<Person>()
                                        {
                                            new Person() { Name = "Arham" },
                                            new Person() { Name = "Brad" },
                                        }
                                    },
                                }
                            },
                            //Children Of Bart 
                            new Person()
                            {
                                Name = "Emma",
                                Children = new List<Person>()
                                {
                                    new Person() { Name = "Cookie"},
                                    new Person()
                                    {
                                        Name = "Joe",
                                        
                                    }
                                }
                            }

                        }
                    }

                }
            };




            TreeStructure.ShowFamily(myAncestor);
        }
    }
}


