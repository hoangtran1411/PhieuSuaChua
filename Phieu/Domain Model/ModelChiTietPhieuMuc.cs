using System.ComponentModel.DataAnnotations;

namespace PhieuSuaChua.Domain_Model
{
    public class ModelChiTietPhieuMuc
    {
        [Key]
        public int ID_MUC { get; set; }
        public string? MA_NV_GUI { get; set; }
        public string? TEN_NV_GUI { get; set; }
        public string? DON_VI { get; set; }
        public string? MA_NV_NHAN { get; set; }
        public string? TEN_NV_NHAN { get; set; }
        public string? TEN_HOP_MUC { get; set; }
        public string? TINH_TRANG { get; set; }
        public DateTime? NGAY_GUI { get; set; }
        public DateTime? NGAY_SUA_XONG { get; set; }
        public DateTime? NGAY_TRA { get; set; }
        public string? GHI_CHU { get; set; }
        public string? TRANG_THAI_PHIEU { get; set; }
    }
}
