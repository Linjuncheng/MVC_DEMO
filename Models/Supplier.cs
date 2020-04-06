using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceSystem.Models
{
     /// <summary>
    /// 供应商信息表
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// 主键
        /// </summary>
        [HiddenInput]
        public int ID { get; set; }
        /// <summary>
        /// 禁用
        /// </summary>
        [HiddenInput]
        public int? Disable_BL { get; set; } = null;
        /// <summary>
        /// 供应商名称
        /// </summary>
        [Display(Name = "供应商名称")]
        public string SupplierName { get; set; } = null;
        /// <summary>
        /// 供应商编号
        /// </summary>
        [Display(Name = "供应商编号")]
        public string SupplierNumber { get; set; } = null;
        /// <summary>
        /// 开票截止时间
        /// </summary>
        [Display(Name = "开票截止时间")]
        public long? DeadLine { get; set; } = null;
        
    }
}