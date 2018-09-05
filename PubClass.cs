using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zhyy.his.Common
{
    /// <summary>
    /// 公共帮助类
    /// </summary>
    public class PubClass
    {
        /// <summary>
        /// 创建默认API返回对象
        /// </summary>
        /// <returns></returns>
        public static JObject CreateJObject()
        {
            JObject jobj = new JObject();
            jobj.Add("resultCode", "0");
            jobj.Add("resultMsg", "");

            return jobj;
        }
    }
}