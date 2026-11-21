using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace PKHDuong_241230693.Models
{
    [ModelMetadataType(typeof(PKHDTaiSanMeta))]
    public partial class TaiSan { }
    public class PKHDTaiSanMeta
    {
        [Required(ErrorMessage = "ten tai san khong de trong")]
        public string TenTS { get; set; } = null;

        [Required(ErrorMessage = "nguyen gia phai tu 1-2000")]
        [Range(typeof(decimal), "1", "2000", ErrorMessage =" nguyen gia phai tu 1-2000")]
        public decimal? NguyenGia { get; set; }

        [RegularExpression(@"^.+\.(jpg|jpeg|png|webp)$", ErrorMessage = "Ảnh phải có đuôi .jpg, .jpeg, .png hoặc .webp")]
        public string? Anh {  get; set; }
        
    }
}
