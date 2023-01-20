using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Bank
/*
    Creating Account
    Deleting Account
    Update Account
    Dispense ATM Card
    Assign Card PIN
    Change Card;
    Block Card;
    Deposit Money
    Withdraw Money;
    Dispense Cash
    Access Account
    Check Balance
    Transfer to Account of the same Bank
    Transfer to different Bank
    Recharge airtime

*/

// account
/*
    FirstName;
    LastName;
    Address;
    DateOfBirth;
    ID;
*/

namespace dotnet
{  
    public class Bank
    {
        ArrayList AllAccounts = new ArrayList();
        public void CreateAccount(string Name, string Address)
        {
            
        }
        public void AddAccounts(string name )
        {
            AllAccounts.Add(name);
        }
    }
}