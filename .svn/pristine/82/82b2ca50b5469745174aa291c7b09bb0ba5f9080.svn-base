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
    /// 采购记录表：Purchase
    /// </summary>
    public class D_Purchase : SqlBase, I_Purchase
    {
        //数据库表名
        private string TableName { get; set; } = "Purchase";

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
        public int Insert(ref List<M_Purchase> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Agent_ID,Audit_BL,DocumentNumber,CompanyName,PurchaseDate,Status,InvoicePrice,UnInvoicePrice,TotalPrice) values (@Agent_ID,@Audit_BL,@DocumentNumber,@CompanyName,@PurchaseDate,@Status,@InvoicePrice,@UnInvoicePrice,@TotalPrice);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Agent_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Audit_BL", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DocumentNumber", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@CompanyName", SqlDbType.Char, 100);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@PurchaseDate", SqlDbType.DateTime);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Status", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoicePrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@UnInvoicePrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@TotalPrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Purchase m in Obj)
                    {
                        cmd.Parameters["@Agent_ID"].Value = m.Agent_ID;
                        cmd.Parameters["@Audit_BL"].Value = m.Audit_BL;
                        cmd.Parameters["@DocumentNumber"].Value = m.DocumentNumber;
                        cmd.Parameters["@CompanyName"].Value = m.CompanyName;
                        cmd.Parameters["@PurchaseDate"].Value = m.PurchaseDate;
                        cmd.Parameters["@Status"].Value = m.Status;
                        cmd.Parameters["@InvoicePrice"].Value = m.InvoicePrice;
                        cmd.Parameters["@UnInvoicePrice"].Value = m.UnInvoicePrice;
                        cmd.Parameters["@TotalPrice"].Value = m.TotalPrice;
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
        public int Insert(ref M_Purchase Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Agent_ID,Audit_BL,DocumentNumber,CompanyName,PurchaseDate,Status,InvoicePrice,UnInvoicePrice,TotalPrice) values (@Agent_ID,@Audit_BL,@DocumentNumber,@CompanyName,@PurchaseDate,@Status,@InvoicePrice,@UnInvoicePrice,@TotalPrice);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Agent_ID", SqlDbType.Int);
                par.Value = Obj.Agent_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Audit_BL", SqlDbType.Int);
                par.Value = Obj.Audit_BL;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DocumentNumber", SqlDbType.Char, 50);
                par.Value = Obj.DocumentNumber;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@CompanyName", SqlDbType.Char, 100);
                par.Value = Obj.CompanyName;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@PurchaseDate", SqlDbType.DateTime);
                par.Value = Obj.PurchaseDate;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Status", SqlDbType.Int);
                par.Value = Obj.Status;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoicePrice", SqlDbType.Float);
                par.Value = Obj.InvoicePrice;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@UnInvoicePrice", SqlDbType.Float);
                par.Value = Obj.UnInvoicePrice;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@TotalPrice", SqlDbType.Float);
                par.Value = Obj.TotalPrice;
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
        public int Update(List<M_Purchase> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Agent_ID = @Agent_ID, Audit_BL = @Audit_BL, DocumentNumber = @DocumentNumber, CompanyName = @CompanyName, PurchaseDate = @PurchaseDate, Status = @Status, InvoicePrice = @InvoicePrice, UnInvoicePrice = @UnInvoicePrice, TotalPrice = @TotalPrice where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Agent_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Audit_BL", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DocumentNumber", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@CompanyName", SqlDbType.Char, 100);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@PurchaseDate", SqlDbType.DateTime);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Status", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoicePrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@UnInvoicePrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@TotalPrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Purchase m in Obj)
                    {
                        cmd.Parameters["@Agent_ID"].Value = m.Agent_ID;
                        cmd.Parameters["@Audit_BL"].Value = m.Audit_BL;
                        cmd.Parameters["@DocumentNumber"].Value = m.DocumentNumber;
                        cmd.Parameters["@CompanyName"].Value = m.CompanyName;
                        cmd.Parameters["@PurchaseDate"].Value = m.PurchaseDate;
                        cmd.Parameters["@Status"].Value = m.Status;
                        cmd.Parameters["@InvoicePrice"].Value = m.InvoicePrice;
                        cmd.Parameters["@UnInvoicePrice"].Value = m.UnInvoicePrice;
                        cmd.Parameters["@TotalPrice"].Value = m.TotalPrice;
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
        public int Update(M_Purchase Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Agent_ID = @Agent_ID, Audit_BL = @Audit_BL, DocumentNumber = @DocumentNumber, CompanyName = @CompanyName, PurchaseDate = @PurchaseDate, Status = @Status, InvoicePrice = @InvoicePrice, UnInvoicePrice = @UnInvoicePrice, TotalPrice = @TotalPrice where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Agent_ID", SqlDbType.Int);
                par.Value = Obj.Agent_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Audit_BL", SqlDbType.Int);
                par.Value = Obj.Audit_BL;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@DocumentNumber", SqlDbType.Char, 50);
                par.Value = Obj.DocumentNumber;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@CompanyName", SqlDbType.Char, 100);
                par.Value = Obj.CompanyName;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@PurchaseDate", SqlDbType.DateTime);
                par.Value = Obj.PurchaseDate;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Status", SqlDbType.Int);
                par.Value = Obj.Status;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@InvoicePrice", SqlDbType.Float);
                par.Value = Obj.InvoicePrice;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@UnInvoicePrice", SqlDbType.Float);
                par.Value = Obj.UnInvoicePrice;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@TotalPrice", SqlDbType.Float);
                par.Value = Obj.TotalPrice;
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
        public int Select(ref List<M_Purchase> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Agent_ID,Audit_BL,DocumentNumber,CompanyName,PurchaseDate,Status,InvoicePrice,UnInvoicePrice,TotalPrice from {TableName} where ID = @ID", conn);
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
                        foreach (M_Purchase m in Obj)
                        {
                            while (sdr.Read())
                            {
                                m.ID = (int)sdr["ID"];
                                m.Agent_ID = (int)sdr["Agent_ID"];
                                m.Audit_BL = (int)sdr["Audit_BL"];
                                m.CompanyName = (string)sdr["CompanyName"];
                                m.DocumentNumber = (string)sdr["DocumentNumber"];
                                m.InvoicePrice = (float)sdr["InvoicePrice"];
                                m.PurchaseDate = (DateTime)sdr["PurchaseDate"];
                                m.Status = (int)sdr["Status"];
                                m.TotalPrice = (float)sdr["TotalPrice"];
                                m.UnInvoicePrice = (float)sdr["UnInvoicePrice"];
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
        public int Select(ref M_Purchase Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Agent_ID,Audit_BL,DocumentNumber,CompanyName,PurchaseDate,Status,InvoicePrice,UnInvoicePrice,TotalPrice from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.Agent_ID = (int)sdr["Agent_ID"];
                        Obj.Audit_BL = (int)sdr["Audit_BL"];
                        Obj.CompanyName = (string)sdr["CompanyName"];
                        Obj.DocumentNumber = (string)sdr["DocumentNumber"];
                        Obj.InvoicePrice = (float)sdr["InvoicePrice"];
                        Obj.PurchaseDate = (DateTime)sdr["PurchaseDate"];
                        Obj.Status = (int)sdr["Status"];
                        Obj.TotalPrice = (float)sdr["TotalPrice"];
                        Obj.UnInvoicePrice = (float)sdr["UnInvoicePrice"];
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
        public int TurnPage(ref List<M_Purchase> Obj, int Page, int PageSize, ref string ErrMsg)
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
                    foreach (M_Purchase m in Obj)
                    {
                        cmd.Parameters["@ID"].Value = m.ID;
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            m.ID = (int)sdr["ID"];
                            m.Agent_ID = (int)sdr["Agent_ID"];
                            m.Audit_BL = (int)sdr["Audit_BL"];
                            m.CompanyName = (string)sdr["CompanyName"];
                            m.DocumentNumber = (string)sdr["DocumentNumber"];
                            m.InvoicePrice = (float)sdr["InvoicePrice"];
                            m.PurchaseDate = (DateTime)sdr["PurchaseDate"];
                            m.Status = (int)sdr["Status"];
                            m.TotalPrice = (float)sdr["TotalPrice"];
                            m.UnInvoicePrice = (float)sdr["UnInvoicePrice"];
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