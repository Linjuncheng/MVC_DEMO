using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InvoiceSystem.Models;
using PagedList;

namespace InvoiceSystem.Controllers
{
    public class TicktesController : Controller
    {
        /**
         * 列表查看
         */
        public ActionResult CheckList()
        {

            return View();
        }
        // GET: Ticktes
        /**
         * 发票记录表
         */
        [HttpGet]
        public ActionResult Invoice()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Invoice(Invoice model)
        {
            return View();
        }
        /**
         * 采购信息表
         */
        [HttpGet]
        public ActionResult Purchase()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Text = "--------请选择--------", Value = "" });
            items.Add(new SelectListItem() { Text = "1", Value = "1" });
            items.Add(new SelectListItem() { Text = "2", Value = "2" });
            items.Add(new SelectListItem() { Text = "3", Value = "3" });
            ViewData["option"] = items;

            List<SelectListItem> items1 = new List<SelectListItem>();
            items1.Add(new SelectListItem() { Text = "--------请选择--------", Value = "" });
            items1.Add(new SelectListItem() { Text = "0", Value = "0" });
            items1.Add(new SelectListItem() { Text = "1", Value = "1" });
            ViewData["option1"] = items1;
            return View();
        }

        [HttpPost]
        public ActionResult Purchase(Purchase model)
        {
            return View();
        }
        /**
         * 物料信息表
         */
        [HttpGet]
        public ActionResult Material()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Material(Material model)
        {

            return View();

        }

        /**
         * 供应商信息表
         */
        [HttpGet]
        public ActionResult Supplier()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Supplier(Supplier model)
        {
            return View();
        }
        // GET: Student
        //private StudentContext db = new StudentContext();

        //public ViewResult StudentList(int? page)
        //{
        //    //学生列表
        //    var students = from s in db.Students select s;

        //    //第几页
        //    int pageNumber = page ?? 1;

        //    //每页显示多少条
        //    int pageSize = int.Parse(ConfigurationManager.AppSettings["pageSize"]);

        //    //根据ID排序
        //    students = students.OrderBy(x => x.ID);

        //    //通过ToPagedList扩展方法进行分页
        //    IPagedList<Student> pagedList = students.ToPagedList(pageNumber, pageSize);

        //    //将分页处理后的列表传给View
        //    return View(pagedList);
        //}
        /**
         * 表单查询
         */

    }
}