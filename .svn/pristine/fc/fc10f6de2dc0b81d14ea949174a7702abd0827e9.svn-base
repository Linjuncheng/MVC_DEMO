using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tools.tools;
using DB.Model;
using DB.BLL;
using InvoiceSystem.Models;

namespace InvoiceSystem.Controllers
{
    public class TokenAuthentication: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Random random = new Random();
            M_Online obj = new M_Online();
            M_TokenTable t_obj = new M_TokenTable();
            RefreshToken refreshToken = new RefreshToken();
            string ErrMsg = string.Empty;
            bool bl = false;
            var user_agent = filterContext.HttpContext.Request.Headers.Get("User-Agent");
            var token = filterContext.HttpContext.Session["Token"];
            var refroken = filterContext.HttpContext.Request.Cookies["RefreshToken"];
            var oid = filterContext.HttpContext.Session["id"];
            var uid = filterContext.HttpContext.Session["uid"];
            if (uid is null) uid = filterContext.HttpContext.Request.Cookies["uid"];//如果Session没有uid就去Cookie拿
            if (uid is null) filterContext.HttpContext.Response.Redirect("/Home/login");//如果Cookie没有uid就跳转登录界面
            if (oid is null) oid = filterContext.HttpContext.Request.Cookies["id"];//Session没有oid就去Cookie拿
            if (oid is null)
            {
                bl = true;
            }
            else
            {
                
                obj.ID = (int)oid;
                int i = (int)oid;
                if (B_Online.Select(ref obj,obj.ID,ref ErrMsg) != -1)
                {
                    string tmpstr = RefreshToken.CreateToken(obj.ID,user_agent,obj.Token);
                    if (!string.Equals(tmpstr, token.ToString())) bl = true;
                }
            }
            if (refroken is null) filterContext.HttpContext.Response.Redirect("/Home/login");
            long now = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            if (now > t_obj.Exp) filterContext.HttpContext.Response.Redirect("/Home/login");
            if (RefreshToken.AuthenticationRefToken(refroken.Value,t_obj.AesKey,t_obj.AesIV,ref refreshToken,ref ErrMsg))
            base.OnActionExecuting(filterContext);
        }
    }
}