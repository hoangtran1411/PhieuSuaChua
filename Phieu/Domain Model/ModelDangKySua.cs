using System.ComponentModel.DataAnnotations;

namespace PhieuSuaChua.Domain_Model
{
    public class ModelDangKySua
    {
        //[Required]
        public string? MaNv { get; set; }
       // [Required(ErrorMessage = "Bạn chưa nhập số điện thoại")]
        public string? Sdt { get; set; }
        public string? TenPC { get; set; }
        public string? User { get; set; }
        public string?  Pass { get; set; }
        public string? Thietbikhac { get; set; }
        public string? Tinhtrang { get; set; }
        public string? TrangThaiPhieu { get; set; }
        public string? LoaiSuaChua { get; set; }

        public string? Ghichu { get; set; }

        public ModelDangKySua() { }
    }
}
