using System.ComponentModel.DataAnnotations.Schema;

namespace jet.Bean.model
{
    [Table("base_dic")]
    public class BaseDic :BaseBean
    {
        
        [Column("name")]
        public string? Name { get; set; }
    }
}
