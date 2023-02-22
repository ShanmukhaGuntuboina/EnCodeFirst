namespace EntityCodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Employee_Master
    {
        [Key]
        public int Employee_Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Employee_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Contact_No { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Address_Line1 { get; set; }

        [StringLength(100)]
        public string Address_Line2 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(10)]
        public string Zip_Code { get; set; }

        public bool Active_Status { get; set; }

        public virtual tbl_Educational_Details tbl_Educational_Details { get; set; }
    }
}
