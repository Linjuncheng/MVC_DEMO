using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tools.tools
{
    public class UseCookie
    {
        /// <summary>
        /// 添加一个Cookie
        /// </summary>
        /// <param name="cookiename">Cookie对象名称</param>
        /// <param name="cookievalue">Cookie值</param>
        /// <param name="exprie">过期时间</param>
        public static void Add(string cookieName, string cookieValue,DateTime exprie)
        {
            HttpCookie cookie = new HttpCookie(cookieName)
            {
                Value = cookieValue,
                Expires = exprie
            };
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
        /// <summary>
        /// 获取Cookie值
        /// </summary>
        /// <param name="cookieName">需要获取的Cookie的名称</param>
        /// <returns>返回对应Cookie的值</returns>
        public static string Get(string cookieName)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];
            string str = string.Empty;
            if (!(cookie is null)) str = cookie.Value;
            return str;
        }
        /// <summary>
        /// 清空Cookie
        /// </summary>
        /// <param name="cookieName">需要删除的Cookie名称</param>
        public static void Remove(string cookieName)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];
            cookie.Expires = DateTime.Now.AddDays(-1);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}