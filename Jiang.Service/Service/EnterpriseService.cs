using Jiang.Models;
using Jiang.Models.Entity;
using Jiang.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiang.Service.Service
{
    /// <summary>
    ///企业信息实现类
    /// </summary>
    public class EnterpriseService : IEnterpriseService
    {
        private readonly MyContext DB;
        public EnterpriseService(MyContext dB)
        {
            DB = dB;
        }

     
        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public  ApiResultData GetEnterprise(Guid guid)
        {
            List<EnterpriseInfo>? result;
            if (guid !=Guid.Empty)
            {
                result = DB.EnterpriseInfo.Where(e => e.EnterpriseInfoId == guid && e.Status != 1).ToList();
            }
            else
            {
                result = DB.EnterpriseInfo.ToList();
            }
        


            return new ApiResultData(result);

        }
        /// <summary>
        /// 插入
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public ApiResultData PostEnterprise(EnterpriseInfo enterpriseInfo)
        {
            if (enterpriseInfo != null)
            {
                DB.EnterpriseInfo.Add(enterpriseInfo);
                var rows = DB.SaveChanges();
                return new ApiResultData(rows);
            }
            else
            {
                return new ApiResultData(400,"不能为空");
            }
            

        
        }
        
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="enterpriseInfo"></param>
        /// <returns></returns>
        public ApiResultData PutEnterprise(EnterpriseInfo enterpriseInfo)
        {
            if (enterpriseInfo != null)
            {
                EnterpriseInfo  enterprise=DB.EnterpriseInfo.Where(e=>e.EnterpriseInfoId==enterpriseInfo.EnterpriseInfoId).FirstOrDefault();

                enterprise.EnterpriseInfoId = enterpriseInfo.EnterpriseInfoId;
                    enterprise.CompanyName = enterpriseInfo.CompanyName;
                    enterprise.CompanyCode= enterpriseInfo.CompanyCode;
                    enterprise.Province= enterpriseInfo.Province;
                    enterprise.City= enterpriseInfo.City;
                    enterprise.Prefecture= enterpriseInfo.Prefecture;
                    enterprise.Status= enterpriseInfo.Status;

                    var rows = DB.SaveChanges();
                    return new ApiResultData(rows);
                
               
            }
            else
            {
                return new ApiResultData(400, "不能为空");
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public ApiResultData DelEnterprise(Guid guid)
        {
            EnterpriseInfo enterpriseInfo= DB.EnterpriseInfo.Where(e => e.EnterpriseInfoId == guid).FirstOrDefault();
            if (enterpriseInfo != null)
            {
                enterpriseInfo.Status = 1;
                var rows = DB.SaveChanges();
                return new ApiResultData(rows);
            }
            else {

                return new ApiResultData(400, "不存在");
            }
           
            
        }
        /// <summary>
        /// 统计省份
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        ApiResultData IEnterpriseService.CountProvince()
        {
       
           var  result= DB.EnterpriseInfo
                .GroupBy(x=>x.Province)
                .Select(p=>new { Province = p.Key, EnterpriseInfos = p.ToList()})
                .ToList()  ;
            if (result.Count > 0)
            {
                return new ApiResultData(result);
            }
            else {

                return new ApiResultData(400, "失败");

            }
        }
    }
}
