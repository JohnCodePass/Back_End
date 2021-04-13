using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Back_End.Models;
using Back_End.Services;

namespace Back_End.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {

        public HashPassword hasher;
        public AuthController(IConfiguration configuration, HashPassword hasher)
        {
            Configuration = configuration;
            this.hasher = hasher;
        }
        public IConfiguration Configuration { get; }

        [HttpPost, Route("login")]
        public IActionResult Login([FromBody] UserInfo user)
        {

            using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString("myConnectionString")))
            {
                SqlCommand cmd = new SqlCommand("select * from UserInfo where username like @username and password = @password;");
                cmd.Parameters.AddWithValue("@username", user.username );
                cmd.Parameters.AddWithValue("@password", hasher.Hash(user.password) );
                cmd.Connection = con;
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                if (loginSuccessful)
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                    var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var tokeOptions = new JwtSecurityToken(
                        issuer: "http://localhost:5000",
                        audience: "http://localhost:5000",
                        claims: new List<Claim>(),
                        expires: DateTime.Now.AddMinutes(60),
                        signingCredentials: signinCredentials
                    );
                    var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                    return Ok(new { Token = tokenString });
                }
                else
                {
                    return Unauthorized();
                }
            }

        }

        [HttpPost, Route("add")]
        public bool Add([FromBody] UserInfo user)
        {

            using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString("myConnectionString")))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO UserInfo VALUES (@username, @password)");
                cmd.Parameters.AddWithValue("@username", user.username );
                cmd.Parameters.AddWithValue("@password", hasher.Hash(user.password) );
                cmd.Connection = con;
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                return true;
            }

        }

        // to authorize a method, add "Authorize"
        /* [HttpGet, Route("users"), Authorize]
        public List<string> Users()
        {
            using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString("myConnectionString")))
            {
                SqlCommand cmd = new SqlCommand("SELECT Username, Password FROM UserInfoSql");
                cmd.Connection = con;
                con.Open();

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Users");
                con.Close();

                dt = ds.Tables["Users"];
                List<string> users = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    users.Add(dr["Username"].ToString());
                }

                return users;
            }
        } */

            // DELETE FROM table_name WHERE condition;
        /* [HttpDelete("remove")]
        public bool Delete([FromQuery] string id)
        {

            int Id;
            bool success = Int32.TryParse(id, out Id);

            if (success)
            {

                using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString("myConnectionString")))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM UserInfoSql WHERE Id = @Id");
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Connection = con;
                    con.Open();

                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    con.Close();

                    return true;
                }
            }
            else
            {
                return false;
            }
        } */


        /* [HttpPut("update")]
        public bool Update([FromQuery] string id, [FromBody] UserInfo user)
        {
            int Id;
            bool success = Int32.TryParse(id, out Id);

            if (success)
            {
                using (SqlConnection con = new SqlConnection(Configuration.GetConnectionString("myConnectionString")))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE UserInfoSql SET Username = @username, Password = @password WHERE Id = @Id");
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@password", user.password);
                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Connection = con;
                    con.Open();

                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    con.Close();

                    return true;
                }
            }
            else
            {
                return false;
            }

        } */

    }
}
/* DataSet resembles database.
DataTable resembles database table,
and DataRow resembles a record in a table.
If you want to add filtering or sorting options,
you then do so with a DataView object, and convert it back to a separate DataTable object.

If you're using database to store your data,
then you first load a database table to a DataSet object in memory.
You can load multiple database tables to one DataSet,
and select specific table to read from the DataSet through DataTable object.
Subsequently, you read a specific row of data from your DataTable through DataRow.
Following codes demonstrate the steps:

SqlCeDataAdapter da = new SqlCeDataAdapter();
DataSet ds = new DataSet();
DataTable dt = new DataTable();

da.SelectCommand = new SqlCommand(@"SELECT * FROM FooTable", connString);
da.Fill(ds, "FooTable");
dt = ds.Tables["FooTable"];

foreach (DataRow dr in dt.Rows)
{
    MessageBox.Show(dr["Column1"].ToString());
}

To read a specific cell in a row:

int rowNum // row number
string columnName = "DepartureTime";  // database table column name
dt.Rows[rowNum][columnName].ToString();

 */