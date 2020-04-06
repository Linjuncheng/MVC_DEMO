using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Model;
using DB.IDal;
using DB.Dal;
using DB.SF;

namespace DB.BLL
{
    /// <summary>
    /// 管理员登录表：AdminLogin
    /// </summary>
    public static class B_AdminLogin
    {
        //管理员登录
        public static int Login(ref M_AdminLogin Obj, string username, string password, ref string ErrMsg)
        {
            I_AdminLogin I = (D_AdminLogin)SimpleFactory.CreateObject(DBType.AdminLogin);
            return I.Login(ref Obj, username, password, ref ErrMsg);
        }
        //删除多个（查ID）
        public static int Delete(List<int> ID, ref string ErrMsg)
        {
            I_AdminLogin I = (D_AdminLogin)SimpleFactory.CreateObject(DBType.AdminLogin);
            return I.Delete(ID, ref ErrMsg);
        }
        //删除单个（查ID）
        public static int Delete(int ID, ref string ErrMsg)
        {
            I_AdminLogin I = (D_AdminLogin)SimpleFactory.CreateObject(DBType.AdminLogin);
            return I.Delete(ID, ref ErrMsg);
        }
        //插入多个
        public static int Insert(ref List<M_AdminLogin> Obj, ref string ErrMsg)
        {
            I_AdminLogin I = (D_AdminLogin)SimpleFactory.CreateObject(DBType.AdminLogin);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //插入单个
        public static int Insert(ref M_AdminLogin Obj, ref string ErrMsg)
        {
            I_AdminLogin I = (D_AdminLogin)SimpleFactory.CreateObject(DBType.AdminLogin);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //更新多个
        public static int Update(List<M_AdminLogin> Obj, ref string ErrMsg)
        {
            I_AdminLogin I = (D_AdminLogin)SimpleFactory.CreateObject(DBType.AdminLogin);
            return I.Update(Obj, ref ErrMsg);
        }
        //更新单个（查ID）
        public static int Update(M_AdminLogin Obj, ref string ErrMsg)
        {
            I_AdminLogin I = (D_AdminLogin)SimpleFactory.CreateObject(DBType.AdminLogin);
            return I.Update(Obj, ref ErrMsg);
        }
        //查询多个（查ID）
        public static int Select(ref List<M_AdminLogin> Obj, List<int> ID, ref string ErrMsg)
        {
            I_AdminLogin I = (D_AdminLogin)SimpleFactory.CreateObject(DBType.AdminLogin);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
        //查询单个（查ID）
        public static int Select(ref M_AdminLogin Obj, int ID, ref string ErrMsg)
        {
            I_AdminLogin I = (D_AdminLogin)SimpleFactory.CreateObject(DBType.AdminLogin);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
    }//
}//