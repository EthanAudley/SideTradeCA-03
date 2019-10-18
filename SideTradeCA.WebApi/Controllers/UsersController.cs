// using System.Collections.Generic;
// using Dapper;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Configuration;
// using Npgsql;
// using System.Linq;

// namespace SideTradeCA.WebApi.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class UsersController : ControllerBase
//     {
//         private readonly string _connectionString;

//         public UsersController(IConfiguration configuration)
//         {
//             _connectionString = @"Server=54.194.176.170;Port=5432;Database=code_academy_test;UserId=ca_user;Password=80065a_=}0.Egve;";
//         }

//         [HttpGet]
//         public ActionResult<IEnumerable<string>> Get()
//         {
//             using (var connection = new NpgsqlConnection(_connectionString))
//             {
//                 string[] candidates = connection.Query<string>($"SELECT candidate_name FROM code_academy_all.active_candidates").ToArray();
//                 if (candidates != null)
//                 {
//                     return candidates;
//                 } 
//                 return null;
//             }
//         }
//     }
// }



using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace SideTradeCA.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly string _connectionString;

        public UsersController(IConfiguration configuration)
        {
            _connectionString = configuration["Postgres"];
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                string[] candidates = connection.Query<string>("SELECT candidate_name FROM code_academy_all.active_candidates").ToArray();
                return candidates;
            }
        }
    }
}