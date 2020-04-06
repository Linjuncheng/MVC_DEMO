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
    /// 采购记录表(表体)：Purchase_Body
    /// </summary>
    public class D_Purchase_Body : SqlBase, I_Purchase_Body
    {
        //数据库表名
        private string TableName { get; set; } = "Purchase_Body";

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
        public int Insert(ref List<M_Purchase_Body> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Material_ID,Purchase_ID,Quantity,UnitPrice,TotalPrice) values (@Material_ID,@Purchase_ID,@Quantity,@UnitPrice,@TotalPrice);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Material_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Purchase_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Quantity", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@UnitPrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@TotalPrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Purchase_Body m in Obj)
                    {
                        cmd.Parameters["@Material_ID"].Value = m.Material_ID;
                        cmd.Parameters["@Purchase_ID"].Value = m.Purchase_ID;
                        cmd.Parameters["@Quantity"].Value = m.Quantity;
                        cmd.Parameters["@UnitPrice"].Value = m.UnitPrice;
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
        public int Insert(ref M_Purchase_Body Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Material_ID,Purchase_ID,Quantity,UnitPrice,TotalPrice) values (@Material_ID,@Purchase_ID,@Quantity,@UnitPrice,@TotalPrice);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Material_ID", SqlDbType.Int);
                par.Value = Obj.Material_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Purchase_ID", SqlDbType.Int);
                par.Value = Obj.Purchase_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Quantity", SqlDbType.Int);
                par.Value = Obj.Quantity;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@UnitPrice", SqlDbType.Float);
                par.Value = Obj.UnitPrice;
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
        public int Update(List<M_Purchase_Body> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Material_ID = @Material_ID, Purchase_ID = @Purchase_ID, Quantity = @Quantity, UnitPrice = @UnitPrice, TotalPrice = @TotalPrice where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Material_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Purchase_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Quantity", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@UnitPrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@TotalPrice", SqlDbType.Float);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Purchase_Body m in Obj)
                    {
                        cmd.Parameters["@Material_ID"].Value = m.Material_ID;
                        cmd.Parameters["@Purchase_ID"].Value = m.Purchase_ID;
                        cmd.Parameters["@Quantity"].Value = m.Quantity;
                        cmd.Parameters["@UnitPrice"].Value = m.UnitPrice;
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
        public int Update(M_Purchase_Body Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Material_ID = @Material_ID, Purchase_ID = @Purchase_ID, Quantity = @Quantity, UnitPrice = @UnitPrice, TotalPrice = @TotalPrice where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Material_ID", SqlDbType.Int);
                par.Value = Obj.Material_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Purchase_ID", SqlDbType.Int);
                par.Value = Obj.Purchase_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Quantity", SqlDbType.Int);
                par.Value = Obj.Quantity;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@UnitPrice", SqlDbType.Float);
                par.Value = Obj.UnitPrice;
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
        public int Select(ref List<M_Purchase_Body> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Material_ID,Purchase_ID,Quantity,UnitPrice,TotalPrice from {TableName} where ID = @ID", conn);
                SqlDataReader sdr;
                SqlParameter par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (int i in ID)
                    {
                        cmd.Parameters["@ID"].Value = ID;
                        sdr = cmd.ExecuteReader();
                        foreach (M_Purchase_Body m in Obj)
                        {
                            while (sdr.Read())
                            {
                                m.ID = (int)sdr["ID"];
                                m.Material_ID = (int)sdr["Material_ID"];
                                m.Purchase_ID = (int)sdr["Purchase_ID"];
                                m.Quantity = (int)sdr["Quantity"];
                                m.TotalPrice = (float)sdr["TotalPrice"];
                                m.UnitPrice = (float)sdr["UnitPrice"];
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
        public int Select(ref M_Purchase_Body Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Material_ID,Purchase_ID,Quantity,UnitPrice,TotalPrice from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.Material_ID = (int)sdr["Material_ID"];
                        Obj.Purchase_ID = (int)sdr["Purchase_ID"];
                        Obj.Quantity = (int)sdr["Quantity"];
                        Obj.TotalPrice = (float)sdr["TotalPrice"];
                        Obj.UnitPrice = (float)sdr["UnitPrice"];
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