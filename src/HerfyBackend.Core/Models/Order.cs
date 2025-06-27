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

public class Order
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    [Required]
    public Guid ClientId { get; set; }

    [Required]
    public Guid ArtisanId { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }

    [Required]
    [Range(0.01, double.MaxValue)]
    public decimal TotalPrice { get; set; }

    [Required]
    public string Status { get; set; } = null!; // "pending", "completed", "cancelled"

    [Required]
    public DateTime Date { get; set; }

    // Relationships
    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; } = new Product();

    [ForeignKey("ClientId")]
    public virtual User Client { get; set; } = new User();

    [ForeignKey("ArtisanId")]
    public virtual User Artisan { get; set; } = new User();
}
