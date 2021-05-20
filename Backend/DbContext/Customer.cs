using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backend
{
    public class Customer
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        public Customer()
        {
            Tickets = new List<Ticket>();
        }
        public Customer(Customer cust)
        {
            this.Id = cust.Id;
            this.FirstName = cust.FirstName;
            this.LastName = cust.LastName;
            this.PhoneNumber = cust.PhoneNumber;
            Tickets = new List<Ticket>();
        }
    }
}