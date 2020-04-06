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
    /// 权限表：Access
    /// </summary>
    public class D_Access : SqlBase, I_Access
    {
        //数据库表名
        private string TableName { get; set; } = "Access";

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
        public int Insert(ref List<M_Access> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (User_ID,User_Type,Access_BL,Access_Name) values (@User_ID,@User_Type,@Access_BL,Access_Name);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@User_Type", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Access_BL", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Access_Name", SqlDbType.Char, 20);
                cmd.Parameters.Add(par);

                int tmpOut = 0;

                try
                {
                    conn.Open();
                    foreach (M_Access m in Obj)
                    {
                        cmd.Parameters["@User_ID"].Value = m.User_ID;
                        cmd.Parameters["@User_Type"].Value = m.User_Type;
                        cmd.Parameters["@Access_BL"].Value = m.Access_BL;
                        cmd.Parameters["@Access_Name"].Value = m.Access_Name;
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
        public int Insert(ref M_Access Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"insert into {TableName} (User_ID,User_Type,Access_BL,Access_Name) values (@User_ID,@User_Type,@Access_BL,Access_Name);select @@IDENTITY as int", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                par.Value = Obj.User_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@User_Type", SqlDbType.Int);
                par.Value = Obj.User_Type;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Access_BL", SqlDbType.Int);
                par.Value = Obj.Access_BL;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Access_Name", SqlDbType.Char, 20);
                par.Value = Obj.Access_Name;
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
        public int Update(List<M_Access> Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set User_ID = @User_ID, AuditFlow_ID = @AuditFlow_ID, LevelHierarchy = @LevelHierarchy where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@User_Type", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Access_BL", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Access_Name", SqlDbType.Int);
                cmd.Parameters.Add(par);

                par = new SqlParameter("@ID", SqlDbType.Int);
                cmd.Parameters.Add(par);

                int tmpOut = 0;
                try
                {
                    conn.Open();
                    foreach (M_Access m in Obj)
                    {
                        cmd.Parameters["@User_ID"].Value = m.User_ID;
                        cmd.Parameters["@User_Type"].Value = m.User_Type;
                        cmd.Parameters["@Access_BL"].Value = m.Access_BL;
                        cmd.Parameters["@Access_Name"].Value = m.Access_Name;
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
        public int Update(M_Access Obj, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"update {TableName} set User_ID = @User_ID, User_Type = @User_Type, Access_BL = @Access_BL, Access_Name = @Access_Name where ID = @ID", conn);

                SqlParameter par = new SqlParameter("@User_ID", SqlDbType.Int);
                par.Value = Obj.User_ID;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@User_Type", SqlDbType.Int);
                par.Value = Obj.User_Type;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Access_BL", SqlDbType.Int);
                par.Value = Obj.Access_BL;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@Access_Name", SqlDbType.Char, 20);
                par.Value = Obj.Access_Name;
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
        public int Select(ref List<M_Access> Obj, List<int> ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,User_ID,User_Type,Access_BL,Access_Name from {TableName} where ID = @ID", conn);
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
                            M_Access TmpObj = new M_Access();
                            TmpObj.ID = (int)sdr["ID"];
                            TmpObj.User_ID = (int)sdr["User_ID"];
                            TmpObj.User_Type = (int)sdr["User_Type"];
                            TmpObj.Access_BL = (int)sdr["Access_BL"];
                            TmpObj.Access_Name = (string)sdr["Access_Name"];
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
        public int Select(ref M_Access Obj, int ID, ref string ErrMsg)
        {
            SqlConnection conn;
            using (conn = CreatConn())
            {
                SqlCommand cmd = new SqlCommand($"select ID,User_ID,User_Type,Access_BL,Access_Name from {TableName} where ID = {ID}", conn);
                SqlDataReader sdr;
                try
                {
                    conn.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        Obj.ID = (int)sdr["ID"];
                        Obj.User_ID = (int)sdr["User_ID"];
                        Obj.User_Type = (int)sdr["User_Type"];
                        Obj.Access_BL = (int)sdr["Access_BL"];
                        Obj.Access_Name = (string)sdr["Access_Name"];
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