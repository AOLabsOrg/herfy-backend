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
// hamda 

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HerfyBackend.Core.Models;

public class Product
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(1000)]
    public string Description { get; set; } = null!;

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal Price { get; set; }

    [Required]
    public string Category { get; set; } = null!; // "heritage" or "other"

    [Required]
    public List<string> Images { get; set; } = new List<string>();

    [MaxLength(500)]
    public string? ArtisanStory { get; set; }

    [Required]
    public Guid ArtisanId { get; set; }

    // Relationships
    [ForeignKey("ArtisanId")]
    public virtual User Artisan { get; set; } = new User();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
