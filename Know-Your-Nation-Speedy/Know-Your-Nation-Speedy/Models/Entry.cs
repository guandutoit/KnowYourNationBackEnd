using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Know_Your_Nation_Speedy.Models
{
    public class Entry
    {

        private int id = 0;
        private string name = String.Empty; 
        private string email = String.Empty; 
        private string password = String.Empty; 

           public string Name{
        get{
             return name;
        }
            set
            {
                name = value;
            }
        }

    public string Email{
        get{
            return email;
        }
        set{
            email = value;
        }
    }



        


           
    public int Id{
        get{
            return id;
        }
        set{
            id = value;
        }
    }
   
    public string Password{
        get{
            return password;
        }
        set{
            password = value;
        }
    }/*
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }*/


    }
}
