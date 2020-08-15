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
                    new Person() { Name = TreeStructure.personname() },
                    new Person() { Name = TreeStructure.personname() },
                    new Person()
                    {
                        Name = TreeStructure.personname(),
                        Children = new List<Person>()
                        {
                            new Person()
                            {
                                Name = TreeStructure.personname(),
                                Children = new List<Person>()
                                {
                                    new Person() { Name = TreeStructure.personname() },
                                    new Person()
                                    {
                                        Name = TreeStructure.personname(),
                                        Children = new List<Person>()
                                        {
                                            new Person() { Name = TreeStructure.personname(), DateOfBirth = TreeStructure.persondob() },
                                            new Person() { Name = TreeStructure.personname() },
                                        }
                                    },
                                }
                            },
                            new Person()
                            {
                                Name = TreeStructure.personname(),
                                Children = new List<Person>()
                                {
                                    new Person() { Name = TreeStructure.personname() },
                                    new Person()
                                    {
                                        Name = TreeStructure.personname(),
                                        
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


