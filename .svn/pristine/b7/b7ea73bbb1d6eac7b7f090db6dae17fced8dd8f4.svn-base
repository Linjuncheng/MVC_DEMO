using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceSystem.Models
{
    /// <summary>
    /// 发票记录表：Invoice
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// 主键
        /// </summary>
        [HiddenInput]
        public int ID { get; set; }
        /// <summary>
        /// 采购记录表ID
        /// </summary>
        [HiddenInput]
        public int? Purchase_ID { get; set; } = null;
        /// <summary>
        /// 开票时间
        /// </summary>
        [Display(Name = "开票时间")]
        public DateTime? InvoiceTime { get; set; } = null;
        /// <summary>
        /// 开票价格
        /// </summary>
        [Display(Name = "开票价格")]
        public float? InvoicePrice { get; set; } = null;
        /// <summary>
        /// 开票号码
        /// </summary>
        [Display(Name = "开票号码")]
        public string InvoiceNumber { get; set; } = null;
        /// <summary>
        /// 开票公司名称
        /// </summary>
        [Display(Name = "开票公司名称")]
        public string InvoiceCompanyName { get; set; } = null;
        /// <summary>
        /// 开户行及账号
        /// </summary>
        [Display(Name = "开户行及账号")]
        public string BankNumber { get; set; }
        /// <summary>
        /// 备注（纳税人识别号；地址、电话）
        /// </summary>
        [Display(Name = "备注 (纳税人识别号；地址、电话)")]
        public string Remark { get; set; } = null;
    }
}