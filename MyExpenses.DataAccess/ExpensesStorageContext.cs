using Microsoft.EntityFrameworkCore;
using MyExpenses.DataAccess.Entities;

namespace MyExpenses.DataAccess
{
    public class ExpensesStorageContext : DbContext
    {
        public ExpensesStorageContext(DbContextOptions<ExpensesStorageContext> opt) : base(opt)
        {

        }

        public DbSet<Expenses> Expenses{ get; set; }
    }
}
