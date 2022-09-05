using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Batch1_DET_2022
{
    public class Database_approach
    {
        private static object employee;

        public static void Main(string[] args)
        {
            //GetAllEmpDetails();
            //GetAllEmpDetailsByID();
            // AddNewEmployee();
            // DeleteEmployee();
            //UpdateNewEmployee1(); //with parameter
            //UpdateNewEmployee();//without parameter
            CallStoredProcwithSQLParamater_insert();
            Console.ReadLine();
        }

        //        private static void DeleteEmployee()
        //        {
        //            var ctx = new shilpaContext();

        //            try
        //            {
        //                Batch1_DET_2022.Models.Emp emp = new Models.Emp();
        //                emp.Empno = 7900;
        //                emp.Ename = "guna";
        //                emp.Sal = 1000;
        //                emp.Deptno = 30;
        //               emp.Job = "Trainer";
        //                ctx.Update(emp);
        //                ctx.SaveChanges();
        //                Console.WriteLine("New employee deleted");

        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.InnerException.Message);

        //            }
        //        }
        //    }
        //}

        //private static void AddNewEmployee()
        //{
        //    var ctx = new shilpaContext();

        //    try
        //    {
        //        Batch1_DET_2022.Models.Emp emp = new Models.Emp();
        //        emp.Empno = 2979;
        //        emp.Ename = "shilpa";
        //        emp.Sal = 1000;
        //        emp.Deptno = 30;
        //        emp.Job = "Trainer";
        //        ctx.Add(emp);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New employee added");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);

        //    }
        //        }
        //            private static void GetAllEmpDeatailsByID()
        //        {
        //            var ctx = new shilpaContext();
        //            var Emp = ctx.Emps.Where ( e => e.Empno == 7499).SingleOrDefault();
        //            Console.WriteLine(Emp.Ename + " " + Emp.Sal + " " + Emp.Job);
        //        }

        //private static void GetAllEmpDetails()
        //{
        //    var ctx = new shilpaContext();
        //    var emps = ctx.Emps;

        //            foreach (var emp in emps)

        //            {
        //                Console.WriteLine(emp.Ename + "  " + emp.Sal);
        //            }
        //        }

        //    }
        //}

        //        public static void UpdateEmpDetails()
        //        {
        //            var ctx = new shilpaContext();
        //            var emp = ctx.Emps.Where(e => e.Empno == 7566).SingleOrDefault();

        //            emp.Ename = "shilpa";
        //            ctx.Update(emp);
        //            ctx.SaveChanges();
        //            Console.WriteLine("updated");
        //        }
        //    }


        //private static void UpdateNewEmployee1()

        //{

        //    var ctx = new shilpaContext();
        //    var EMP = ctx.Emps.FromSqlRaw($"GetEmpsDetailsByEmpno @p0 ", 7654).ToList();
        //    foreach (var e in EMP)
        //    {
        //        Console.WriteLine(e.Ename);

        //    }

        //}

        //        private static void UpdateNewEmployee()
        //        {
        //           var ctx = new shilpaContext();
        //        var employees = ctx.Emps.FromSqlRaw("GetAllEmpsDetails").ToList();



        //          foreach (var e in employees)
        //            {
        //                Console.WriteLine(e.Ename);
        //          }
        //}

   // }
//}
// CALLSTOREDPROCEDURE
private static void CallStoredProcwithSQLParamater_insert()
{
                       var ctx = new shilpaContext(); 
                          var param = new SqlParameter[] {
                                new SqlParameter() {
                            ParameterName = "@Empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 6
                        },

                         new SqlParameter() {
                            ParameterName = "@Empname",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "RDBMS concept"},

                          new SqlParameter() {
                            ParameterName = "@Job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 100}

                       };

    try
    {
        var result = ctx.Database.ExecuteSqlRaw($"InsertEmployee @Empno, @Empname, @Job", param);
        Console.WriteLine("added");
    }
    catch (Exception ex)
    {

                throw;
    }


    Console.WriteLine("update successful");

}
}
}