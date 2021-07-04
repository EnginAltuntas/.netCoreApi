using firstCoreApiProject.Fake;
using firstCoreApiProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstCoreApiProject.Controllers
{
    [Route("api/[Controller]")]
    public class UsersController:ControllerBase
    {
        private List<user> _user = FakeData.GetUsers(50);

        [HttpGet]
        public List<user> Get()
        {
            return _user;
        }
        [HttpGet("{id}")]
        public user Get(int id)
        {
            var user = _user.FirstOrDefault(x => x.Id == id);
            return user;
        }

        [HttpPost]
        public user Post([FromBody]user user)
        {
            _user.Add(user);
            return user;
        }
        [HttpPut]
        public user Put([FromBody]user user)
        {
            var editedUser = _user.FirstOrDefault(x => x.Id == user.Id);
            editedUser.FirstName = user.FirstName;
            editedUser.LastName = user.LastName;
            editedUser.Address = user.Address;
            return user; 
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deletedUser = _user.FirstOrDefault(x => x.Id == id);
            _user.Remove(deletedUser);
        }


    }
}
