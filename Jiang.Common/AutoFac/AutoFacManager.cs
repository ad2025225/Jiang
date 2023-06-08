using Autofac;
using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Jiang.Common.AutoMapper
{
    /// <summary>
    /// autofac
    /// </summary>
    public class AutoFacManager : Autofac.Module
    {
        /// <summary>
        /// 重写Autofac管道Load方法，在这里注册注入
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            // 注册Service
            var assemblysServices = Assembly.Load("Jiang.Service");
            builder.RegisterAssemblyTypes(assemblysServices)
                .InstancePerDependency()//瞬时单例
               .AsImplementedInterfaces()////自动以其实现的所有接口类型暴露（包括IDisposable接口）
               .EnableInterfaceInterceptors(); //引用Autofac.Extras.DynamicProxy;
         
        }
    }
}
