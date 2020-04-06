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
    /// 发票记录表：Invoice
    /// </summary>
    public class D_Invoice : SqlBase, I_Invoice
    {
        //数据库表名
        private string TableName { get; set; } = "Invoice";

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
        public int Insert(ref List<M_Invoice> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Purchase_ID,InvoiceTime,InvoicePrice,InvoiceNumber,InvoiceCompanyName,BankNumber,Remark) values (@Purchase_ID,@InvoiceTime,@InvoicePrice,@InvoiceNumber,@InvoiceCompanyName,@BankNumber,@Remark);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Purchase_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceTime", SqlDbType.DateTime);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoicePrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceNumber", SqlDbType.Char, 10);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceCompanyName", SqlDbType.Char, 100);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@BankNumber", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Remark", SqlDbType.Char, 100);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Invoice m in Obj)
                    {
                        cmd.Parameters["@Purchase_ID"].Value = m.Purchase_ID;
                        cmd.Parameters["@InvoiceTime"].Value = m.InvoiceTime;
                        cmd.Parameters["@InvoicePrice"].Value = m.InvoicePrice;
                        cmd.Parameters["@InvoiceNumber"].Value = m.InvoiceNumber;
                        if (m.InvoiceCompanyName == null) { cmd.Parameters["@InvoiceCompanyName"].Value = DBNull.Value; } else { cmd.Parameters["@InvoiceCompanyName"].Value = m.InvoiceCompanyName; }
                        cmd.Parameters["@BankNumber"].Value = m.BankNumber;
                        cmd.Parameters["@Remark"].Value = m.Remark;
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
        public int Insert(ref M_Invoice Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Purchase_ID,InvoiceTime,InvoicePrice,InvoiceNumber,InvoiceCompanyName,BankNumber,Remark) values (@Purchase_ID,@InvoiceTime,@InvoicePrice,@InvoiceNumber,@InvoiceCompanyName,@BankNumber,@Remark);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Purchase_ID", SqlDbType.Int);
                par.Value = Obj.Purchase_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceTime", SqlDbType.DateTime);
                par.Value = Obj.InvoiceTime;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoicePrice", SqlDbType.Float);
                par.Value = Obj.InvoicePrice;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceNumber", SqlDbType.Char, 10);
                par.Value = Obj.InvoiceNumber;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceCompanyName", SqlDbType.Char, 100);
                if (Obj.InvoiceCompanyName == null) { par.Value = DBNull.Value; } else { par.Value = Obj.InvoiceCompanyName; }
                cmd.Parameters.Add(par);

                par = new SqlParameter("@BankNumber", SqlDbType.Char, 50);
                par.Value = Obj.BankNumber;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Remark", SqlDbType.Char, 100);
                par.Value = Obj.Remark;
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
        public int Update(List<M_Invoice> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Purchase_ID = @Purchase_ID, InvoiceTime = @InvoiceTime, InvoicePrice = @InvoicePrice, InvoiceNumber = @InvoiceNumber, InvoiceCompanyName = @InvoiceCompanyName, BankNumber = @BankNumber, Remark = @Remark where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Purchase_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceTime", SqlDbType.DateTime);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoicePrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceNumber", SqlDbType.Char, 10);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceCompanyName", SqlDbType.Char, 100);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@BankNumber", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Remark", SqlDbType.Char, 100);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Invoice m in Obj)
                    {
                        cmd.Parameters["@Purchase_ID"].Value = m.Purchase_ID;
                        cmd.Parameters["@InvoiceTime"].Value = m.InvoiceTime;
                        cmd.Parameters["@InvoicePrice"].Value = m.InvoicePrice;
                        cmd.Parameters["@InvoiceNumber"].Value = m.InvoiceNumber;
                        if (m.InvoiceCompanyName == null) { cmd.Parameters["@InvoiceCompanyName"].Value = DBNull.Value; } else { cmd.Parameters["@InvoiceCompanyName"].Value = m.InvoiceCompanyName; }
                        cmd.Parameters["@BankNumber"].Value = m.BankNumber;
                        cmd.Parameters["@Remark"].Value = m.Remark;
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
        public int Update(M_Invoice Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Purchase_ID = @Purchase_ID, InvoiceTime = @InvoiceTime, InvoicePrice = @InvoicePrice, InvoiceNumber = @InvoiceNumber, InvoiceCompanyName = @InvoiceCompanyName, BankNumber = @BankNumber, Remark = @Remark where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Purchase_ID", SqlDbType.Int);
                par.Value = Obj.Purchase_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceTime", SqlDbType.DateTime);
                par.Value = Obj.InvoiceTime;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoicePrice", SqlDbType.Float);
                par.Value = Obj.InvoicePrice;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceNumber", SqlDbType.Char, 10);
                par.Value = Obj.InvoiceNumber;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoiceCompanyName", SqlDbType.Char, 100);
                if (Obj.InvoiceCompanyName == null) { par.Value = DBNull.Value; } else { par.Value = Obj.InvoiceCompanyName; }
                cmd.Parameters.Add(par);

                par = new SqlParameter("@BankNumber", SqlDbType.Char, 50);
                par.Value = Obj.BankNumber;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Remark", SqlDbType.Char, 100);
                par.Value = Obj.Remark;
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
        public int Select(ref List<M_Invoice> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Purchase_ID,InvoiceTime,InvoicePrice,InvoiceNumber,InvoiceCompanyName,BankNumber,Remark from {TableName} where ID = @ID", conn);
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
                        foreach (M_Invoice m in Obj)
                        {
                            while (sdr.Read())
                            {
                                m.ID = (int)sdr["ID"];
                                m.BankNumber = (string)sdr["BankNumber"];
                                if (sdr["InvoiceCompanyName"] == null) { m.InvoiceCompanyName = string.Empty; } else { m.InvoiceCompanyName = (string)sdr["InvoiceCompanyName"]; }
                                m.InvoiceNumber = (string)sdr["InvoiceNumber"];
                                m.InvoicePrice = (int)sdr["InvoicePrice"];
                                m.InvoiceTime = (DateTime)sdr["InvoiceTime"];
                                m.Purchase_ID = (int)sdr["Purchase_ID"];
                                m.Remark = (string)sdr["Remark"];
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
        public int Select(ref M_Invoice Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Purchase_ID,InvoiceTime,InvoicePrice,InvoiceNumber,InvoiceCompanyName,BankNumber,Remark from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.BankNumber = (string)sdr["BankNumber"];
                        if (sdr["InvoiceCompanyName"] == null) { Obj.InvoiceCompanyName = string.Empty; } else { Obj.InvoiceCompanyName = (string)sdr["InvoiceCompanyName"]; }
                        Obj.InvoiceNumber = (string)sdr["InvoiceNumber"];
                        Obj.InvoicePrice = (float)sdr["InvoicePrice"];
                        Obj.InvoiceTime = (DateTime)sdr["InvoiceTime"];
                        Obj.Purchase_ID = (int)sdr["Purchase_ID"];
                        Obj.Remark = (string)sdr["Remark"];
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
        public int TurnPage(ref List<M_Invoice> Obj, int Page, int PageSize, ref string ErrMsg)
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
                    foreach (M_Invoice m in Obj)
                    {
                        cmd.Parameters["@ID"].Value = m.ID;
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            m.ID = (int)sdr["ID"];
                            m.BankNumber = (string)sdr["BankNumber"];
                            if (sdr["InvoiceCompanyName"] == null) { m.InvoiceCompanyName = string.Empty; } else { m.InvoiceCompanyName = (string)sdr["InvoiceCompanyName"]; }
                            m.InvoiceNumber = (string)sdr["InvoiceNumber"];
                            m.InvoicePrice = (int)sdr["InvoicePrice"];
                            m.InvoiceTime = (DateTime)sdr["InvoiceTime"];
                            m.Purchase_ID = (int)sdr["Purchase_ID"];
                            m.Remark = (string)sdr["Remark"];
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