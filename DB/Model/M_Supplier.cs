using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Model
{
    /// <summary>
    /// 供应商信息表：Supplier
    /// </summary>
    public class M_Supplier
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 禁用
        /// </summary>
        public int? Disable_BL { get; set; } = null;
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string SupplierName { get; set; } = null;
        /// <summary>
        /// 供应商编号
        /// </summary>
        public string SupplierNumber { get; set; } = null;
        /// <summary>
        /// 开票截止时间
        /// </summary>
        public long? DeadLine { get; set; } = null;
        
    }
}