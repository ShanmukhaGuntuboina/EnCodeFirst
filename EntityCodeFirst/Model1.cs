using EntityCodeFirst.Controllers;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityCodeFirst
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tbl_Educational_Details> tbl_Educational_Details { get; set; }
        public virtual DbSet<tbl_Employee_Master> tbl_Employee_Master { get; set; }
        public virtual DbSet<tbl_Error_Log> tbl_Error_Log { get; set; }
        public virtual DbSet<tbl_User_Master> tbl_User_Master { get; set; }

        public virtual DbSet<tbl_Designation> Tbl_Designations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Employee_Master>()
                .HasOptional(e => e.tbl_Educational_Details)
                .WithRequired(e => e.tbl_Employee_Master);
        }
    }
}
