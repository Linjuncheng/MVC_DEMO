using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Model
{
    /// <summary>
    /// 发票记录表：Invoice
    /// </summary>
    public class M_Invoice
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 采购记录表ID
        /// </summary>
        public int? Purchase_ID { get; set; } = null;
        /// <summary>
        /// 开票时间
        /// </summary>
        public DateTime? InvoiceTime { get; set; } = null;
        /// <summary>
        /// 开票价格
        /// </summary>
        public float? InvoicePrice { get; set; } = null;
        /// <summary>
        /// 开票号码
        /// </summary>
        public string InvoiceNumber { get; set; } = null;
        /// <summary>
        /// 开票公司名称
        /// </summary>
        public string InvoiceCompanyName { get; set; } = null;
        /// <summary>
        /// 开户行及账号
        /// </summary>
        public string BankNumber { get; set; }
        /// <summary>
        /// 备注（纳税人识别号；地址、电话）
        /// </summary>
        public string Remark { get; set; } = null;
    }
}