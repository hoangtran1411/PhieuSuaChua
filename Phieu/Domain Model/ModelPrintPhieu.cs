using System.ComponentModel.DataAnnotations;

namespace PhieuSuaChua.Domain_Model
{
    public class ModelPrintPhieu
    {
        [Key]
        public int ID_PHIEU { get; set; }
        public string? MA_NV { get; set; }
        public string? TEN_NV { get; set; }
        public string? DON_VI { get; set; }
        public string? CHUC_DANH { get; set; }
        public DateTime? NGAY_TIEP_NHAN { get; set; }
        public string? KTV_NHAN { get; set; }
        public string? TEN_PC { get; set; }
        public string? ACCOUNT_NAMES { get; set; }
        public string? ACCOUNT_PASS { get; set; }
        public string? THIET_BI_KHAC { get; set; }
        public string? TINH_TRANG { get; set; }
        public string? GHI_CHU { get; set; }
        public string? SDT { get; set; }
    }
}
