using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using DB.BLL;
using DB.Model;
using InvoiceSystem.Models;
using Tools.tools;

namespace InvoiceSystem.Controllers
{
    public class LoginRegisterController : Controller
    {
        // GET: LoginRegister
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.LoginViewModel model)
        {
            Random r = new Random();
            RefreshToken rt = new RefreshToken();
            M_TokenTable mtt = new M_TokenTable();
            M_EmployeeLogin obj = new M_EmployeeLogin();
            M_Online mol = new M_Online();
            string ErrMsg = string.Empty;
            if (B_EmployeeLogin.Login(ref obj, model.LoginTel, model.Password, ref ErrMsg) == 1)
            {
                try
                {
                    mol.PastTime = (long)DateTime.UtcNow.AddMinutes(30).Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                    mol.LastLogin = DateTime.Now;
                    mol.Admin_BL = 1;
                    mol.Token = r.NextDouble().ToString();
                    B_Online.Insert(ref mol, ref ErrMsg);
                    rt.iss = "lzfyhgm";
                    rt.exp = (long)DateTime.UtcNow.AddDays(30).Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
                    rt.iat = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds; ;
                    byte[] key = AES.Md5((rt.exp * r.NextDouble()).ToString(), AES.Md5DataType.t32);
                    byte[] IV = AES.Md5((rt.iat * r.NextDouble()).ToString(), AES.Md5DataType.t16);
                    mtt.AesIV = Encoding.UTF8.GetString(key);
                    mtt.AesKey = Encoding.UTF8.GetString(IV);
                    mtt.Exp = rt.exp;
                    mtt.User_ID = obj.ID;
                    mtt.Sign = RefreshToken.Sign(rt);
                    B_TokenTable.Insert(ref mtt, ref ErrMsg);
                    string refreshtoken = RefreshToken.CreateReftoken(rt, key, IV, obj.ID);
                    string user_agent = HttpContext.Request.Headers.Get("User-Agent");
                    string token = RefreshToken.CreateToken(obj.ID, user_agent, mol.Token);
                    UseCookie.Add("UserName", model.LoginTel, DateTime.Now.AddMinutes(30));
                    UseSession.Add("UserName", model.LoginTel);
                    UseCookie.Add("UserID", obj.ID.ToString(), DateTime.Now.AddMinutes(30));
                    UseSession.Add("UserID", obj.ID.ToString());
                    UseCookie.Add("token", token, DateTime.Now.AddMinutes(30));
                    UseSession.Add("token", token);
                    UseCookie.Add("RefreshToken", refreshtoken, DateTime.Now.AddDays(30));
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                    return View();
                }
                return Redirect("/Home/Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult RegisterRe(string username)
        {
            return Content((-1).ToString());
        }
        [HttpPost]
        public ActionResult AdminRegisterRe(string username)
        {
            return Content((-1).ToString());
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Models.RegisterViewModel model)
        {
            try
            {
                string connectionString =
                    "Data Source=WIN-0MGTRP6ACV5\\MSSQL;Initial Catalog=test;Persist Security Info=false;User ID=sa;Password=Fyh123456";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); //打开数据库
                string sql = "insert into [InvoiceSystem].[dbo].[EmployeeLogin] values" +
                             $"('{model.RegisterTel}','{model.RegisterPassword}')";
                SqlCommand cmd = new SqlCommand(sql, SqlCon);
                cmd.CommandType = CommandType.Text;
                int ret = (int)cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    return RedirectToAction("Success");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return View();
        }
        [HttpGet]
        public ActionResult AdminRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminRegister(Models.AdminRegisterViewModel model)
        {
            //try
            //{
            //    string Usertype = "管理员用户";
            //    int Admin_BL = 1;
            //    string connectionString =
            //        "Data Source=WIN-0MGTRP6ACV5\\MSSQL;Initial Catalog=test;Persist Security Info=false;User ID=sa;Password=Fyh123456";
            //    SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
            //    SqlCon.Open(); //打开数据库
            //    string sql = "insert into [test].[dbo].[admin] values" +
            //                 $"('{model.AdminTel}','{model.AdminPassword}','{Usertype}',{Admin_BL})";
            //    SqlCommand cmd = new SqlCommand(sql, SqlCon);
            //    cmd.CommandType = CommandType.Text;
            //    int ret = (int)cmd.ExecuteNonQuery();
            //    if (ret > 0)
            //    {
            //        return RedirectToAction("Success");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}
            return RedirectToAction("Success");
        }

    }
}