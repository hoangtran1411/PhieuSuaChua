using System.ComponentModel.DataAnnotations;

namespace PhieuSuaChua.Domain_Model
{
    public class ModelDangKySua
    {
        [Required]
        public string? MaNv { get; set; }
        public string? Sdt { get; set; }
        public string? TenPC { get; set; }
        public string? User { get; set; }
        public string?  Pass { get; set; }
        public string? Thietbikhac { get; set; }
        public string? Tinhtrang { get; set; }
        public string? Ghichu { get; set; }

        public ModelDangKySua() { }
    }
}
