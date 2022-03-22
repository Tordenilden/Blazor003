using Blazor003.repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor003.repo.Repositories
{
    public class CustomerRepository
    {
        public Customer retrieve(int customerId)
        {
            //Collaboration
            Customer customer = new Customer()
            {
                firstName = "Bo",
                lastName = "Nielsen",
                phone = 12341234,
                //Collaborative relationship
            };
            return customer;
        }
        #region version 2 getcustomer
        public Customer retrieveDB(int customerId)
        {
            Customer customer = new Customer();
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    //string query = $"select * from customer where customerId=1";
            //    string query2 = "1";
            //    string query = $"select * from customer where customerId={customerId}";
            //    //string query = $"select * from customer where customerId="+query2;
            //    //int tal = 4;
            //    //SqlCommand cmd1 = new SqlCommand("select * from customer where customerId=1", connection);
            //    SqlCommand cmd2 = new SqlCommand(query, connection);
            //    connection.Open();
            //    SqlDataReader reader = cmd2.ExecuteReader();
            //    reader.Read(); // tjekker om der er data i reader og return bool hvis der er
            //    // det der sker er den "læser 1 linje i et array og sætter markøren klar til at læse
            //    // næste linje fra arrayet
            //    //customer.firstname = "bo";
            //    customer.firstname = reader["firstname"].ToString();
            //    customer.lastname = reader["lastname"].ToString();
            //    //customer.customerId = Convert.ToInt32(reader["customerId"]);
            //    //.....
            //    connection.Close();
            //}
            return customer;
        }
        #endregion version 2 getcustomer
    }
}
