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
    /// 管理员登录表：AdminLogin
    /// </summary>
    public class D_AdminLogin : SqlBase, I_AdminLogin
    {
        //数据库表名
        private string TableName { get; set; } = "AdminLogin";

        //查询（查用户名）
        public int Select_Name(ref List<M_AdminLogin> Obj, string username, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Username,Password from {TableName} where ID = @Username", conn);
                SqlDataReader sdr;
                SqlParameter par = new SqlParameter("@Username", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    cmd.Parameters["@Username"].Value = username;
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        M_AdminLogin TmpObj = new M_AdminLogin();
                        TmpObj.ID = (int)sdr["ID"];
                        TmpObj.Password = (string)sdr["Password"];
                        TmpObj.Username = (string)sdr["Username"];
                        Obj.Add(TmpObj);
                        tmpOut++;
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
                if (tmpOut > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        //管理员登录
        public int Login(ref M_AdminLogin Obj, string username, string password, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"Select * from {TableName} where Username = @username and Password = @password", conn);

                SqlParameter par = new SqlParameter("@username", SqlDbType.Char, 50);
                par.Value = username;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@password", SqlDbType.Char, 50);
                par.Value = password;
                cmd.Parameters.Add(par);

                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.Password = (string)sdr["Password"];
                        Obj.Username = (string)sdr["Username"];
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
        public int Insert(ref List<M_AdminLogin> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Username,Password) values (@Username,@Password);select @@IDENTITY as int", conn);
   
                SqlParameter par = new SqlParameter("@Username", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Password", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_AdminLogin m in Obj)
                    {
                        cmd.Parameters["@Username"].Value = m.Username;
                        cmd.Parameters["@Password"].Value = m.Password;
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
        public int Insert(ref M_AdminLogin Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Username,Password) values (@Username,@Password);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Username", SqlDbType.Char, 50);
                par.Value = Obj.Username;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Password", SqlDbType.Char, 50);
                par.Value = Obj.Password;
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
        public int Update(List<M_AdminLogin> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Username = @Username, Password = @Password where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Username", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Password", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_AdminLogin m in Obj)
                    {
                        cmd.Parameters["@Username"].Value = m.Username;
                        cmd.Parameters["@Password"].Value = m.Password;
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
        public int Update(M_AdminLogin Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Username = @Username, Password = @Password where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Username", SqlDbType.Char, 50);
                par.Value = Obj.Username;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Password", SqlDbType.Char, 50);
                par.Value = Obj.Password;
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
        public int Select(ref List<M_AdminLogin> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Username,Password from {TableName} where ID = @ID", conn);
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
                            M_AdminLogin TmpObj = new M_AdminLogin();
                            TmpObj.ID = (int)sdr["ID"];
                            TmpObj.Password = (string)sdr["Password"];
                            TmpObj.Username = (string)sdr["Username"];
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
        public int Select(ref M_AdminLogin Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Username,Password from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.Password = (string)sdr["Password"];
                        Obj.Username = (string)sdr["Username"];
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