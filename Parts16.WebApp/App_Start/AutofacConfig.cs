using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Parts16.Bll;
using Parts16.Dal;
using Parts16.IBll;
using Parts16.IDal;

namespace Parts16.WebApp
{
    public class AutofacConfig
    {
        public static void Register()
        {
            // 配置Autofac的基本信息
            // 1、创建容器
            var builder = new ContainerBuilder();
            // 2、进行依赖注入的注册
            builder.RegisterType<RoleDal>().As<IRoleDal>();
            builder.RegisterType<RoleBll>().As<IRoleBll>();
            // 3、注册控制器
            builder.RegisterControllers(typeof(AutofacConfig).Assembly);
            // 4、构建
            var container = builder.Build();
            // 5、实现注入
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}