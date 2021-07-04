using Bogus;
using firstCoreApiProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstCoreApiProject.Fake
{
    public static class FakeData
    {
        private static List<user> _users;

        public static List<user> GetUsers(int number)
        {
            if (_users == null)
            {
                _users = new Faker<user>()
                 .RuleFor(u => u.Id, f => f.IndexFaker+1)
                  .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                  .RuleFor(u => u.LastName, f => f.Name.LastName())
                 .RuleFor(u => u.Address, f => f.Address.FullAddress())
                .Generate(number);
            }
            return _users;

        }
    }
}
