using Jiang.Common.JwtHelper;
using Jiang.Models;
using Jiang.Models.JWT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Jiang.WebApi.Controllers
{
    /// <summary>
    /// 登录
    /// </summary>
    public class LoginController : BaseController
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        [HttpPost,Route("Login")]
        public IActionResult Post(Users users) {
          
            string jwtStr = string.Empty;
            bool suc = false;

            if (users != null)
            { // 将用户id和角色名，作为单独的自定义变量封装进 token 字符串中。
                TokenModel tokenModel = new TokenModel { Uid =users.UserName , Role = users.Role };
                jwtStr = JwtHelper.IssueJwt(tokenModel);//登录，获取到一定规则的 Token 令牌
                suc = true;
            }
            else
            {
                jwtStr = "login fail!!!";
            }
            return Ok(new
            {
                success = suc,
                token = jwtStr
            });
        }
    }
}
