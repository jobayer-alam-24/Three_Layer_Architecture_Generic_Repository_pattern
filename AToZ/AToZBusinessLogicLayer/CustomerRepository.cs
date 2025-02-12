using AToZBusinessLogicLayer.Data;
using AToZDataAccessLayer;
using AToZDataAccessLayer.Entities;

namespace AToZBusinessLogicLayer
{
    public class CustomerRepository : IGenericRepository<Customer>
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(Customer customer)
        {
           _context.Add(customer);
            SaveChanges();
        }

        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
            SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            SaveChanges();
        }
        private void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
