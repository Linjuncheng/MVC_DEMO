using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Model
{
    /// <summary>
    /// 采购记录表(表体)：Purchase_Body
    /// </summary>
    public class M_Purchase_Body
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 物料信息表ID
        /// </summary>
        public int? Material_ID { get; set; } = null;
        /// <summary>
        /// 采购记录表ID
        /// </summary>
        public int? Purchase_ID { get; set; } = null; 
        /// <summary>
        /// 采购数量
        /// </summary>
        public int? Quantity { get; set; } = null;
        /// <summary>
        /// 采购单价
        /// </summary>
        public float? UnitPrice { get; set; } = null;
        /// <summary>
        /// 采购总价
        /// </summary>
        public float? TotalPrice { get; set; } = null;
    }
}