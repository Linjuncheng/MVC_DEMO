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
    /// 供应商信息表：Supplier
    /// </summary>
    public class D_Supplier : SqlBase, I_Supplier
    {
        //数据库表名
        private string TableName { get; set; } = "Supplier";

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
        public int Insert(ref List<M_Supplier> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Disable_BL,SupplierName,SupplierNumber,DeadLine) values (@Disable_BL,@SupplierName,@SupplierNumber,@DeadLine);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Disable_BL", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@SupplierName", SqlDbType.Char, 100);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@SupplierNumber", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DeadLine", SqlDbType.BigInt);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Supplier m in Obj)
                    {
                        cmd.Parameters["@Disable_BL"].Value = m.Disable_BL;
                        cmd.Parameters["@SupplierName"].Value = m.SupplierName;
                        cmd.Parameters["@SupplierNumber"].Value = m.SupplierNumber;
                        cmd.Parameters["@DeadLine"].Value = m.DeadLine;
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
        public int Insert(ref M_Supplier Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Disable_BL,SupplierName,SupplierNumber,DeadLine) values (@Disable_BL,@SupplierName,@SupplierNumber,@DeadLine);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Disable_BL", SqlDbType.Int);
                par.Value = Obj.Disable_BL;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@SupplierName", SqlDbType.Char, 100);
                par.Value = Obj.SupplierName;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@SupplierNumber", SqlDbType.Char, 50);
                par.Value = Obj.SupplierNumber;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DeadLine", SqlDbType.BigInt);
                par.Value = Obj.DeadLine;
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
        public int Update(List<M_Supplier> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Disable_BL = @Disable_BL, SupplierName = @SupplierName, SupplierNumber = @SupplierNumber, DeadLine = @DeadLine where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Disable_BL", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@SupplierName", SqlDbType.Char, 100);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@SupplierNumber", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DeadLine", SqlDbType.BigInt);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Supplier m in Obj)
                    {
                        cmd.Parameters["@Disable_BL"].Value = m.Disable_BL;
                        cmd.Parameters["@SupplierName"].Value = m.SupplierName;
                        cmd.Parameters["@SupplierNumber"].Value = m.SupplierNumber;
                        cmd.Parameters["@DeadLine"].Value = m.DeadLine;
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
        public int Update(M_Supplier Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Disable_BL = @Disable_BL, SupplierName = @SupplierName, SupplierNumber = @SupplierNumber, DeadLine = @DeadLine where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Disable_BL", SqlDbType.Int);
                par.Value = Obj.Disable_BL;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@SupplierName", SqlDbType.Char, 100);
                par.Value = Obj.SupplierName;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@SupplierNumber", SqlDbType.Char, 50);
                par.Value = Obj.SupplierNumber;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DeadLine", SqlDbType.BigInt);
                par.Value = Obj.DeadLine;
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
        public int Select(ref List<M_Supplier> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Disable_BL,SupplierName,SupplierNumber,DeadLine from {TableName} where ID = @ID", conn);
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
                        foreach (M_Supplier m in Obj)
                        {
                            while (sdr.Read())
                            {
                                m.ID = (int)sdr["ID"];
                                m.DeadLine = (long)sdr["DeadLine"];
                                m.Disable_BL = (int)sdr["Disable_BL"];
                                m.SupplierName = (string)sdr["SupplierName"];
                                m.SupplierNumber = (string)sdr["SupplierNumber"];
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
        public int Select(ref M_Supplier Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Disable_BL,SupplierName,SupplierNumber,DeadLine from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.DeadLine = (long)sdr["DeadLine"];
                        Obj.Disable_BL = (int)sdr["Disable_BL"];
                        Obj.SupplierName = (string)sdr["SupplierName"];
                        Obj.SupplierNumber = (string)sdr["SupplierNumber"];
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