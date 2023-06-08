using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiang.Common.Swagger
{
    /// <summary>
    /// SwaggerSetUp
    /// </summary>
    public static class SwaggerSetUp
    {   /// <summary>
        /// AddSwaggerSetup
        /// </summary>
        /// <param name="services"></param
        /// <exception cref="ArgumentNullException"></exception>
        public static void AddSwaggerSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var ApiName = "Jiang.WebApi";

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("Jiang-V1", new OpenApiInfo
                {
                    Version = $"{ApiName}",
                    Title = "[面试DEMO]",
                    Description = "学习从来无捷径,循环渐进登高峰",
                });
                options.OrderActionsBy(o => o.RelativePath);
                // 获取xml注释文件的目录
                var xmlPath = Path.Combine(AppContext.BaseDirectory, "Jiang.WebApi.xml");
                //默认的第二个参数是false，这个是controller的注释，记得修改
                options.IncludeXmlComments(xmlPath, true);
                    

                // 在header中添加token，传递到后台
                options.OperationFilter<SecurityRequirementsOperationFilter>();

                #region Token绑定到ConfigureServices
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传输) 直接在下框中输入Bearer {token}（注意两者之间是一个空格）\"",
                    Name = "Authorization",//jwt默认的参数名称
                    In = ParameterLocation.Header,//jwt默认存放Authorization信息的位置(请求头中)
                    Type = SecuritySchemeType.ApiKey
                });
                #endregion
            });

        }
    }
}
