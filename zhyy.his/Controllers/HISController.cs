using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace zhyy.his.Controllers
{
    /// <summary>
    /// HIS接口控制器
    /// </summary>
    public class HISController : ApiController
    {
        /// <summary>
        /// 空ACTION
        /// </summary>
        /// <returns></returns>
        public string Options()
        {
            return null; // HTTP 200 response with empty body
        }

        /// <summary>
        /// 绑定就诊卡
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject BindCard(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);
                //string name = obj.name.ToString();
                string cardNo = obj.cardNo.ToString();
                //string mobile = obj.mobile.ToString();
            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 在线建立电子就诊卡
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject CreareCard(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                //dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);
                //string name = obj.name.ToString();
                //string cardNo = obj.cardNo.ToString();
                //string mobile = obj.mobile.ToString();
            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 个人信息查询
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject QueryBaseInfo(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);
                string cardNo = obj.cardNo.ToString();


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 挂号记录查询
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject QueryRegInfo(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);
                string cardNo = obj.cardNo.ToString();


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 缴费记录查询
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject QueryPayedInfo(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);
                string cardNo = obj.cardNo.ToString();


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 待缴费记录查询
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject QueryNeedPayInfo(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 门诊缴费
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject MZPayment(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 住院押金充值
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject RechargeZyDeposit(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 就诊卡充值
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject RechargeCard(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 检查/检验报告单查询
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject QueryReport(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 检查报告单明细查询
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject QueryCheckReportDetail(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 检验报告单明细查询
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject QueryTestReportDetail(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 住院费用清单查询
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject QueryZyFeeInfo(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }

        /// <summary>
        /// 住院费用清单明细查询
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        [HttpGet]
        public JObject QueryZyFeeDetail(string param)
        {
            //创建返回对象
            JObject jobj = Common.PubClass.CreateJObject();

            try
            {
                //解析请求参数
                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(param);


            }
            catch (Exception ex)
            {
                jobj = Common.PubClass.CreateJObject();
                jobj["resultMsg"] = ex.Message;
                jobj["resultCode"] = "1";
            }

            return jobj;
        }
    }
}
