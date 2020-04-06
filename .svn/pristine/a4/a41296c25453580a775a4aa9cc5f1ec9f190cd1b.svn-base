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
    /// 审批记录表：AuditRecord
    /// </summary>
    public class D_AuditRecord : SqlBase, I_AuditRecord
    {
        //数据库表名
        private string TableName { get; set; } = "AuditRecord";

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
        public int Insert(ref List<M_AuditRecord> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Employee_ID,HistoricalRecord,FormType) values (@Employee_ID,@HistoricalRecord,@FormType);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Employee_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@HistoricalRecord", SqlDbType.Text);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@FormType", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_AuditRecord m in Obj)
                    {
                        cmd.Parameters["@Employee_ID"].Value = m.Employee_ID;
                        cmd.Parameters["@HistoricalRecord"].Value = m.HistoricalRecord;
                        cmd.Parameters["@FormType"].Value = m.FormType;
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
        public int Insert(ref M_AuditRecord Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Employee_ID,HistoricalRecord,FormType) values (@Employee_ID,@HistoricalRecord,@FormType);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Employee_ID", SqlDbType.Int);
                par.Value = Obj.Employee_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@HistoricalRecord", SqlDbType.Text);
                par.Value = Obj.HistoricalRecord;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@FormType", SqlDbType.Char, 50);
                par.Value = Obj.FormType;
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
        public int Update(List<M_AuditRecord> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Employee_ID = @Employee_ID, HistoricalRecord = @HistoricalRecord, FormType = @FormType where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Employee_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@HistoricalRecord", SqlDbType.Text);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@FormType", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_AuditRecord m in Obj)
                    {
                        cmd.Parameters["@Employee_ID"].Value = m.Employee_ID;
                        cmd.Parameters["@HistoricalRecord"].Value = m.HistoricalRecord;
                        cmd.Parameters["@FormType"].Value = m.FormType;
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
        public int Update(M_AuditRecord Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Employee_ID = @Employee_ID, HistoricalRecord = @HistoricalRecord, FormType = @FormType where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Employee_ID", SqlDbType.Int);
                par.Value = Obj.Employee_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@HistoricalRecord", SqlDbType.Text);
                par.Value = Obj.HistoricalRecord;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@FormType", SqlDbType.Char, 50);
                par.Value = Obj.FormType;
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
        public int Select(ref List<M_AuditRecord> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Employee_ID,HistoricalRecord,FormType from {TableName} where ID = @ID", conn);
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
                        foreach (M_AuditRecord m in Obj)
                        {
                            while (sdr.Read())
                            {
                                m.ID = (int)sdr["ID"];
                                m.Employee_ID = (int)sdr["Employee_ID"];
                                m.FormType = (string)sdr["FormType"];
                                m.HistoricalRecord = (string)sdr["HistoricalRecord"];
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
        public int Select(ref M_AuditRecord Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Employee_ID,HistoricalRecord,FormType from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.Employee_ID = (int)sdr["Employee_ID"];
                        Obj.FormType = (string)sdr["FormType"];
                        Obj.HistoricalRecord = (string)sdr["HistoricalRecord"];
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
        //分页
        public int TurnPage(ref List<M_AuditRecord> Obj, int Page, int PageSize, ref string ErrMsg)
        {
            int tmpMaxid = Page * PageSize;
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"SELECT TOP ({PageSize}) * FROM {TableName} WHERE ID > (SELECT ISNULL(MAX(ID),0) FROM (SELECT TOP ({tmpMaxid}) ID FROM {TableName} ORDER BY {TableName} ASC) as T1)", conn);
                SqlDataReader sdr;
                SqlParameter par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_AuditRecord m in Obj)
                    {
                        cmd.Parameters["@ID"].Value = m.ID;
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            m.ID = (int)sdr["ID"];
                            m.Employee_ID = (int)sdr["Employee_ID"];
                            m.FormType = (string)sdr["FormType"];
                            m.HistoricalRecord = (string)sdr["HistoricalRecord"];
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
    }//
}//