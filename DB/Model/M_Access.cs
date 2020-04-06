using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Model
{
    /// <summary>
    /// 权限表：Access
    /// </summary>
    public class M_Access
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int? User_ID { get; set; } = null;
        /// <summary>
        /// 用户类型
        /// </summary>
        public int? User_Type { get; set; } = null;
        /// <summary>
        /// 权限
        /// </summary>
        public int? Access_BL { get; set; } = null;
        /// <summary>
        /// 权限名称
        /// </summary>
        public string Access_Name { get; set; } = null;
    }
}