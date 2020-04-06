using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Model
{
    /// <summary>
    /// 采购记录表：Purchase
    /// </summary>
    public class M_Purchase
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 采购员ID
        /// </summary>
        public int? Agent_ID { get; set; } = null;
        /// <summary>
        /// 审批流字段（为0不通过）
        /// </summary>
        public int? Audit_BL { get; set; } = null;
        /// <summary>
        /// 单据编号
        /// </summary>
        public string DocumentNumber { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; } = null;
        /// <summary>
        /// 采购日期
        /// </summary>
        public DateTime? PurchaseDate { get; set; } = null;
        /// <summary>
        /// 状态(1未开票、2部分开票、3完结)
        /// </summary>
        public int? Status { get; set; } = null;
        /// <summary>
        /// 已开票价格
        /// </summary>
        public float? InvoicePrice { get; set; } = null;
        /// <summary>
        /// 未开票价格
        /// </summary>
        public float? UnInvoicePrice { get; set; } = null;
        /// <summary>
        /// 采购总价
        /// </summary>
        public float? TotalPrice { get; set; } = null;
    }
}