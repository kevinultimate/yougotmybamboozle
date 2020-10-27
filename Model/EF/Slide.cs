namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slide")]
    public partial class Slide
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [Required(ErrorMessage ="Cần điền số thứ tự slide")]
        public int? DisplayOrder { get; set; }

        [StringLength(250,ErrorMessage ="Tối đa là 250 ký tự")]
        [Required(ErrorMessage ="Cần điền đường link")]
        public string Link { get; set; }

        [StringLength(250,ErrorMessage ="Tối đa là 250 ký tự")]
        [Required(ErrorMessage ="Cần điền thông tin tiêu đề")]
        public string Title { get; set; }

        [StringLength(500,ErrorMessage ="Tối đa là 500 ký tự")]
        [Required(ErrorMessage ="Cần điền thông tin mô tả")]
        public string Decription { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public bool Status { get; set; }
    }
}
