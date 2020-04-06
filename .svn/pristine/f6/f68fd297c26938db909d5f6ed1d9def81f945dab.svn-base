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
    /// 在线表：Online
    /// </summary>
    public class D_Online : SqlBase, I_Online
    {
        //数据库表名
        private string TableName { get; set; } = "Online";

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
        public int Insert(ref List<M_Online> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (User_ID,Admin_ID,Admin_BL,Token,LastLogin,PastTime) values (@User_ID,@Admin_ID,@Admin_BL,@Token,@LastLogin,@PastTime);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Admin_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Admin_BL", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Token", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@LastLogin", SqlDbType.DateTime);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@PastTime", SqlDbType.BigInt);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Online m in Obj)
                    {
                        cmd.Parameters["@User_ID"].Value = m.User_ID;
                        if (m.Admin_ID == null) { cmd.Parameters["@Admin_ID"].Value = DBNull.Value; } else { cmd.Parameters["@Admin_ID"].Value = m.Admin_ID; }
                        cmd.Parameters["@Admin_BL"].Value = m.Admin_BL;
                        if (m.Token == null) { cmd.Parameters["@Token"].Value = DBNull.Value; } else { cmd.Parameters["@Token"].Value = m.Token; }
                        cmd.Parameters["@LastLogin"].Value = m.LastLogin;
                        cmd.Parameters["@PastTime"].Value = m.PastTime;
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
        public int Insert(ref M_Online Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (User_ID,Admin_ID,Admin_BL,Token,LastLogin,PastTime) values (@User_ID,@Admin_ID,@Admin_BL,@Token,@LastLogin,@PastTime);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                par.Value = Obj.User_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Admin_ID", SqlDbType.Int);
                if (Obj.Admin_ID == null) { par.Value = DBNull.Value; } else { par.Value = Obj.Admin_ID; }
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Admin_BL", SqlDbType.Int);
                par.Value = Obj.Admin_BL;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Token", SqlDbType.Char, 50);
                if (Obj.Token == null) { par.Value = DBNull.Value; } else { par.Value = Obj.Token; }
                cmd.Parameters.Add(par);

                par = new SqlParameter("@LastLogin", SqlDbType.DateTime);
                par.Value = Obj.LastLogin;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@PastTime", SqlDbType.BigInt);
                par.Value = Obj.PastTime;
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
        public int Update(List<M_Online> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set User_ID = @User_ID, Admin_ID = @Admin_ID, Admin_BL = @Admin_BL, Token = @Token, LastLogin = @LastLogin, PastTime = @PastTime where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Admin_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Admin_BL", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Token", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@LastLogin", SqlDbType.DateTime);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@PastTime", SqlDbType.BigInt);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Online m in Obj)
                    {
                        cmd.Parameters["@User_ID"].Value = m.User_ID;
                        if (m.Admin_ID == null) { cmd.Parameters["@Admin_ID"].Value = DBNull.Value; } else { cmd.Parameters["@Admin_ID"].Value = m.Admin_ID; }
                        cmd.Parameters["@Admin_BL"].Value = m.Admin_BL;
                        if (m.Token == null) { cmd.Parameters["@Token"].Value = DBNull.Value; } else { cmd.Parameters["@Token"].Value = m.Token; }
                        cmd.Parameters["@LastLogin"].Value = m.LastLogin;
                        cmd.Parameters["@PastTime"].Value = m.PastTime;
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
        public int Update(M_Online Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set User_ID = @User_ID, Admin_ID = @Admin_ID, Admin_BL = @Admin_BL, Token = @Token, LastLogin = @LastLogin, PastTime = @PastTime where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                par.Value = Obj.User_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Admin_ID", SqlDbType.Int);
                if (Obj.Admin_ID == null) { par.Value = DBNull.Value; } else { par.Value = Obj.Admin_ID; }
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Admin_BL", SqlDbType.Int);
                par.Value = Obj.Admin_BL;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Token", SqlDbType.Char, 50);
                if (Obj.Token == null) { par.Value = DBNull.Value; } else { par.Value = Obj.Token; }
                cmd.Parameters.Add(par);

                par = new SqlParameter("@LastLogin", SqlDbType.DateTime);
                par.Value = Obj.LastLogin;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@PastTime", SqlDbType.BigInt);
                par.Value = Obj.PastTime;
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
        public int Select(ref List<M_Online> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,User_ID,Admin_ID,Admin_BL,Token,LastLogin,PastTime from {TableName} where ID = @ID", conn);
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
                        foreach (M_Online m in Obj)
                        {
                            while (sdr.Read())
                            {
                                m.ID = (int)sdr["ID"];
                                m.Admin_BL = (int)sdr["Admin_BL"];
                                if (sdr["Admin_ID"] == null) { m.Admin_ID = null; } else { m.Admin_ID = (int)sdr["Admin_ID"]; }
                                m.LastLogin = (DateTime)sdr["LastLogin"];
                                m.PastTime = (long)sdr["PastTime"];
                                if (sdr["Token"] == null) { m.Token = null; } else { m.Token = (string)sdr["Token"]; }
                                m.User_ID = (int)sdr["User_ID"];
                                tmpOut++;
                            }
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
        public int Select(ref M_Online Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,User_ID,Admin_ID,Admin_BL,Token,LastLogin,PastTime from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.Admin_BL = (int)sdr["Admin_BL"];
                        if (sdr["Admin_ID"] == null) { Obj.Admin_ID = null; } else { Obj.Admin_ID = (int)sdr["Admin_ID"]; }
                        Obj.LastLogin = (DateTime)sdr["LastLogin"];
                        Obj.PastTime = (long)sdr["PastTime"];
                        if (sdr["Token"] == null) { Obj.Token = null; } else { Obj.Token = (string)sdr["Token"]; }
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