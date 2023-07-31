namespace PhieuSuaChua.Domain_Model
{
    public class ModelTraCuuPhieu
    {
        public int Id { get; set; }
        public DateTime? Ngaytaophieu { get; set; }
        public string? Hoten { get; set; }
            
        public string? Donvi { get; set; }
        public string? Maytinh { get; set; }
        public string? Thietbikhac { get; set; }
        public string? Trangthaiphieu { get; set; }

        public ModelTraCuuPhieu()
        {
           
        }
    }
}
