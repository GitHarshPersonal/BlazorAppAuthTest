using BlazorAppAuthTest.Models;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BlazorAppAuthTest.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IDbConnection db;

        public UserController(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("dbConnectionString"));
        }

        [HttpGet("{username}")]
        public async Task<User> GetUserAsync(string username)
        {
            var result = await db.QuerySingleOrDefaultAsync<User>($"SELECT * FROM users WHERE username = '{username}'");
            return result;
        }
    }
}
