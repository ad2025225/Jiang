using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jiang.WebApi.Controllers
{
    /// <summary>
    /// 路由模板
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
   
    public class BaseController : ControllerBase
    {
    }
}
