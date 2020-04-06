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
    /// 审批流表：AuditFlow
    /// </summary>
    public class D_AuditFlow : SqlBase, I_AuditFlow
    {
        //数据库表名
        private string TableName { get; set; } = "AuditFlow";

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
        public int Insert(ref List<M_AuditFlow> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (User_ID,Document_ID,DocumentType) values (@User_ID,@Document_ID,@DocumentType);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Document_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DocumentType", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_AuditFlow m in Obj)
                    {
                        cmd.Parameters["@User_ID"].Value = m.User_ID;
                        cmd.Parameters["@Document_ID"].Value = m.Document_ID;
                        cmd.Parameters["@DocumentType"].Value = m.DocumentType;
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
        public int Insert(ref M_AuditFlow Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (User_ID,Document_ID,DocumentType) values (@User_ID,@Document_ID,@DocumentType);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                par.Value = Obj.User_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Document_ID", SqlDbType.Int);
                par.Value = Obj.Document_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DocumentType", SqlDbType.Char, 50);
                par.Value = Obj.DocumentType;
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
        public int Update(List<M_AuditFlow> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set User_ID = @User_ID, Document_ID = @Document_ID, DocumentType = @DocumentType where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Document_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DocumentType", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_AuditFlow m in Obj)
                    {
                        cmd.Parameters["@User_ID"].Value = m.User_ID;
                        cmd.Parameters["@Document_ID"].Value = m.Document_ID;
                        cmd.Parameters["@DocumentType"].Value = m.DocumentType;
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
        public int Update(M_AuditFlow Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set User_ID = @User_ID, Document_ID = @Document_ID, DocumentType = @DocumentType where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                par.Value = Obj.User_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Document_ID", SqlDbType.Int);
                par.Value = Obj.Document_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DocumentType", SqlDbType.Char, 50);
                par.Value = Obj.DocumentType;
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
        public int Select(ref List<M_AuditFlow> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,User_ID,Document_ID,DocumentType from {TableName} where ID = @ID", conn);
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
                        foreach (M_AuditFlow m in Obj)
                        {
                            while (sdr.Read())
                            {
                                m.ID = (int)sdr["ID"];
                                m.DocumentType = (string)sdr["DocumentType"];
                                m.Document_ID = (int)sdr["Document_ID"];
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
        public int Select(ref M_AuditFlow Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,User_ID,Document_ID,DocumentType from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.DocumentType = (string)sdr["DocumentType"];
                        Obj.Document_ID = (int)sdr["Document_ID"];
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