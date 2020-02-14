using System.ComponentModel.DataAnnotations;

namespace CBBlazorEFID.Data
{
    public class Customer
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
    }
}