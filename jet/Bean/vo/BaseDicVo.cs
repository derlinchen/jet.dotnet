using System.ComponentModel.DataAnnotations.Schema;

namespace jet.Bean.vo
{
    public class BaseDicVo
    {
        [Column("id")]
        public string? Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }
    }
}
