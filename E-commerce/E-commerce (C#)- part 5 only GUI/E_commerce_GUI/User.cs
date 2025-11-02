using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS0659

namespace E_commerce
{
    internal class User : ICloneable
    {
        private string username;
        private string password;
        private Address address;

        public User(string username, string password, Address address)
        {
            try
            {
                Username = username;
                Password = password;
                Address = address;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public User()
        {
            Username = "";
            Password = "";
            Address = new Address();
        }
        public User(User other)
        {
            try
            {
                Username = other.Username;
                Password = other.Password;
                Address = (Address)other.Address.Clone();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                try
                {
                    username = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                try
                {
                    password = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                try
                {
                    address = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public override string ToString()
        {
            return "Username: " + Username + "\n Address: " + Address.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            User other = (User)obj;
            return (Username == other.Username && Password == other.Password && Address.Equals(other.Address));
        }
        public virtual object Clone()
        {
            return new User(this);
        }
    }
}