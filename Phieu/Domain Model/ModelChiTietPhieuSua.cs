using System.ComponentModel.DataAnnotations;

namespace PhieuSuaChua.Domain_Model
{
    public class ModelChiTietPhieuSua
    {
        [Key]
        public int ID_PHIEU { get; set; }
        public string? MA_NV { get; set; }
        public string? DON_VI { get; set; }
        public string? TEN_NV { get; set; }
        public string? SDT { get; set; }
        public string? TEN_PC { get; set; }
        public string? ACCOUNT_NAMES { get; set; }
        public string? ACCOUNT_PASS { get; set; }
        public string? THIET_BI_KHAC { get; set; }
        public string? TINH_TRANG { get; set; }
        public string? GHI_CHU { get; set; }
        public string? TRANG_THAI_PHIEU { get; set; }
        public string? LOAI_SUA_CHUA { get; set; }
        public DateTime? NGAY_TAO { get; set; }
        public DateTime? NGAY_TRA { get; set; }
        public DateTime? NGAY_TIEP_NHAN { get; set; }
        public DateTime? NGAY_SUA_XONG { get; set; }
        public ModelChiTietPhieuSua()
        {

        }
    }
    

}
   
