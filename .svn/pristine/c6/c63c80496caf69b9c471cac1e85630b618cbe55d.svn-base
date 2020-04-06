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
    /// 员工登录表：EmployeeLogin
    /// </summary>
    public static class B_EmployeeLogin
    {
        //员工登录
        public static int Login(ref M_EmployeeLogin Obj, string username, string password, ref string ErrMsg)
        {
            I_EmployeeLogin I = (D_EmployeeLogin)SimpleFactory.CreateObject(DBType.EmployeeLogin);
            return I.Login(ref Obj, username, password, ref ErrMsg);
        }
        //删除多个（查ID）
        public static int Delete(List<int> ID, ref string ErrMsg)
        {
            I_EmployeeLogin I = (D_EmployeeLogin)SimpleFactory.CreateObject(DBType.EmployeeLogin);
            return I.Delete(ID, ref ErrMsg);
        }
        //删除单个（查ID）
        public static int Delete(int ID, ref string ErrMsg)
        {
            I_EmployeeLogin I = (D_EmployeeLogin)SimpleFactory.CreateObject(DBType.EmployeeLogin);
            return I.Delete(ID, ref ErrMsg);
        }
        //插入多个
        public static int Insert(ref List<M_EmployeeLogin> Obj, ref string ErrMsg)
        {
            I_EmployeeLogin I = (D_EmployeeLogin)SimpleFactory.CreateObject(DBType.EmployeeLogin);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //插入单个
        public static int Insert(ref M_EmployeeLogin Obj, ref string ErrMsg)
        {
            I_EmployeeLogin I = (D_EmployeeLogin)SimpleFactory.CreateObject(DBType.EmployeeLogin);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //更新多个
        public static int Update(List<M_EmployeeLogin> Obj, ref string ErrMsg)
        {
            I_EmployeeLogin I = (D_EmployeeLogin)SimpleFactory.CreateObject(DBType.EmployeeLogin);
            return I.Update(Obj, ref ErrMsg);
        }
        //更新单个（查ID）
        public static int Update(M_EmployeeLogin Obj, ref string ErrMsg)
        {
            I_EmployeeLogin I = (D_EmployeeLogin)SimpleFactory.CreateObject(DBType.EmployeeLogin);
            return I.Update(Obj, ref ErrMsg);
        }
        //查询多个（查ID）
        public static int Select(ref List<M_EmployeeLogin> Obj, List<int> ID, ref string ErrMsg)
        {
            I_EmployeeLogin I = (D_EmployeeLogin)SimpleFactory.CreateObject(DBType.EmployeeLogin);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
        //查询单个（查ID）
        public static int Select(ref M_EmployeeLogin Obj, int ID, ref string ErrMsg)
        {
            I_EmployeeLogin I = (D_EmployeeLogin)SimpleFactory.CreateObject(DBType.EmployeeLogin);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
        //分页
        public static int TurnPage(ref List<M_EmployeeLogin> Obj, int Page, int PageSize, ref string ErrMsg)
        {
            I_EmployeeLogin I = (D_EmployeeLogin)SimpleFactory.CreateObject(DBType.EmployeeLogin);
            return I.TurnPage(ref Obj, Page, PageSize, ref ErrMsg);
        }
    }//
}//