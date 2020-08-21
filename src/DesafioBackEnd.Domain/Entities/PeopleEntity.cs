using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioBackEnd.Domain.Entities
{
    public class PeopleEntity
    {


        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Gender { get; private set; }

        public PeopleEntity(string firstName, string lastName, string email, string phone, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Gender = gender;
        }


    }
}
