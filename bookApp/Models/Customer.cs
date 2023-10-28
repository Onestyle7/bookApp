using bookApp.Models;
using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        //Data adnottations

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public MembershipType MembershipType { get; set; }
        public Customer()
        {

        }
    }
}