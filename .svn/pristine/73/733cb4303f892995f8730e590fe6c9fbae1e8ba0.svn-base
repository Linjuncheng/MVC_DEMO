using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tools.tools
{
    public class UseSession
    {
        /// <summary>
        /// 添加Session,有效期为默认
        /// </summary>
        /// <param name="SessionName">Session对象名称</param>
        /// <param name="obj">Session的值</param>
        public static void Add(string sessionName,object obj)
        {
            HttpContext.Current.Session[sessionName] = obj;
        }
        /// <summary>
        /// 添加Session，有效期为minute
        /// </summary>
        /// <param name="Session">Session对象名称</param>
        /// <param name="obj">Session值</param>
        /// <param name="Minute">Session过期时间</param>
        public static void Add(string sessionName,object obj,int minute) {
            HttpContext.Current.Session[sessionName] = obj;
            HttpContext.Current.Session.Timeout = minute;
        }
        /// <summary>
        /// 获取Session
        /// </summary>
        /// <param name="SessionName">需要获取的Session对象名称</param>
        /// <returns>返回Session对象</returns>
        public static object Get(string SessionName)
        {
            return HttpContext.Current.Session[SessionName];
        }
        /// <summary>
        /// 删除Session
        /// </summary>
        /// <param name="SessionName">需要删除的Session对象名称</param>
        public static void Remove(string SessionName)
        {
            HttpContext.Current.Session.Remove(SessionName);
        }
    }
}