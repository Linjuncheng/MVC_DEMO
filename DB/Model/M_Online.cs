using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Model
{
    /// <summary>
    /// 在线表：Online
    /// </summary>
    public class M_Online
    {
        /// <summary>
        /// 在线表ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 管理员ID
        /// </summary>
        public int? Admin_ID { get; set; } = null;
        /// <summary>
        /// 用户ID
        /// </summary>
        public int User_ID { get; set; }
        /// <summary>
        /// 是否是管理员
        /// </summary>
        public int? Admin_BL { get; set; } = null;
        /// <summary>
        /// 令牌
        /// </summary>
        public string Token { get; set; } = null;
        /// <summary>
        /// 过期时间
        /// </summary>
        public long? PastTime { get; set; } = null;
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime? LastLogin { get; set; } = null;
    }
}