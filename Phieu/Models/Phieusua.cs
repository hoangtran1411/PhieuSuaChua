using System;
using System.Collections.Generic;

namespace PhieuSuaChua.Models;

public partial class Phieusua
{
    public int IdPhieu { get; set; }

    public string? MaNv { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayTra { get; set; }

    public string? TrangThaiPhieu { get; set; }

    public DateTime? NgayTiepNhan { get; set; }

    public DateTime? NgaySuaXong { get; set; }

    public string? KtvNhan { get; set; }

    public virtual ICollection<Chitietsua> Chitietsuas { get; set; } = new List<Chitietsua>();

    public virtual Nhanvien? MaNvNavigation { get; set; }
}
