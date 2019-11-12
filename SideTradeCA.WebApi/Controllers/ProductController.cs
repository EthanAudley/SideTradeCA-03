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
    public class ProductController : ControllerBase
    {
        private readonly string _connectionstring;

        public ProductController()
        {
            _connectionstring = @"Server=54.194.176.170;Port=5432;Database=code_academy_candidate_13;UserId=candidate_13;Password=[j+W/4yGz7a&pMx?;";
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            using (var conncetion = new NpgsqlConnection(_connectionstring))
            {
                return await conncetion.QueryAsync<Product>("SELECT * FROM ca_project.vw_products");
            }
        }

        // // [HttpPut]
        // // public async Task<IEnumerable<Product>> Put()
        // // {
        // //     // using (var conncetion = new NpgsqlConnection(_connectionstring))
        // //     // {
        // //     //     return await conncetion.QueryAsync<Product>("SELECT * FROM ca_project.vw_products");
        // //     // }
        // //     return null;
        // // }

        // // [HttpPost]
        // // public async Task<IEnumerable<Product>> Post()
        // // {
        // //     // using (var conncetion = new NpgsqlConnection(_connectionstring))
        // //     // {
        // //     //     return await conncetion.QueryAsync<Product>("SELECT * FROM ca_project.vw_products");
        // //     // }
        // //     return null;
        // // }

        // // [HttpDelete]
        // // public async Task<IEnumerable<Product>> Delete()
        // // {
        // //     // using (var conncetion = new NpgsqlConnection(_connectionstring))
        // //     // {
        // //     //     return await conncetion.QueryAsync<Product>("SELECT * FROM ca_project.vw_products");
        // //     // }
        // //     return null;
        // // }
    }
}