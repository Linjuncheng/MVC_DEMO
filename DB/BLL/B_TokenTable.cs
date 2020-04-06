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
    /// 令牌表：TokenTable
    /// </summary>
    public static class B_TokenTable
    {
        //删除多个（查ID）
        public static int Delete(List<int> ID, ref string ErrMsg)
        {
            I_TokenTable I = (D_TokenTable)SimpleFactory.CreateObject(DBType.TokenTable);
            return I.Delete(ID, ref ErrMsg);
        }
        //删除单个（查ID）
        public static int Delete(int ID, ref string ErrMsg)
        {
            I_TokenTable I = (D_TokenTable)SimpleFactory.CreateObject(DBType.TokenTable);
            return I.Delete(ID, ref ErrMsg);
        }
        //插入多个
        public static int Insert(ref List<M_TokenTable> Obj, ref string ErrMsg)
        {
            I_TokenTable I = (D_TokenTable)SimpleFactory.CreateObject(DBType.TokenTable);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //插入单个
        public static int Insert(ref M_TokenTable Obj, ref string ErrMsg)
        {
            I_TokenTable I = (D_TokenTable)SimpleFactory.CreateObject(DBType.TokenTable);
            return I.Insert(ref Obj, ref ErrMsg);
        }
        //更新多个
        public static int Update(List<M_TokenTable> Obj, ref string ErrMsg)
        {
            I_TokenTable I = (D_TokenTable)SimpleFactory.CreateObject(DBType.TokenTable);
            return I.Update(Obj, ref ErrMsg);
        }
        //更新单个（查ID）
        public static int Update(M_TokenTable Obj, ref string ErrMsg)
        {
            I_TokenTable I = (D_TokenTable)SimpleFactory.CreateObject(DBType.TokenTable);
            return I.Update(Obj, ref ErrMsg);
        }
        //查询多个（查ID）
        public static int Select(ref List<M_TokenTable> Obj, List<int> ID, ref string ErrMsg)
        {
            I_TokenTable I = (D_TokenTable)SimpleFactory.CreateObject(DBType.TokenTable);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
        //查询单个（查ID）
        public static int Select(ref M_TokenTable Obj, int ID, ref string ErrMsg)
        {
            I_TokenTable I = (D_TokenTable)SimpleFactory.CreateObject(DBType.TokenTable);
            return I.Select(ref Obj, ID, ref ErrMsg);
        }
    }//
}//