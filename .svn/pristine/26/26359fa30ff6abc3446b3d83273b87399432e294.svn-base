using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tools.tools;
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace InvoiceSystem.Models
{
    public class RefreshToken
    {
        /// <summary>
        /// 签发者
        /// </summary>
        public string iss { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public long exp { get; set; }
        /// <summary>
        /// 颁发时间
        /// </summary>
        public long iat { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int uid { get; set; }

        /// <summary>
        /// 对签发者，过期时间，签发时间，UID进行md5加密
        /// </summary>
        /// <returns></returns>
        public static string Sign(RefreshToken token)
        {
            string tmp = $"{token.iss}_{token.exp}_{token.iat}_{token.uid}";
            byte[] buffer = AES.Md5(tmp);
            return Convert.ToBase64String(buffer);
        }
        /// <summary>
        /// 传入一个RefreshToken对象转成xml
        /// </summary>
        /// <param name="obj">RefreshToken对象</param>
        /// <returns></returns>
        public static string ObjectToXml(RefreshToken obj)
        {
            MemoryStream ms; string tmpstr;
            using (ms = new MemoryStream()) {
                XmlSerializer xl = new XmlSerializer(obj.GetType());
                TextWriter sw = new StreamWriter(ms, Encoding.UTF8);
                xl.Serialize(sw, obj);
                sw.Flush();
                ms.Seek(0, SeekOrigin.Begin);
                StreamReader sr = new StreamReader(ms, Encoding.UTF8);
                tmpstr = sr.ReadToEnd();
            }
            return tmpstr;
        }
        /// <summary>
        /// xml转RefreshToken对象
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static RefreshToken XmlToObject(byte[] buffer)
        {
            RefreshToken rt = new RefreshToken();
            MemoryStream ms;
            using (ms = new MemoryStream(buffer))
            {
                ms.Seek(0, SeekOrigin.Begin);
                XmlSerializer xl = new XmlSerializer(rt.GetType());
                TextReader tr = new StreamReader(ms, Encoding.UTF8);
                rt = (RefreshToken)xl.Deserialize(tr);
            }
            return rt;
        }
        /// <summary>
        /// 创建RefToken
        /// </summary>
        /// <param name="obj">RefreshToken</param>
        /// <param name="key">key，随机生成存在数据库</param>
        /// <param name="iv">向量，随机生成</param>
        /// <param name="id">用户的id</param>
        /// <returns></returns>
        public static string CreateReftoken(RefreshToken obj,byte[] key,byte[] iv,int id)
        {
            string text = ObjectToXml(obj);
            byte[] bytes = AES.Encrypt(text, key, iv);
            string str = Convert.ToBase64String(bytes);
            bytes = AES.Md5($"{id}.{str}");
            string tmp = Convert.ToBase64String(bytes);
            return $"{id}.{str}.{tmp}";
        }
        /// <summary>
        /// 创建Token
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <param name="user_agent">浏览器的请求头</param>
        /// <param name="random">随机字符串</param>
        /// <returns></returns>
        public static string CreateToken(int id,string user_agent,string random)
        {
            string tmp = $"{id}{user_agent}{random}";
            return Convert.ToBase64String(AES.Md5(tmp));
        }
        /// <summary>
        /// 验证RefToken传输是否完整
        /// </summary>
        /// <param name="refToken">浏览器传回来的RefToken</param>
        /// <param name="key"></param>
        /// <param name="vi"></param>
        /// <param name="Obj"></param>
        /// <param name="ErrMsg"></param>
        /// <returns></returns>
        public static int AuthenticationRefToken(string refToken,byte[] key,byte[] IV,ref RefreshToken Obj, ref string ErrMsg)
        {
            string[] arr = refToken.Split('.');
            string tmpid = arr[0];
            string tmpbase = arr[1];
            string tmpmd5 = arr[2];
            string tmp = Convert.ToBase64String(AES.Md5($"{tmpid}.{tmpbase}"));
            if (tmp != tmpmd5) 
            {
                ErrMsg = "传输不完整";
                return -1;
            }
            tmp = AES.Decrypt(Convert.FromBase64String(tmpbase),key,IV);
            Obj = XmlToObject(Encoding.UTF8.GetBytes(tmp));
            return 1;
        }
    }
}