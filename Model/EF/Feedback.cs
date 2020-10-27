namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public int ID { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa là 50 ký tự")]
        [Required(ErrorMessage = "Cần điền thông tin tên")]
        [DisplayName("Họ tên")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa là 50 ký tự")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [Required(ErrorMessage = "Cần điền thông tin số điện thoại")]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa là 50 ký tự")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [Required(ErrorMessage = "Cần điền thông tin email")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa là 50 ký tự")]
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [StringLength(550, ErrorMessage = "Tối đa là 550 ký tự")]
        [Required(ErrorMessage = "Cần điền nội dung")]
        public string Content { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool ViewStatus { get; set; }

        public bool Status { get; set; }
    }
}
