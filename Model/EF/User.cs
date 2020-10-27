namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public long ID { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa là 50 ký tự")]
        [Required(ErrorMessage = "Cần có Username")]
        [DisplayName("Username")]
        public string UserName { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa là 50 ký tự")]
        [DisplayName("Name")]
        [Required(ErrorMessage = "Cần điền thông tin tên")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Tối đa là 500 ký tự")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [StringLength(100, ErrorMessage = "Tối đa là 100 ký tự")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Cần điên thông tin email")]
        public string Email { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa là 50 ký tự")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [DisplayName("Phone")]
        public string Phone { get; set; }

        [StringLength(500)]
        [DisplayName("Image")]
        public string ImagePath { get; set; }

        [StringLength(20)]
        [DisplayName("Group")]
        public string GroupID { get; set; }

        [StringLength(10)]
        public string CodeConfirm { get; set; }

        public bool? ConfirmStatus { get; set; }

        [StringLength(100)]
        public string ColorWebsite { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public bool Status { get; set; }
    }
}
