using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTreeC
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var myAncestor = new Person()
            {
                
                Name = TreeStructure.personname(),
                DateOfBirth = TreeStructure.persondob(),
                Children = new List<Person>()
                {           
                    new Person() { Name = "Aunt" },
                    new Person() { Name = "Uncle" },
                    new Person()
                    {
                        Name = "Dad",
                        Children = new List<Person>()
                        {
                            new Person()
                            {
                                Name = "Me",
                                Children = new List<Person>()
                                {
                                    new Person() { Name = "John" },
                                    new Person()
                                    {
                                        Name = "Jill",
                                        Children = new List<Person>()
                                        {
                                            new Person() { Name = "Sally", DateOfBirth = "4/4/1998" },
                                            new Person() { Name = "Simon" },
                                        }
                                    },
                                }
                            },
                            new Person()
                            {
                                Name = "Sister",
                                Children = new List<Person>()
                                {
                                    new Person() { Name = "John" },
                                    new Person()
                                    {
                                        Name = "Jill",
                                        
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


