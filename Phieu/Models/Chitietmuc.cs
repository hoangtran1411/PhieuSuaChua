using System;
using System.Collections.Generic;

namespace PhieuSuaChua.Models;

public partial class Chitietmuc
{
    public int IdChitiet { get; set; }

    public int? IdMuc { get; set; }

    public string? TenHopMuc { get; set; }

    public string? LoaiMayIn { get; set; }

    public string? GhiChu { get; set; }

    public string? TinhTrang { get; set; }

    public virtual Phieumuc? IdMucNavigation { get; set; }
}
