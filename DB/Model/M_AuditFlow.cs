using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Model
{
    /// <summary>
    /// 审批流表：AuditFlow
    /// </summary>
    public class M_AuditFlow
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int User_ID { get; set; }
        /// <summary>
        /// 单据ID
        /// </summary>
        public int? Document_ID { get; set; } = null;
        /// <summary>
        /// 单据类型
        /// </summary>
        public string DocumentType { get; set; } = null;
    }
}