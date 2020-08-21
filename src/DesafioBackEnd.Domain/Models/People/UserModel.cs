
using System;

namespace DesafioBackEnd.Domain.Models.People
{
    public class PeopleModel
    {
        private Guid _Id;
        public Guid Id
        {
            get { return _Id; }
            set { this._Id = value; }
        }

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

        private string _Gender;
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        private DateTime _CreateAt;
        public DateTime CreateAt
        {
            get { return _CreateAt; }
            set { _CreateAt = value == null ? DateTime.UtcNow : value; }
        }
        
        private DateTime _UpdateAt;
        public DateTime UpdateAt
        {
            get { return _UpdateAt; }
            set { _UpdateAt = value; }
        }
        
       
        
    }
}