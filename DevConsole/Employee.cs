using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevConsole
{
    public class Employee
    {
        [Column("employee_id")]
        public int ID { get; set; }

        [Column("first_name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Column("last_name")]
        [StringLength(25)]
        public string LastName { get; set; }

        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Column("phone_number")]
        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        [Column("hire_date", TypeName = "date")]
        public DateTime DateHired { get; set; }

        [Column("job_id")]
        public int JobID { get; set; }
        //public virtual Job Job { get; set; }

        [Column("salary", TypeName = "decimal(8,2)")]
        public decimal Salary { get; set; }

        [Column("manager_id")]
        public int? ManagerID { get; set; }
        public virtual Employee Manager { get; set; }

        [Column("department_id")]
        public int DepartmentID { get; set; }
        //public virtual Department Department { get; set; }

    }
}
