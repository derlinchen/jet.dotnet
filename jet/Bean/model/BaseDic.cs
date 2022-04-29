using System.ComponentModel.DataAnnotations.Schema;

namespace jet.Bean.model
{
    [Table("base_dic")]
    public class BaseDic
    {
        [Column("id")]
        public string? Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }
    }
}
