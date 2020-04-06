using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DB.Model
{
    /// <summary>
    /// 令牌表：TokenTable
    /// </summary>
    public class M_TokenTable
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
        /// 随机字符
        /// </summary>
        public string Token { get; set; } = null;
        /// <summary>
        /// 设备编号    
        /// </summary>
        public Int16? MType { get; set; } = null;
        /// <summary>
        /// 过期时间
        /// </summary>
        public long? Exp { get; set; } = null;
        /// <summary>
        /// 密匙
        /// </summary>
        public string AesKey { get; set; } = null;
        /// <summary>
        /// 向量
        /// </summary>
        public string AesIV { get; set; } = null;
        /// <summary>
        /// 校验
        /// </summary>
        public string Sign { get; set; } = null;
    }
}