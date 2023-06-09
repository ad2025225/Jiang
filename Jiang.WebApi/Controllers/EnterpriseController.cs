using Jiang.Models;
using Jiang.Models.Entity;
using Jiang.Service.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Jiang.WebApi.Controllers
{
    /// <summary>
    /// 企业信息
    /// </summary>
    public class EnterpriseController : BaseController
    {
        private readonly IEnterpriseService _enterpriseService;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="enterpriseService"></param>
        public EnterpriseController(IEnterpriseService enterpriseService)
        {
            _enterpriseService = enterpriseService;
        }

        /// <summary>
        /// 统计查询数据Admin身份
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("Enterprise")]
        [Authorize(Roles = "Admin")]
        public ApiResultData GET(Guid guid)
        {

            return _enterpriseService.GetEnterprise(guid);
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("Enterprise")]
        public ApiResultData POST(EnterpriseInfo enterpriseInfo)
        {
            return _enterpriseService.PostEnterprise(enterpriseInfo);
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <returns></returns>
        [HttpPut, Route("Enterprise")]
        public ApiResultData PUT(EnterpriseInfo enterpriseInfo)
        {
            return _enterpriseService.PutEnterprise(enterpriseInfo);
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <returns></returns>
        [HttpDelete, Route("Enterprise")]
        public ApiResultData DELETE(Guid guid)
        {
            return _enterpriseService.DelEnterprise(guid);
        }
        /// <summary>
        /// 统计省份身份System
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("CountProvince")]
        [Authorize(Roles = "System")]
        public ApiResultData Get()
        {

            return _enterpriseService.CountProvince();
        }
    }
}
