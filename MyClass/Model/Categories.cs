using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int Id { get; set; }

        [Required]
<<<<<<< HEAD
        [Display(Name = "Tên loại SP")]
        public string Name { get; set; }
        [Display(Name = "Tên rút gọn")]
        public string Slug { get; set; }
        [Display(Name = "Cấp cha")]
        public int? ParentId { get; set; }
        [Display(Name = "Sắp xếp")]
        public int? Order { get; set; }

        [Required]
        [Display(Name = "Mô tả")]
        public string MetaDesc { get; set; }

        [Required]
        [Display(Name = "Từ khóa")]
        public string MetaKey { get; set; }
        [Display(Name = "Tạo bởi")]
        public int CreateBy { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreateAt { get; set; }
        [Display(Name = "Cập nhật bởi")]
        public int UpdateBy { get; set; }
        [Display(Name = "Ngày cập nhật")]
        public DateTime UpdateAt { get; set; }
        [Display(Name = "Trạng thái")]
=======
        public string Name { get; set; }

        public string Slug { get; set; }

        public int? ParentId { get; set; }

        public int? Order { get; set; }

        [Required]
        public string MetaDesc { get; set; }

        [Required]
        public string MetaKey { get; set; }

        public int CreateBy { get; set; }

        public DateTime CreateAt { get; set; }

        public int UpdateBy { get; set; }

        public DateTime UpdateAt { get; set; }

>>>>>>> 6fdddaac5faa2232e986e17f82f79ae9b2468c43
        public int Status { get; set; }
    }
}