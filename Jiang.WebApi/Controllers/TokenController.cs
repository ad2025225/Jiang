using Jiang.Common.JwtHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Jiang.WebApi.Controllers
{
    /// <summary>
    /// 解析Token
    /// </summary>
    public class TokenController :BaseController
    {
        /// <summary>
        /// 解析Token
        /// </summary>
        /// <returns></returns>
        
        [HttpGet,Route("ParseToken")]
        public IActionResult GET()
        {
            //需要截取Bearer 
            var tokenHeader = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var user = JwtHelper.SerializeJwt(tokenHeader);
            return Ok(user);
        }
    }
}
