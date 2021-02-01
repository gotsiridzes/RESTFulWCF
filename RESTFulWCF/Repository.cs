using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTFulWCF
{
    public static class Repository
    {
        private static List<Person> _people = new List<Person>
        { 
            new Person{ Id = 1, FirstName = "saba", LastName = "gotsiridze"},
            new Person{ Id = 2, FirstName = "andria", LastName = "mania"},
            new Person{ Id = 3, FirstName = "tornike", LastName = "zhizhiashvili"},
            new Person{ Id = 5, FirstName = "giorgi", LastName = "abashidze"}
        };

        public static List<Person> People
        {
            get 
            { 
                return _people; 
            }
            private set 
            { 
                _people = value; 
            }
        }

    }
}