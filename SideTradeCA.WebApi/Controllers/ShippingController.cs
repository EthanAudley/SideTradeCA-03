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
    public class ShippingController : ControllerBase
    {
        private readonly string _connectionstring;

        
        public ShippingController()
        {
            _connectionstring = @"Server=54.194.176.170;Port=5432;Database=code_academy_candidate_13;UserId=candidate_13;Password=[j+W/4yGz7a&pMx?;";
        }

        
        [HttpGet]
        public async Task<IEnumerable<Shipping>> Get()
        {
            using (var conncetion = new NpgsqlConnection(_connectionstring))
            {
                return await conncetion.QueryAsync<Shipping>("SELECT * FROM ca_project.vw_shipping");
            }
        }
    }
}