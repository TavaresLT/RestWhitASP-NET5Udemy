using System.ComponentModel.DataAnnotations.Schema;

namespace RestWhitASPNET5.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
    }
}
