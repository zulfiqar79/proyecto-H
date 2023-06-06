using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    internal class CustomerRepository : IGenericRepository<Customer>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Customer] (Id,DateBirth) VALUES (@Id,@DateBirth)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Customer] SET (Id,DateBirth) WHERE  = @";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Customer] WHERE  = @";
        }

        private string SelectOneStatement
        {
            get => "SELECT , Id,DateBirth FROM [dbo].[Customer] WHERE  = @";
        }

        private string SelectAllStatement
        {
            get => "SELECT , Id,DateBirth FROM [dbo].[Customer]";
        }
        #endregion


        List<Customer> customers = new List<Customer>();
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer obj)
        {
            //throw new NotImplementedException();
            try
            {
                customers.Add(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
