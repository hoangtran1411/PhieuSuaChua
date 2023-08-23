using System.ComponentModel.DataAnnotations;

namespace PhieuSuaChua.Domain_Model
{
    public class ModelTraCuuPhieuMuc
    {
        [Key]
        public int ID_MUC { get; set; }
        public string? LOAI_MAY_IN { get; set; }
        public DateTime? NGAY_GUI { get; set; }
        public DateTime? NGAY_SUA_XONG { get; set; }
        public DateTime? NGAY_TRA { get; set; }
        public string? DON_VI { get; set; }
        public string? TEN_NV { get; set; }
        public string? TEN_HOP_MUC { get; set; }
        public string? TRANG_THAI_PHIEU { get; set; }
        
    }
}
