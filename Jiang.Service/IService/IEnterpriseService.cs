using Jiang.Models;
using Jiang.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiang.Service.IService
{
    /// <summary>
    /// 企业信息接口
    /// </summary>
    public interface IEnterpriseService
    {
        public ApiResultData GetEnterprise(Guid guid);
        public ApiResultData PostEnterprise(EnterpriseInfo enterpriseInfo);
        public ApiResultData PutEnterprise(EnterpriseInfo enterpriseInfo);
        public ApiResultData DelEnterprise(Guid guid);
        public ApiResultData CountProvince();

    }
}
