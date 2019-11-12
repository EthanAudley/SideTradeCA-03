using System.Collections.Generic;
using Dapper;
using Npgsql;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SideTradeCA.WebApi.Entities;

namespace SideTradeCA.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly string _connectionstring;

        
        public RegisterController()
        {
            _connectionstring = @"Server=54.194.176.170;Port=5432;Database=code_academy_candidate_13;UserId=candidate_13;Password=[j+W/4yGz7a&pMx?;";
        }

        
        [HttpGet]
        public async Task<IEnumerable<UserRegister>> Get()
        {
            using (var conncetion = new NpgsqlConnection(_connectionstring))
            {
                return await conncetion.QueryAsync<UserRegister>("SELECT * FROM ca_project.vw_users");
            }
        }

        [HttpPost]
        public async Task<IEnumerable<UserRegister>> Post()
        {
            using (var cmd = new NpgsqlCommand("INSERT INTO ca_project.login_information (username, user_password) VALUES (@p)"))
            {
                
                cmd.Parameters.AddWithValue("p", "");
                cmd.ExecuteNonQuery();
                return null;
            }

        }
    }
}