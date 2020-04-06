using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceSystem.Models
{
    /// <summary>
    /// 采购记录表
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// 主键
        /// </summary>
        [HiddenInput]
        public int ID { get; set; }
        /// <summary>
        /// 采购员ID
        /// </summary>
        [Display(Name = "采购员ID")]
        public int? Agent_ID { get; set; } = null;
        /// <summary>
        /// 审批流字段（为0不通过）
        /// </summary>
        [Display(Name = "审批流字段（为0不通过，为1通过）")]
        public int? Audit_BL { get; set; } = null;
        /// <summary>
        /// 单据编号
        /// </summary>
        [Display(Name = "单据编号")]
        public string DocumentNumber { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        [Display(Name = "公司名称")]
        [Required(ErrorMessage = "该项不能为空")]
        public string CompanyName { get; set; } = null;
        /// <summary>
        /// 采购日期
        /// </summary>
        [Display(Name = "采购日期")]
        public DateTime? PurchaseDate { get; set; } = null;
        /// <summary>
        /// 状态(1未开票、2部分开票、3完结)
        /// </summary>
        [Display(Name = "状态(1未开票、2部分开票、3完结)")]
        public int? Status { get; set; } = null;
        /// <summary>
        /// 已开票价格
        /// </summary>
        [Display(Name = "已开票价格")]
        public float? InvoicePrice { get; set; } = null;
        /// <summary>
        /// 未开票价格
        /// </summary>
        [Display(Name = "未开票价格")]
        public float? UnInvoicePrice { get; set; } = null;
        /// <summary>
        /// 采购总价
        /// </summary>
        [Display(Name = "采购总价")]
        public float? TotalPrice { get; set; } = null;
    }
}