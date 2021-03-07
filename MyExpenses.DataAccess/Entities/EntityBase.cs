using System.ComponentModel.DataAnnotations;

namespace MyExpenses.DataAccess.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
