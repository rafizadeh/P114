using _22052020.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _22052020.DAL
{
    public class HospitalContext:DbContext
    {
        public HospitalContext() : base("HospitalContext")
        {

        }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Department> Departments { get; set; }

    }
}