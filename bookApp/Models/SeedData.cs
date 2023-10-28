using bookApp.Data;
using Microsoft.EntityFrameworkCore;

namespace bookApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.membershipTypes.Any())
                {
                    Console.WriteLine("Database already seeded");
                    return;
                }
                context.membershipTypes.AddRange(
                    new MembershipType { Id = 1, SignUpFee = 0, DurationInMonths = 0, DiscountRate = 0 },
                    new MembershipType { Id = 2, SignUpFee = 30, DurationInMonths = 1, DiscountRate = 5 },
                    new MembershipType { Id = 3, SignUpFee = 90, DurationInMonths = 3, DiscountRate = 10 },
                    new MembershipType { Id = 4, SignUpFee = 300, DurationInMonths = 12, DiscountRate = 20 });
            } 
        }
        
    }    
}
