using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF6Basic.Models
{
  [Table("school")]
  public class School
  {
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("name", TypeName = "VARCHAR")]
    [Required] // NOT NULL
    [MaxLength(20)]
    public string Name { get; set; } = string.Empty;

    // virtual키워드가 포함된 속성은 가상 속성으로 지정
    // EF에서 지원하는 지원 로딩 기능을 사용할 수 있음.
    public virtual ICollection<Class>? Classes { get; set; }
  }
}


//CREATE TABLE `school` (
//  `id` int NOT NULL AUTO_INCREMENT,
//  `name` varchar(20) NOT NULL,
//  PRIMARY KEY (`id`)
//) 