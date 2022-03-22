using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor003.repo.Models
{
    // libs kan være anderledes og derfor giver opdeling god mening
    // er der andet??
    // reuse - getInt() kan Invokes fra begge projekter, så.....????
    // reuseable in another projekt ... never have to code again
    public class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double phone { get; set; }
        public int getInt() { return 4; }
        //Er det her CRUD skal være??
    }
}
