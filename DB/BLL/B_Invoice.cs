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
    /// 发票记录表：Invoice
    /// </summary>
    public static class B_Invoice
    {
        //删除多个（查ID）
        public static int Delete(List<int> ID, ref string ErrMsg)
        {
            I_Invoice I = (D_Invoice)SimpleFactory.CreateObject(DBType.Invoice);
            return I.Delete(ID, ref ErrMsg);
        }
        //删除单个（查ID）
        public static int Delete(int ID, ref string ErrMsg)
        {
            I_Invoice I = (D_Invoice)SimpleFactory.CreateObject(DBType.Invoice);
            return I.Delete(ID, ref ErrMsg);
        }
        //插入多个
        public static int Insert(ref List<M_Invoice> Obj, ref string ErrMsg)
        {
            I_Invoice I = (D_Invoice)SimpleFactory.CreateObject(DBType.Invoice);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //插入单个
        public static int Insert(ref M_Invoice Obj, ref string ErrMsg)
        {
            I_Invoice I = (D_Invoice)SimpleFactory.CreateObject(DBType.Invoice);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //更新多个
        public static int Update(List<M_Invoice> Obj, ref string ErrMsg)
        {
            I_Invoice I = (D_Invoice)SimpleFactory.CreateObject(DBType.Invoice);
            return I.Update(Obj, ref ErrMsg);
        }
        //更新单个（查ID）
        public static int Update(M_Invoice Obj, ref string ErrMsg)
        {
            I_Invoice I = (D_Invoice)SimpleFactory.CreateObject(DBType.Invoice);
            return I.Update(Obj, ref ErrMsg);
        }
        //查询多个（查ID）
        public static int Select(ref List<M_Invoice> Obj, List<int> ID, ref string ErrMsg)
        {
            I_Invoice I = (D_Invoice)SimpleFactory.CreateObject(DBType.Invoice);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
        //查询单个（查ID）
        public static int Select(ref M_Invoice Obj, int ID, ref string ErrMsg)
        {
            I_Invoice I = (D_Invoice)SimpleFactory.CreateObject(DBType.Invoice);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
        //分页
        public static int TurnPage(ref List<M_Invoice> Obj, int Page, int PageSize, ref string ErrMsg)
        {
            I_Invoice I = (D_Invoice)SimpleFactory.CreateObject(DBType.Invoice);
            return I.TurnPage(ref Obj, Page, PageSize, ref ErrMsg);
        }
    }//
}//