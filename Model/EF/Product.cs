namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long ID { get; set; }

        [StringLength(250, ErrorMessage = "Tối đa là 250 ký tự")]
        [Required(ErrorMessage = "Cần điền thông tin tên")]
        public string Name { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        public string Tag { get; set; }

        [Column(TypeName = "ntext")]
        public string Decription { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImage { get; set; }

        [Required(ErrorMessage = "Cần điền thông giá")]
        [Range(1000, int.MaxValue, ErrorMessage = "Giá không được âm và lớn hơn 1000")]
        public decimal? Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        [StringLength(250, ErrorMessage = "Tối đa là 250 ký tự")]
        public string Translator { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Trọng lượng không đươc âm và lớn hơn 1")]
        public int? Weight { get; set; }

        [Range(10, int.MaxValue, ErrorMessage = "Số trang không được âm và lớn hơn 10")]
        public int? Pages { get; set; }

        [StringLength(50, ErrorMessage = "Tối đa là 50 ký tự")]
        public string Size { get; set; }

        [StringLength(100, ErrorMessage = "Tối đa là 100 ký tự")]
        public string Form { get; set; }

        public bool? IncludeVAT { get; set; }

        [Required(ErrorMessage = "Cần điền thông tin số lượng")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng không được âm")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Cần điền thông năm phát hành")]
        [Range(1, int.MaxValue, ErrorMessage = "Năm phát hành phải hơn 0")]
        public int? PublishYear { get; set; }

        public long? PublisherID { get; set; }

        public long? AuthorID { get; set; }

        public long? CategoryID { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public int? Warranty { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        public string MetaDecription { get; set; }

        public bool? Status { get; set; }

        public DateTime? TopHot { get; set; }

        public long? ViewCount { get; set; }

        public long? SellerCount { get; set; }

        public long? WishCount { get; set; }

        public decimal? ProductStatus { get; set; }

        public int? Star { get; set; }
    }
}
