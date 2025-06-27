/*
 * Copyright (c) 2025 AOLabs
 * This file is part of the AOLabs Herfy project.
 *
 * Licensed under the MIT License.
 * You may obtain a copy of the License at:
 * https://opensource.org/licenses/MIT
 *
 * You are free to use, modify, and distribute this file
 * under the terms of the license.
 */

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HerfyBackend.Core.Models;

public class Message
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(1000)]
    public string Content { get; set; } = null!;

    [Required]
    public Guid SenderId { get; set; }

    [Required]
    public Guid ChatId { get; set; }

    [Required]
    public DateTime Timestamp { get; set; }

    // Relationships
    [ForeignKey("SenderId")]
    public virtual User Sender { get; set; } = new User();

    [ForeignKey("ChatId")]
    public virtual Chat Chat { get; set; } = new Chat();
}
