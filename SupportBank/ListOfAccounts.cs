using System.Collections.Generic;
using System;

namespace SupportBank
{
    public class ListOfAccounts
    {
        public Dictionary<string, decimal> AllAccounts = new Dictionary<string, decimal>();

        public void Update(ListOfTransactions AllTransactions)
        {
            foreach (Transaction t in AllTransactions.AllTransactions)
            {
                if (AllAccounts.ContainsKey(t.From))
                {
                    AllAccounts[t.From] -= t.Amount;
                }
                else
                {
                    AllAccounts.Add(t.From, -t.Amount);
                }
                
                if (AllAccounts.ContainsKey(t.To))
                {
                    AllAccounts[t.To] += t.Amount;
                }
                else
                {
                    AllAccounts.Add(t.To, t.Amount);
                }
                
                
            }
        }
        
        public Dictionary<string, decimal> GetUserInfo(string name)
        {
            if (AllAccounts.ContainsKey(name))
            {
                var user = new Dictionary<string, decimal>(){
                    {name, AllAccounts[name]},
                };

                return user;
            }
            else
            {
                var user = new Dictionary<string, decimal>(){
                    {name, AllAccounts[name]},
                };
                return user;
            }
        }



    }
}