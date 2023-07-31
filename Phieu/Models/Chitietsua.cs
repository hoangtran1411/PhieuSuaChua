using System;
using System.Collections.Generic;

namespace PhieuSuaChua.Models;

public partial class Chitietsua
{
    public int IdChitiet { get; set; }

    public int? IdPhieu { get; set; }

    public string? TenPc { get; set; }

    public string? AccountNames { get; set; }

    public string? AccountPass { get; set; }

    public string? ThietBiKhac { get; set; }

    public string? TinhTrang { get; set; }

    public string? GhiChu { get; set; }

    public string? LoaiSuaChua { get; set; }

    public string? Sdt { get; set; }

    public virtual Phieusua? IdPhieuNavigation { get; set; }
}
