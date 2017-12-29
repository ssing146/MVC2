using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web2.Models;

namespace web2.ViewModel
{
    public class EmpDeptViewModel
    {
        Employee EmpObj = new Employee();
        Department DeptObj = new Department();
        public int EmpId { get=>EmpObj.EmpId; set { EmpObj.EmpId = value; } }
        public string name { get=>EmpObj.EmpName; set { EmpObj.EmpName = value; } }
        public int DepartmentId { get=>DeptObj.DeptId; set { DeptObj.DeptId = value; } }
        public string departmentName { get=>DeptObj.DeptName; set { DeptObj.DeptName = value; } }

    }
}