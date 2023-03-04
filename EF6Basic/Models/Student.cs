using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF6Basic.Models
{
  [Table("student")]
  public class Student
  {
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(20)]
    [Required]
    public string Name { get; set; } = string.Empty;

    [Column("birthday")]
    [MaxLength(8)]
    [Required]
    public string Birthday { get; set; } = string.Empty;

    [Column("class_id")]
    public int ClassId { get; set; }

    [ForeignKey("ClassId")]

    public virtual Class? Class { get; set; }
  }
}

//CREATE TABLE `student` (
//  `id` int NOT NULL AUTO_INCREMENT,
//  `name` varchar(20) NOT NULL,
//  `age` int NOT NULL,
//  `class_id` int NOT NULL,
//  PRIMARY KEY (`id`),
//  KEY `IX_class_id` (`class_id`),
//  CONSTRAINT `FK_student_class_class_id` FOREIGN KEY(`class_id`)
//      REFERENCES `class` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
//) 