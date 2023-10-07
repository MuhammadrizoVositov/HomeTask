using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using WebApI.Interface;
using WebApI.Models;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace WebApI.Servise
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {
        private readonly IDataContext _dataContext;
        private readonly AppFileContext _appFileContext;

        public UserController(IDataContext dataContext, AppFileContext appFileContext)
        {
            _dataContext = dataContext;
            _appFileContext = appFileContext;
        }

        [HttpPost]
        public async Task<IResult> AddUser(User user)
        {
            await _dataContext.Users.AddAsync(user);
             return (IResult)Ok();
        }
        [HttpGet]
        public async ValueTask<User> GetUser(Guid id)
        {
            var user = _dataContext.Users.FirstOrDefault(user => user.Id == id);
            if (user == null)
            {
                throw new Exception();
            }
            return user;


        }
    }





    public class AppFileContext
    {
        internal Task GetUser(int id)
        {
            throw new NotImplementedException();
        }
    }

    
}


