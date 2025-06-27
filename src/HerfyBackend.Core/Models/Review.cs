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

public class Review
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    [Range(1, 5)]
    public int Rating { get; set; }

    [MaxLength(500)]
    public string? Comment { get; set; }

    [Required]
    public Guid ClientId { get; set; }

    [Required]
    public Guid ArtisanId { get; set; }

    [Required]
    public Guid OrderId { get; set; }

    [Required]
    public DateTime Date { get; set; }

    // Relationships
    [ForeignKey("ClientId")]
    public virtual User Client { get; set; } = new User();

    [ForeignKey("ArtisanId")]
    public virtual User Artisan { get; set; } = new User();

    [ForeignKey("OrderId")]
    public virtual Order Order { get; set; } = new Order();
}
