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
    /// 物料信息表：Material
    /// </summary>
    public class D_Material : SqlBase, I_Material
    {
        //数据库表名
        private string TableName { get; set; } = "Material";

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
        public int Insert(ref List<M_Material> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Disable_BL,ProductName,MaterialCode,ProductModel) values (@Disable_BL,@ProductName,@MaterialCode,@ProductModel);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Disable_BL", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ProductName", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@MaterialCode", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ProductModel", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Material m in Obj)
                    {
                        cmd.Parameters["@Disable_BL"].Value = m.Disable_BL;
                        cmd.Parameters["@ProductName"].Value = m.ProductName;
                        cmd.Parameters["@MaterialCode"].Value = m.MaterialCode;
                        cmd.Parameters["@ProductModel"].Value = m.ProductModel;
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
        public int Insert(ref M_Material Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (Disable_BL,ProductName,MaterialCode,ProductModel) values (@Disable_BL,@ProductName,@MaterialCode,@ProductModel);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@Disable_BL", SqlDbType.Int);
                par.Value = Obj.Disable_BL;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ProductName", SqlDbType.Char, 50);
                par.Value = Obj.ProductName;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@MaterialCode", SqlDbType.Char, 50);
                par.Value = Obj.MaterialCode;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ProductModel", SqlDbType.Char, 50);
                par.Value = Obj.ProductModel;
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
        public int Update(List<M_Material> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Disable_BL = @Disable_BL, ProductName = @ProductName, MaterialCode = @MaterialCode, ProductModel = @ProductModel where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Disable_BL", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ProductName", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@MaterialCode", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ProductModel", SqlDbType.Char, 50);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Material m in Obj)
                    {
                        cmd.Parameters["@Disable_BL"].Value = m.Disable_BL;
                        cmd.Parameters["@ProductName"].Value = m.ProductName;
                        cmd.Parameters["@MaterialCode"].Value = m.MaterialCode;
                        cmd.Parameters["@ProductModel"].Value = m.ProductModel;
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
        public int Update(M_Material Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set Disable_BL = @Disable_BL, ProductName = @ProductName, MaterialCode = @MaterialCode, ProductModel = @ProductModel where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@Disable_BL", SqlDbType.Int);
                par.Value = Obj.Disable_BL;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ProductName", SqlDbType.Char, 50);
                par.Value = Obj.ProductName;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@MaterialCode", SqlDbType.Char, 50);
                par.Value = Obj.MaterialCode;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ProductModel", SqlDbType.Char, 50);
                par.Value = Obj.ProductModel;
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
        public int Select(ref List<M_Material> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Disable_BL,ProductName,MaterialCode,ProductModel from {TableName} where ID = @ID", conn);
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
                        foreach (M_Material m in Obj)
                        {
                            while (sdr.Read())
                            {
                                m.ID = (int)sdr["ID"];
                                m.Disable_BL = (int)sdr["Disable_BL"];
                                m.MaterialCode = (string)sdr["MaterialCode"];
                                m.ProductModel = (string)sdr["ProductModel"];
                                m.ProductName = (string)sdr["ProductName"];
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
        public int Select(ref M_Material Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,Disable_BL,ProductName,MaterialCode,ProductModel from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.Disable_BL = (int)sdr["Disable_BL"];
                        Obj.MaterialCode = (string)sdr["MaterialCode"];
                        Obj.ProductModel = (string)sdr["ProductModel"];
                        Obj.ProductName = (string)sdr["ProductName"];
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
        public int TurnPage(ref List<M_Material> Obj, int Page, int PageSize, ref string ErrMsg)
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
                    foreach (M_Material m in Obj)
                    {
                        cmd.Parameters["@ID"].Value = m.ID;
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            m.ID = (int)sdr["ID"];
                            m.Disable_BL = (int)sdr["Disable_BL"];
                            m.MaterialCode = (string)sdr["MaterialCode"];
                            m.ProductModel = (string)sdr["ProductModel"];
                            m.ProductName = (string)sdr["ProductName"];
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