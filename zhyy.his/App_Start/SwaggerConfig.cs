using System;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Routing.Constraints;
using System.Collections.Generic;

using zhyy.his;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace zhyy.his
{
    /// <summary>
    /// Swagger配置
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// 注册
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "智慧微医院平台 HIS系统接口服务");
                c.IncludeXmlComments(GetXmlCommentsPath());
                // c.OperationFilter<HttpHeaderFilter>();  // 权限过滤

            }).EnableSwaggerUi(c => {
                // 使用中文
                c.InjectJavaScript(thisAssembly, "zhyy.his.Scripts.swagger_lang.js");
            });
        }

        /// <summary>
        /// 获取xml注释文档路径
        /// </summary>
        /// <returns></returns>
        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\bin\zhyy.his.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
