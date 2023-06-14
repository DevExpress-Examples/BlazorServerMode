using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace InstantFeedback.Models {
    public class IssuesContextInitializer {
        private readonly IssuesContext _context;

        public IssuesContextInitializer(IssuesContext context)
        {
            _context = context;
        }

        public void Seed() {
            _context.Database.EnsureCreated();
            if (_context.Issues.Any())
                return;
            var users = OutlookDataGenerator.Users
                .Select(x => {
                    var split = x.Split(' ');
                    return new User() {
                        FirstName = split[0],
                        LastName = split[1]
                    }; 
                })
                .ToArray();
            _context.Users.AddRange(users);
            _context.SaveChanges();

            var rnd = new Random(0);
            var issues = Enumerable.Range(0, 1000000)
                .Select(i => new Issue() {
                    Subject = OutlookDataGenerator.GetSubject(),
                    UserId = users[rnd.Next(users.Length)].Id,
                    Created = DateTime.Today.AddDays(-rnd.Next(30)),
                    Priority = OutlookDataGenerator.GetPriority(),
                    Votes = rnd.Next(100),
                })
                .ToArray();
            _context.Issues.AddRange(issues);
            _context.SaveChanges();
        }
    }
}
