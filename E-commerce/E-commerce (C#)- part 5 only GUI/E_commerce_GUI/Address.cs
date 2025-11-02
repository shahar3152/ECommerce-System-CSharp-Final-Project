using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS0659

namespace E_commerce
{
    internal class Address : ICloneable
    {
        private string street;
        private int houseNumber;
        private string city;
        private string state;

        public Address(string street, int houseNumber, string city, string state)
        {
            try
            {
                Street = street;
                HouseNumber = houseNumber;
                City = city;
                State = state;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Address()
        {
            Street = "";
            HouseNumber = 0;
            City = "";
            State = "";
        }
        public Address(Address other)
        {
            try
            {
                Street = other.street;
                HouseNumber = other.houseNumber;
                City = other.city;
                State = other.state;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        throw new Exception("\nSet street failed\n");
                    }
                    street = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public int HouseNumber
        {
            get
            {
                return houseNumber;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("\nHouse number must be positive number\nSet house number failed\n");
                    }
                    houseNumber = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        throw new Exception("\nCity must be with one or more chars\nSet city failed\n");
                    }
                    city = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        throw new Exception("\nState must be with one or more chars\nSet state failed\n");
                    }
                    state = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public override string ToString()
        {
            string str = "Street: " + street + "\n House Number: " + houseNumber + "\n City: " + city + "\n State: " + state;
            return str;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Address other = (Address)obj;
            return ((street == other.street) && (houseNumber == other.houseNumber) && (city == other.city) && (state == other.state));
        }
        public object Clone()
        {
            return new Address(this);
        }
    }
}