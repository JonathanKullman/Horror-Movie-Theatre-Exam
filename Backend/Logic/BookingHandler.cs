using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Backend
{
    public class BookingHandler
    {
        private readonly HorrorTheatreContext context = new();
        private readonly Regex firstNameRegexValid;
        private readonly Regex lastNameRegexValid;
        private readonly Regex phoneNumberRegexValid;
        private Customer customer;

        public BookingHandler()
        {
            //Letters, both upper and lower
            firstNameRegexValid = new Regex(@"^[A-Za-zÅÄÖåäö]{1,18}$");
            //Letters, both upper and lower
            lastNameRegexValid = new Regex(@"^[A-Za-zÅÄÖåäö]{1,18}$");
            //10 minimum digits
            phoneNumberRegexValid = new Regex(@"^([0-9]{10,15})$");
        }

        public Theatre GetTheatreInfo(Customer customer)
        {
            var tickets = context.Tickets.Where(c => c.CustomerId == customer.Id).FirstOrDefault();
            var theatre = tickets.Theatre;
            return theatre;
        }

        public Movie GetMovieInfo(Customer customer)
        {
            var tickets = context.Tickets.Where(c => c.CustomerId == customer.Id).FirstOrDefault();
            var movie = tickets.Theatre.Movie;
   
            return movie;
        }

        public bool CheckIfCustomerExisting(string pNumber)
        {
            customer = context.Customers.Select(c => c).Where(c => c.PhoneNumber == pNumber).FirstOrDefault();

            if (customer != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ChangeCustomerTicketAmount(Theatre theatre, Customer customer, int newTicketAmount)
        {
            theatre.OccupiedSeats = theatre.OccupiedSeats - customer.Tickets.Count;

            var removeTicketList = context.Tickets.Select(c => c).Where(c => c.CustomerId == customer.Id).ToList();

            foreach (var ticket in removeTicketList)
            {
                context.Tickets.Remove(ticket);
            }

            customer.Tickets.Clear();

            var customerCopy = new Customer(customer);

            context.Customers.Remove(customer);

            context.Customers.Add(customerCopy);

            for (int i = 0; i < newTicketAmount; i++)
            {
                theatre.OccupiedSeats += 1;
                customerCopy.Tickets.Add(new Ticket { TheatreId = theatre.Id, CustomerId = customer.Id, Seat = theatre.OccupiedSeats, Wheelchair = theatre.GotWheelchairRamp });
            }

            context.SaveChanges();

        }

        public void RemoveCustomer(Customer customer)
        {
            var removeTicketList = context.Tickets.Select(c => c).Where(c => c.CustomerId == customer.Id).ToList();

            foreach (var ticket in removeTicketList)
            {
                ticket.Theatre.OccupiedSeats--;
                context.Tickets.Remove(ticket);
            }

            customer.Tickets.Clear();

            context.Customers.Remove(customer);

            context.SaveChanges();
        }

        public Customer GetExistingCustomer(string pNumber)
        {
            customer = context.Customers.Select(c => c).Where(c => c.PhoneNumber == pNumber).FirstOrDefault();
            return customer;
        }

     
        public Movie GetMovie(string movieName)
        {
            var movie = context.Movies.Where(movie => movie.Name == movieName).FirstOrDefault();
            return movie;
        }

        public Theatre GetTheatre(DateTime currentTheatre, Movie movie)
        {
            var theatre = context.Theatres.Where(c => c.StartTime == currentTheatre && c.MovieId == movie.Id).FirstOrDefault();
            return theatre;
        }

        public Theatre GetTheatreForWheelChair(DateTime currentTheatre, Movie movie)
        {
            var theatre = context.Theatres.Where(c => c.StartTime == currentTheatre && c.MovieId == movie.Id && c.GotWheelchairRamp == true).FirstOrDefault();
            return theatre;
        }

        public bool FirstNameValid(string firstName)
        {
            if (firstNameRegexValid.IsMatch(firstName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LastNameValid(string lastName)
        {
            if (lastNameRegexValid.IsMatch(lastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PhoneNumberValid(string phoneNumber)
        {
            if (phoneNumberRegexValid.IsMatch(phoneNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Customer GetNewCustomer(string tempFirstName, string tempLastName, string tempPhoneNumber, int tempTicketAmt, Theatre theatre)
        {
            var customer = new Customer { FirstName = tempFirstName, LastName = tempLastName, PhoneNumber = tempPhoneNumber };

            for (int i = 0; i < tempTicketAmt; i++)
            {
                theatre.OccupiedSeats += 1;
                customer.Tickets.Add(new Ticket { TheatreId = theatre.Id, CustomerId = customer.Id, Seat = theatre.OccupiedSeats, Wheelchair = theatre.GotWheelchairRamp });
            }

            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }
    }
}
