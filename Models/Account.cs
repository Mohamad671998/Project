using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Project.Models
{
    public class Account{
    
        public int AccountID { get; set; }

        public string AccountName { get; set; }

        public string Password { get; set; }     

        public int Phonenumber  { get; set; }

        public int isAdmin{get;set;} 

    }
}