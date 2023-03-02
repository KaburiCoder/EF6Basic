using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF6Basic.Models
{
  [Table("class")]
  public class Class
  {
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(20)]
    [Required]
    public string Name { get; set; } = string.Empty;

    [Column("school_id")]
    public int SchoolId { get; set; }

    [ForeignKey("SchoolId")]
    public virtual School? School { get; set; }

    public virtual ICollection<Student>? Students { get; set; }
  }
}

//CREATE TABLE `class` (
//  `id` int NOT NULL AUTO_INCREMENT,
//  `name` varchar(20) NOT NULL,
//  `school_id` int NOT NULL,
//  PRIMARY KEY (`id`),
//  KEY `IX_school_id` (`school_id`),
//  CONSTRAINT `FK_class_school_school_id` FOREIGN KEY(`school_id`)
//      REFERENCES `school` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
//) 