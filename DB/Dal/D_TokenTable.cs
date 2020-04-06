using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DB.Model;
using DB.IDal;
using System.Data.SqlClient;
using System.Data;

namespace DB.Dal
{
    /// <summary>
    /// 令牌表：TokenTable
    /// </summary>
    public class D_TokenTable : SqlBase, I_TokenTable
    {
        //数据库表名
        private string TableName { get; set; } = "TokenTable";

        //删除多个（查ID）
        public int Delete(List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"delete from {TableName} where ID = @ID", conn);
                SqlParameter par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);
                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (int m in ID)
                    {
                        cmd.Parameters["@ID"].Value = m;
                        if (cmd.ExecuteNonQuery() > 0) { tmpOut++; }
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
                if (ID.Count() == tmpOut)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        //删除单个（查ID）
        public int Delete(int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"delete from {TableName} where ID = {ID}", conn);
                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
        //插入多个
        public int Insert(ref List<M_TokenTable> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (User_ID,Token,MType,Exp,AesKey,AesIV,Sign) values (@User_ID,@Token,@MType,@Exp,@AesKey,@AesIV,@Sign);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Token", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@MType", SqlDbType.SmallInt);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Exp", SqlDbType.BigInt);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AesKey", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AesIV", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Sign", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_TokenTable m in Obj)
                    {
                        cmd.Parameters["@User_ID"].Value = m.User_ID;
                        if (m.Token == null) { cmd.Parameters["@Token"].Value = DBNull.Value; } else { cmd.Parameters["@Token"].Value = m.Token; }
                        if (m.MType == null) { cmd.Parameters["@MType"].Value = DBNull.Value; } else { cmd.Parameters["@MType"].Value = m.MType; }
                        cmd.Parameters["@Exp"].Value = m.Exp;
                        cmd.Parameters["@AesKey"].Value = m.AesKey;
                        cmd.Parameters["@AesIV"].Value = m.AesIV;
                        cmd.Parameters["@Sign"].Value = m.Sign;
                        decimal d = (decimal)cmd.ExecuteScalar();
                        m.ID = (int)d;
                        if (m.ID > 0) { tmpOut++; }
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
                if (Obj.Count() == tmpOut)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        //插入单个
        public int Insert(ref M_TokenTable Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (User_ID,Token,MType,Exp,AesKey,AesIV,Sign) values (@User_ID,@Token,@MType,@Exp,@AesKey,@AesIV,@Sign);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                par.Value = Obj.User_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Token", SqlDbType.Char, 50);
                if (Obj.Token == null) { par.Value = DBNull.Value; } else { par.Value = Obj.Token; }
                cmd.Parameters.Add(par);

                par = new SqlParameter("@MType", SqlDbType.SmallInt);
                if (Obj.MType == null) { par.Value = DBNull.Value; } else { par.Value = Obj.MType; }
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Exp", SqlDbType.BigInt);
                par.Value = Obj.Exp;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AesKey", SqlDbType.Char, 50);
                par.Value = Obj.AesKey;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AesIV", SqlDbType.Char, 50);
                par.Value = Obj.AesIV;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Sign", SqlDbType.Char, 50);
                par.Value = Obj.Sign;
                cmd.Parameters.Add(par);

                try
                {
                    conn.Open();
                    decimal d = (decimal)cmd.ExecuteScalar();
                    Obj.ID = (int)d;
                    if (Obj.ID > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
        //更新多个
        public int Update(List<M_TokenTable> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set User_ID = @User_ID, Token = @Token, MType = @MType, Exp = @Exp, AesKey = @AesKey, AesIV = @AesIV, Sign = @Sign where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Token", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@MType", SqlDbType.SmallInt);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Exp", SqlDbType.BigInt);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AesKey", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AesIV", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Sign", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_TokenTable m in Obj)
                    {
                        cmd.Parameters["@User_ID"].Value = m.User_ID;
                        if (m.Token == null) { cmd.Parameters["@Token"].Value = DBNull.Value; } else { cmd.Parameters["@Token"].Value = m.Token; }
                        if (m.MType == null) { cmd.Parameters["@MType"].Value = DBNull.Value; } else { cmd.Parameters["@MType"].Value = m.MType; }
                        cmd.Parameters["@Exp"].Value = m.Exp;
                        cmd.Parameters["@AesKey"].Value = m.AesKey;
                        cmd.Parameters["@AesIV"].Value = m.AesIV;
                        cmd.Parameters["@Sign"].Value = m.Sign;
                        cmd.Parameters["@ID"].Value = m.ID;
                        if (cmd.ExecuteNonQuery() > 0) { tmpOut++; }
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
                if (Obj.Count() == tmpOut)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        //更新单个（查ID）
        public int Update(M_TokenTable Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set User_ID = @User_ID, Token = @Token, MType = @MType, Exp = @Exp, AesKey = @AesKey, AesIV = @AesIV, Sign = @Sign where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                par.Value = Obj.User_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Token", SqlDbType.Char, 50);
                if (Obj.Token == null) { par.Value = DBNull.Value; } else { par.Value = Obj.Token; }
                cmd.Parameters.Add(par);

                par = new SqlParameter("@MType", SqlDbType.SmallInt);
                if (Obj.MType == null) { par.Value = DBNull.Value; } else { par.Value = Obj.MType; }
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Exp", SqlDbType.BigInt);
                par.Value = Obj.Exp;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AesKey", SqlDbType.Char, 50);
                par.Value = Obj.AesKey;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@AesIV", SqlDbType.Char, 50);
                par.Value = Obj.AesIV;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Sign", SqlDbType.Char, 50);
                par.Value = Obj.Sign;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                par.Value = Obj.ID;
                cmd.Parameters.Add(par);

                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
        //查询多个（查ID）
        public int Select(ref List<M_TokenTable> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,User_ID,Token,MType,Exp,AesKey,AesIV,Sign from {TableName} where ID = @ID", conn);
                SqlDataReader sdr;
                SqlParameter par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (int i in ID)
                    {
                        cmd.Parameters["@ID"].Value = i;
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            M_TokenTable TmpObj = new M_TokenTable();
                            TmpObj.ID = (int)sdr["ID"];
                            TmpObj.AesIV = (string)sdr["AesIV"];
                            TmpObj.AesKey = (string)sdr["AesKey"];
                            TmpObj.Exp = (long)sdr["Exp"];
                            if (sdr["MType"] == DBNull.Value) { TmpObj.MType = null; } else { TmpObj.MType = (Int16)sdr["MType"]; }
                            TmpObj.Sign = (string)sdr["Sign"];
                            if (sdr["Token"] == DBNull.Value) { TmpObj.Token = string.Empty; } else { TmpObj.Token = (string)sdr["Token"]; }
                            TmpObj.User_ID = (int)sdr["User_ID"];
                            Obj.Add(TmpObj);
                            tmpOut++;
                        }
                        sdr.Close();
                    }
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
                if (ID.Count() == tmpOut)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        //查询单个（查ID）
        public int Select(ref M_TokenTable Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,User_ID,Token,MType,Exp,AesKey,AesIV,Sign from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.AesIV = (string)sdr["AesIV"];
                        Obj.AesKey = (string)sdr["AesKey"];
                        Obj.Exp = (long)sdr["Exp"];
                        if (sdr["MType"] == DBNull.Value) { Obj.MType = null; } else { Obj.MType = (Int16)sdr["MType"]; }
                        Obj.Sign = (string)sdr["Sign"];
                        if (sdr["Token"] == DBNull.Value) { Obj.Token = string.Empty; } else { Obj.Token = (string)sdr["Token"]; }
                        Obj.User_ID = (int)sdr["User_ID"];
                        return 1;
                    }
                    return -1;
                }
                catch (Exception ex)
                {
                    ErrMsg = ex.Message;
                    return -1;
                }
                finally
                {
                    cmd.Dispose();
                }
            }
        }
    }//
}//