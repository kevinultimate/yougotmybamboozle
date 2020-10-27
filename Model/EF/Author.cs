namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Author")]
    public partial class Author
    {
        public long ID { get; set; }

        [StringLength(250, ErrorMessage = "Tối đa là 250 ký tự")]
        [Required(ErrorMessage = "Cần điền thông tin tên")]
        public string Name { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        public string Tag { get; set; }

        public DateTime? Birth { get; set; }

        public DateTime? DateOfDeath { get; set; }

        [StringLength(250, ErrorMessage = "Tối đa là 250 ký tự")]
        [DisplayName("Pseudonym")]
        public string NickName { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [StringLength(250, ErrorMessage = "Tối đa là 250 ký tự")]
        public string PlaceOfBirth { get; set; }

        [StringLength(500, ErrorMessage = "Tối đa là 250 ký tự")]
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
