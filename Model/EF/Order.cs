namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public long ID { get; set; }

        public DateTime? CreateDate { get; set; }

        public long? CustomerID { get; set; }

        [StringLength(100, ErrorMessage = "Tối đa là 100 ký tự")]
        [Required(ErrorMessage = "Cần điền thông tin người nhận")]
        [DisplayName("Người nhận")]
        public string ShipName { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa là 50 ký tự")]
        [Required(ErrorMessage = "Cần điền thông tin số điện thoại người nhận")]
        [DisplayName("Số điện thoại người nhận")]
        public string ShipMobile { get; set; }

        [StringLength(100, ErrorMessage = "Tối đa 100 ký tự")]
        [Required(ErrorMessage = "Cần điền thông tin địa chỉ người nhận")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [DisplayName("Địa chỉ người nhận")]
        public string ShipAddress { get; set; }

        [StringLength(100, ErrorMessage = "Email người nhận")]
        [Required(ErrorMessage = "Cần điền thông tin người nhận")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [DisplayName("Email")]
        public string ShipEmail { get; set; }

        public int? Status { get; set; }
    }
}
