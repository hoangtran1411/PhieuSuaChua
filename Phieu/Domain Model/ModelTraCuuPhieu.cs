using System.ComponentModel.DataAnnotations;

namespace PhieuSuaChua.Domain_Model
{
    public class ModelTraCuuPhieu
    {
        [Key]
        public int ID_PHIEU { get; set; }
        public DateTime? NGAY_TAO { get; set; }
        public string? TEN_NV { get; set; }
            
        public string? DON_VI { get; set; }
        public string? TEN_PC { get; set; }
        public string? THIET_BI_KHAC { get; set; }
        public string? TRANG_THAI_PHIEU { get; set; }

        public ModelTraCuuPhieu()
        {
           
        }
    }
}
