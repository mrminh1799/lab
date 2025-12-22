using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

[Table("thread_members")]
public class ThreadMember
{
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    [Required]
    [Column("thread_id")]
    public long ThreadId { get; set; }

    [Required]
    [Column("user_id")]
    public long UserId { get; set; }

    [Column("nickname")]
    [MaxLength(100)]
    public string? Nickname { get; set; }

    [Required]
    [Column("muted")]
    public bool Muted { get; set; } = false;

    [Required]
    [Column("notifications_enabled")]
    public bool NotificationsEnabled { get; set; } = true;

    [Required]
    [Column("joined_at")]
    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

    [ForeignKey(nameof(ThreadId))]
    public virtual Thread Thread { get; set; }
}