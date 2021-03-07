using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MyExpenses.DataAccess
{
    public class ExpensesStorageContextFactory : IDesignTimeDbContextFactory<ExpensesStorageContext>
    {
        public ExpensesStorageContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ExpensesStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=MyExpensesStorage;Integrated Security=True");
            return new ExpensesStorageContext(optionsBuilder.Options);
        }
    }
}
