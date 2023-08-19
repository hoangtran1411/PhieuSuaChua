namespace PhieuSuaChua.Domain_Model
{
    public class ModelChiTietPhieuSua
    {
        public int Id { get; set; }
        
        public string? MaNV { get; set; }
        public string? DonVi { get; set; }
        public string? Hoten { get; set; }
        public string? Sdt { get; set; }
        public string? TenMayTinh { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Thietbikhac { get; set; }
        public string? TinhTrang { get; set; }
        public string? GhiChu { get; set; }
        public string? Trangthaiphieu { get; set; }
        public string? LoaiSuaChua { get; set; }
        public DateTime? Ngaynhan { get; set; }
        public DateTime? Ngaytra { get; set; }
        public ModelChiTietPhieuSua()
        {

        }
    }
    

}
   
