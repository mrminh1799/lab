using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("messages")]

public class Message
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    
    [Required]
    [Column("thread_id")]
    public long ThreadId { get; set; }

    [Required]
    [Column("sender_id")]
    public long SenderId { get; set; }

    [Required]
    [Column("message_type")]
    [MaxLength(20)]
    public string MessageType { get; set; } = "text"; // "text", "sticker", "gif", "image", "video", "audio", "file", "location"

    [Column("content", TypeName = "text")]
    public string? Content { get; set; }

    [Column("metadata", TypeName = "json")]
    public string? Metadata { get; set; } // Store as JSON string

    [Required]
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Column("edited_at")]
    public DateTime? EditedAt { get; set; }

    [Column("deleted_at")]
    public DateTime? DeletedAt { get; set; }
    
    
    [ForeignKey(nameof(ThreadId))]
    public virtual Thread Thread { get; set; }
    
}