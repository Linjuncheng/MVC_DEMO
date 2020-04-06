using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceSystem.Models
{
    /// <summary>
    /// 物料信息表
    /// </summary>
    public class Material
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
        /// 产品名称
        /// </summary>
        [Display(Name = "产品名称")]
        public string ProductName { get; set; } = null;
        /// <summary>
        /// 物料代码
        /// </summary>
        [Display(Name = "物料代码")]
        public string MaterialCode { get; set; } = null;
        /// <summary>
        /// 规格型号
        /// </summary>
        [Display(Name = "规格型号")]
        public string ProductModel { get; set; } = null;
    }
}