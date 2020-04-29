
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Common
{
public static class MvcOptionsExtensions
{
    public static void UseCentralRoutePrefix(this MvcOptions opts, IRouteTemplateProvider routeAttribute)
    {
        // 添加我们自定义 实现IApplicationModelConvention的RouteConvention
        opts.Conventions.Insert(0, new RouteConvention(routeAttribute));
    }
}
}

