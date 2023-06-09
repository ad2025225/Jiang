using Jiang.Common.JwtHelper;
using Jiang.Models;
using Jiang.Models.Entity;
using Jiang.Models.JWT;
using Microsoft.AspNetCore.Mvc;

namespace Jiang.WebApi.Controllers
{
    /// <summary>
    /// 登录
    /// </summary>
    public class LoginController : BaseController
    {
        private readonly  MyContext db;

        public LoginController(MyContext db)
        {
            this.db = db;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("Login")]
        public IActionResult Post(User user)
        {

            string jwtStr = string.Empty;
            bool suc = false;
            var u= db.Users.Where(u => u.UserName == user.UserName && u.UserPwd == user.UserPwd).FirstOrDefault();
            if (user != null)
            {
                TokenModel tokenModel = new TokenModel { Uid =u.UserName, Role = u.Role };
                jwtStr = JwtHelper.IssueJwt(tokenModel);
                suc = true;
            }
            else
            {
                jwtStr = "login fail";
            }
            return Ok(new
            {
                success = suc,
                token = jwtStr
            });
        }
    }
}
