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
    /// 在线表：Online
    /// </summary>
    public static class B_Online
    {
        //删除多个（查ID）
        public static int Delete(List<int> ID, ref string ErrMsg)
        {
            I_Online I = (D_Online)SimpleFactory.CreateObject(DBType.Online);
            return I.Delete(ID, ref ErrMsg);
        }
        //删除单个（查ID）
        public static int Delete(int ID, ref string ErrMsg)
        {
            I_Online I = (D_Online)SimpleFactory.CreateObject(DBType.Online);
            return I.Delete(ID, ref ErrMsg);
        }
        //插入多个
        public static int Insert(ref List<M_Online> Obj, ref string ErrMsg)
        {
            I_Online I = (D_Online)SimpleFactory.CreateObject(DBType.Online);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //插入单个
        public static int Insert(ref M_Online Obj, ref string ErrMsg)
        {
            I_Online I = (D_Online)SimpleFactory.CreateObject(DBType.Online);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //更新多个
        public static int Update(List<M_Online> Obj, ref string ErrMsg)
        {
            I_Online I = (D_Online)SimpleFactory.CreateObject(DBType.Online);
            return I.Update(Obj, ref ErrMsg);
        }
        //更新单个（查ID）
        public static int Update(M_Online Obj, ref string ErrMsg)
        {
            I_Online I = (D_Online)SimpleFactory.CreateObject(DBType.Online);
            return I.Update(Obj, ref ErrMsg);
        }
        //查询多个（查ID）
        public static int Select(ref List<M_Online> Obj, List<int> ID, ref string ErrMsg)
        {
            I_Online I = (D_Online)SimpleFactory.CreateObject(DBType.Online);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
        //查询单个（查ID）
        public static int Select(ref M_Online Obj, int ID, ref string ErrMsg)
        {
            I_Online I = (D_Online)SimpleFactory.CreateObject(DBType.Online);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
    }//
}//