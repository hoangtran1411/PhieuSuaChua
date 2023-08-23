
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace PhieuSuaChua.Domain_Model
{
    public class ModelTraCuu
    {
        [Key]
        public List<ModelTraCuuPhieu>? TraCuuPhieus { get; set; }
        [Key]
        public List<ModelTraCuuPhieuMuc>? TraCuuPhieuMucs { get; set; }
    }
}
