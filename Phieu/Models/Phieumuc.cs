using System;
using System.Collections.Generic;

namespace PhieuSuaChua.Models;

public partial class Phieumuc
{
    public int IdMuc { get; set; }

    public string? MaNvGui { get; set; }

    public string? MaNvNhan { get; set; }

    public DateTime? NgayGui { get; set; }

    public DateTime? NgayTra { get; set; }

    public string? TrangThaiPhieu { get; set; }

    public DateTime? NgaySuaXong { get; set; }

    public virtual ICollection<Chitietmuc> Chitietmucs { get; set; } = new List<Chitietmuc>();

    public virtual Nhanvien? MaNvGuiNavigation { get; set; }
}
