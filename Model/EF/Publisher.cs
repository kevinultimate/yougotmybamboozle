namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Publisher")]
    public partial class Publisher
    {
        public long ID { get; set; }

        [StringLength(200, ErrorMessage = "Tối đa là 200 ký tự")]
        [Required(ErrorMessage = "Cần điền thông tin tên")]
        public string Name { get; set; }

        [StringLength(200)]
        public string MetaTitle { get; set; }

        [StringLength(200)]
        public string Tag { get; set; }

        [StringLength(500, ErrorMessage = "Tối đa là 500 ký tự")]
        public string Address { get; set; }

        [StringLength(30, ErrorMessage = "Tối đa là 30 ký tự")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [Required(ErrorMessage = "Cần điền thông tin số điện thoại")]
        public string Phone { get; set; }

        [StringLength(30, ErrorMessage = "Tối đa là 30 ký tự")]
        public string Fax { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa là 50 ký tự")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [Required(ErrorMessage = "Cần điền thông tin email")]
        public string Email { get; set; }

        [StringLength(500, ErrorMessage = "Tối đa là 500 ký tự")]
        [Required(ErrorMessage = "Cần điền thông tin trang web")]
        public string Website { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public bool Status { get; set; }
    }
}
