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
    /// Swagger����
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// ע��
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "�ǻ�΢ҽԺƽ̨ HISϵͳ�ӿڷ���");
                c.IncludeXmlComments(GetXmlCommentsPath());
                // c.OperationFilter<HttpHeaderFilter>();  // Ȩ�޹���

            }).EnableSwaggerUi(c => {
                // ʹ������
                c.InjectJavaScript(thisAssembly, "zhyy.his.Scripts.swagger_lang.js");
            });
        }

        /// <summary>
        /// ��ȡxmlע���ĵ�·��
        /// </summary>
        /// <returns></returns>
        protected static string GetXmlCommentsPath()
        {
            return System.String.Format(@"{0}\bin\zhyy.his.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
