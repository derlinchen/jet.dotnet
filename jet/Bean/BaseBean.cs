using System.ComponentModel.DataAnnotations.Schema;

namespace jet.Bean
{
    public class BaseBean
    {
        [Column("id")]
        public string? Id { get; set; }
    }
}
