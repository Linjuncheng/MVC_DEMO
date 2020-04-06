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
    /// 供应商信息表：Supplier
    /// </summary>
    public static class B_Supplier
    {
        //删除多个（查ID）
        public static int Delete(List<int> ID, ref string ErrMsg)
        {
            I_Supplier I = (D_Supplier)SimpleFactory.CreateObject(DBType.Supplier);
            return I.Delete(ID, ref ErrMsg);
        }
        //删除单个（查ID）
        public static int Delete(int ID, ref string ErrMsg)
        {
            I_Supplier I = (D_Supplier)SimpleFactory.CreateObject(DBType.Supplier);
            return I.Delete(ID, ref ErrMsg);
        }
        //插入多个
        public static int Insert(ref List<M_Supplier> Obj, ref string ErrMsg)
        {
            I_Supplier I = (D_Supplier)SimpleFactory.CreateObject(DBType.Supplier);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //插入单个
        public static int Insert(ref M_Supplier Obj, ref string ErrMsg)
        {
            I_Supplier I = (D_Supplier)SimpleFactory.CreateObject(DBType.Supplier);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //更新多个
        public static int Update(List<M_Supplier> Obj, ref string ErrMsg)
        {
            I_Supplier I = (D_Supplier)SimpleFactory.CreateObject(DBType.Supplier);
            return I.Update(Obj, ref ErrMsg);
        }
        //更新单个（查ID）
        public static int Update(M_Supplier Obj, ref string ErrMsg)
        {
            I_Supplier I = (D_Supplier)SimpleFactory.CreateObject(DBType.Supplier);
            return I.Update(Obj, ref ErrMsg);
        }
        //查询多个（查ID）
        public static int Select(ref List<M_Supplier> Obj, List<int> ID, ref string ErrMsg)
        {
            I_Supplier I = (D_Supplier)SimpleFactory.CreateObject(DBType.Supplier);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
        //查询单个（查ID）
        public static int Select(ref M_Supplier Obj, int ID, ref string ErrMsg)
        {
            I_Supplier I = (D_Supplier)SimpleFactory.CreateObject(DBType.Supplier);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
    }//
}//