﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InvoiceSystem.Models;
using Tools.tools;
using DB.BLL;
using DB.Model;
using System.Text;

namespace InvoiceSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.LoginViewModel model)
        {
            Random r = new Random();
            RefreshToken rt = new RefreshToken();
            M_TokenTable mtt = new M_TokenTable();
            M_EmployeeLogin obj = new M_EmployeeLogin();
            M_Online mol = new M_Online();
            string ErrMsg = string.Empty;
            if (B_EmployeeLogin.Login(ref obj, model.LoginTel, model.Password, ref ErrMsg) != -1)
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
                    mtt.AesIV = Convert.ToBase64String(key);
                    mtt.AesKey = Convert.ToBase64String(IV);
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
                return RedirectToAction("Index");
            }
            Response.Write(ErrMsg);
            return View();
        }
        //public ActionResult Register()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Register(Models.RegisterViewModel model)
        //{
        //    string ErrMsg = string.Empty;
        //    string UserName = model.RegisterTel;
        //    string Password = model.RegisterPassword;
        //    try
        //    {
        //        M_EmployeeLogin mel = new M_EmployeeLogin();
        //        mel.Username = UserName;
        //        mel.Password = Convert.ToBase64String(AES.Md5(Password));
        //        B_EmployeeLogin.Insert(ref mel, ref ErrMsg);
        //        return RedirectToAction("Success");
        //    }catch(Exception ex)
        //    {
        //        Response.Write(ex.Message);
        //        return View();
        //    }
        //}


        public ActionResult Success()
        {
            return View();
        }
        //public ActionResult CreateReToken()
        //{
        //    RefreshToken rt = new RefreshToken();
        //    Random r = new Random();
        //    rt.iss = "lzfyhgm";
        //    rt.exp = (long)DateTime.UtcNow.AddDays(30).Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        //    rt.iat = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds; ;
        //    rt.uid = "123";
        //    string str = RefreshToken.Sign(rt);
        //    byte[] key = AES.Md5((rt.exp * r.NextDouble()).ToString());
        //    byte[] IV = AES.Md5((rt.iat * r.NextDouble()).ToString());
        //    int id = 123;
        //    string tmp = RefreshToken.CreateReftoken(rt, key, IV, id);
        //    return Content(tmp);
        //}
        //public ActionResult AuthenticationToken()
        //{
        //    RefreshToken rt = new RefreshToken();
        //    RefreshToken rt1 = new RefreshToken();
        //    Random r = new Random();
        //    rt.iss = "lzfyhgm";
        //    rt.exp = (long)DateTime.UtcNow.AddDays(30).Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        //    rt.iat = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds; ;
        //    rt.uid = "123";
        //    string str = RefreshToken.Sign(rt);
        //    byte[] key = AES.Md5((rt.exp * r.NextDouble()).ToString());
        //    byte[] IV = AES.Md5((rt.iat * r.NextDouble()).ToString());
        //    int id = 123;
        //    string tmp = RefreshToken.CreateReftoken(rt, key, IV, id);
        //    string errMsg = string.Empty;
        //    int i = RefreshToken.AuthenticationRefToken(tmp, key, IV, ref rt1, ref errMsg);
        //    return Content(rt1.iss + rt1.exp.ToString() + rt1.iat.ToString() + rt1.uid);
        //}
    }
}