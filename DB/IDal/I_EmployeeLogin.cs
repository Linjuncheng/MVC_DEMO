﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Model;

namespace DB.IDal
{
    /// <summary>
    /// 员工登录表：EmployeeLogin
    /// </summary>
    public interface I_EmployeeLogin
    {
        /// <summary>
        /// 查询（查用户名）
        /// </summary>
        /// <param name="Obj">回传查询结果</param>
        /// <param name="Username">根据Username查询</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int Select_Name(ref List<M_EmployeeLogin> Obj, string username, ref string ErrMsg);
        /// <summary>
        /// 员工登录
        /// </summary>
        /// <param name="Obj">回传用户信息</param>
        /// <param name="username">账号</param>
        /// <param name="password">密码</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int Login(ref M_EmployeeLogin Obj, string username, string password, ref string ErrMsg);
        /// <summary>
        /// 插入单个
        /// </summary>
        /// <param name="Obj">传递插入行信息并回传ID</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int Insert(ref M_EmployeeLogin Obj, ref string ErrMsg);
        /// <summary>
        /// 插入多个
        /// </summary>
        /// <param name="Obj">传递插入行信息并回传ID</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int Insert(ref List<M_EmployeeLogin> Obj, ref string ErrMsg);
        /// <summary>
        /// 删除单个（查ID）
        /// </summary>
        /// <param name="ID">根据ID删除</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int Delete(int ID, ref string ErrMsg);
        /// <summary>
        /// 删除多个（查ID）
        /// </summary>
        /// <param name="ID">根据ID删除</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int Delete(List<int> ID, ref string ErrMsg);
        /// <summary>
        /// 更新单个（查ID）
        /// </summary>
        /// <param name="Obj">传递更新行信息</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int Update(M_EmployeeLogin Obj, ref string ErrMsg);
        /// <summary>
        /// 更新多个
        /// </summary>
        /// <param name="Obj">传递更新行信息</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int Update(List<M_EmployeeLogin> Obj, ref string ErrMsg);
        /// <summary>
        /// 查询单个（查ID）
        /// </summary>
        /// <param name="Obj">回传查询结果</param>
        /// <param name="ID">根据ID查询</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int Select(ref M_EmployeeLogin Obj, int ID, ref string ErrMsg);
        /// <summary>
        /// 查询多个（查ID）
        /// </summary>
        /// <param name="Obj">回传查询结果</param>
        /// <param name="ID">根据ID查询</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int Select(ref List<M_EmployeeLogin> Obj, List<int> ID, ref string ErrMsg);
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="Obj">回传信息</param>
        /// <param name="Page">页数</param>
        /// <param name="PageSize">单页行数</param>
        /// <param name="ErrMsg">回传错误信息</param>
        /// <returns>成功返回:1 失败返回:-1</returns>
        int TurnPage(ref List<M_EmployeeLogin> Obj, int Page, int PageSize, ref string ErrMsg);
    }
}
