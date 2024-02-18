using APIDemo.BAL;
using APIDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        #region GET_ALL_USER
        [HttpGet]
        public IActionResult Get()
        {
            User_BALBase bal = new User_BALBase();
            List<UserModel> users = bal.API_SELECT_ALL_USER();

            Dictionary<String, dynamic> response = new Dictionary<string, dynamic>();
            if (users.Count > 0 && users != null)
            {
                response.Add("status", true);
                response.Add("messege", "Data Found");
                response.Add("data", users);
                return Ok(response);

            }
            else
            {
                response.Add("status", false);
                response.Add("messege ", "Data Not Found");
                response.Add("data", null);
                return NotFound(response);
            }
        }
        #endregion

        #region GET_USER_BY_ID
        [HttpGet("/UserID")]
        public IActionResult Get(int UserID)
        {
            User_BALBase bal = new User_BALBase();
            UserModel user = bal.API_SELECT_BY_PK_USER(UserID);

            Dictionary<String, dynamic> response = new Dictionary<string, dynamic>();
            if (user.UserID != 0)
            {
                response.Add("status", true);
                response.Add("messege", "Data Found");
                response.Add("data", user);
                return Ok(response);

            }
            else
            {
                response.Add("status", false);
                response.Add("messege ", "Data Not Found");
                response.Add("data", null);
                return NotFound(response);
            }
        }
        #endregion


        #region DELETE_USER
        [HttpDelete("{UserID}")]
        public IActionResult Delete(int UserID)
        {
            User_BALBase bal = new User_BALBase();
            var user = bal.API_DELETE_USER(UserID);

            Dictionary<String, dynamic> response = new Dictionary<string, dynamic>();
            if (user != 0)
            {
                response.Add("status", true);
                response.Add("messege", "Data Found");
                response.Add("data", user);
                return Ok(response);

            }
            else
            {
                response.Add("status", false);
                response.Add("messege ", "Data Not Found");
                response.Add("data", null);
                return NotFound(response);
            }
        }

        #endregion


        #region INSERT_USER
        [HttpPost]
        public IActionResult INSERT(string Name, string Contact, string Email)
        {
            User_BALBase bal = new User_BALBase();
            var user = bal.API_INSERT_USER(Name,Contact,Email);

            Dictionary<String, dynamic> response = new Dictionary<string, dynamic>();
            if (user != 0)
            {
                response.Add("status", true);
                response.Add("messege", "Data Found");
                response.Add("data", user);
                return Ok(response);

            }
            else
            {
                response.Add("status", false);
                response.Add("messege ", "Data Not Found");
                response.Add("data", null);
                return NotFound(response);
            }
        }

        #endregion

        #region UPDATE_USER
        [HttpPut]
        public IActionResult UPDATE(int UserID,string Name, string Contact, string Email)
        {
            User_BALBase bal = new User_BALBase();
            var user = bal.API_UPDATE_USER(UserID,Name, Contact, Email);

            Dictionary<String, dynamic> response = new Dictionary<string, dynamic>();
            if (user != 0)
            {
                response.Add("status", true);
                response.Add("messege", "Data Found");
                response.Add("data", user);
                return Ok(response);

            }
            else
            {
                response.Add("status", false);
                response.Add("messege ", "Data Not Found");
                response.Add("data", null);
                return NotFound(response);
            }
        }

        #endregion

    }
}