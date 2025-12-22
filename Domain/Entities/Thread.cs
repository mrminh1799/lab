using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("threads")]
public class Thread
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    [Column("thread_type")]
    [MaxLength(20)]
    public string ThreadType { get; set; } = "one_to_one";

    [Column("name")]
    [MaxLength(255)]
    public string? Name { get; set; }

    [Column("image_url")]
    [MaxLength(500)]
    public string? ImageUrl { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Required]
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Column("last_message_at")]
    public DateTime? LastMessageAt { get; set; }
    
    public virtual ICollection<ThreadMember> ThreadMembers { get; set; } = new List<ThreadMember>();
    
}