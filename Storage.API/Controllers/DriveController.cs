using Microsoft.AspNetCore.Http;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Storage.API.Controllers;
using Storage.API.Models;
using System.Linq;

namespace Storage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriveController : ControllerBase
    {
        private static List<Drive> _drives=new List<Drive>();
     
        [HttpGet]
        public IEnumerable<Drive> Get( ) 
        {
            return _drives = _drives;
            //return DriveInfo.GetDrives().Select(driveinfo => _drives.Map<Drive>(driveinfo));
        }
        [HttpPost]
        public ActionResult AddDrive([FromBody]Drive drive) 
        {
            _drives.Add(drive);
            return Ok( drive);
        }

    }
}
