using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB.Dal;

namespace DB.SF//简单工厂
{
    public enum DBType
    {
        Online,
        EmployeeLogin,
        AdminLogin,
        Supplier,
        Purchase,
        Purchase_Body,
        Material,
        Invoice,
        AuditFlow,
        AuditRecord,
        AuditAccess,
        TokenTable
    }
    public static class SimpleFactory
    {
        public static object CreateObject(DBType e)
        {
            switch(e)
            {
                case DBType.Online:
                    return new D_Online();
                case DBType.EmployeeLogin:
                    return new D_EmployeeLogin();
                case DBType.AdminLogin:
                    return new D_AdminLogin();
                case DBType.Supplier:
                    return new D_Supplier();
                case DBType.Purchase:
                    return new D_Purchase();
                case DBType.Purchase_Body:
                    return new D_Purchase_Body();
                case DBType.Material:
                    return new D_Material();
                case DBType.Invoice:
                    return new D_Invoice();
                case DBType.AuditFlow:
                    return new D_AuditFlow();
                case DBType.AuditRecord:
                    return new D_AuditRecord();
                case DBType.AuditAccess:
                    return new D_AuditAccess();
                case DBType.TokenTable:
                    return new D_TokenTable();
                default :
                    return null;
            }
        }
    }
}//
