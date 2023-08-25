using System;
using System.Collections.Generic;

namespace PhieuSuaChua.Models;

public partial class Nhanvien
{
    public string MaNv { get; set; } = null!;

    public string? TenNv { get; set; }

    public string? DonVi { get; set; }

    public string? ChucDanh { get; set; }

    public int? Quyen { get; set; }

    public virtual ICollection<Phieumuc> Phieumucs { get; set; } = new List<Phieumuc>();

    public virtual ICollection<Phieusua> Phieusuas { get; set; } = new List<Phieusua>();
}
