using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("app_domain")]
public class AppDomain
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Code { get; set; }

    [MaxLength(500)]
    public string Description { get; set; }

    [MaxLength(255)]
    public string Name { get; set; }

    [MaxLength(100)]
    public string Value { get; set; }

    [MaxLength(100)]
    public string Type { get; set; }   
    
}