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

namespace HerfyBackend.Core.Models;

public class User
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    [Phone]
    [MinLength(10)]
    [MaxLength(15)]
    public string Phone { get; set; } = null!;

    [Required]
    public string PasswordHash { get; set; } = null!;

    [Required]
    public string Role { get; set; } = null!; // "client" or "artisan"

    [MaxLength(500)]
    public string? Bio { get; set; }

    [Url]
    public string? ProfileImage { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    public virtual ICollection<Order> OrdersAsClient { get; set; } = new List<Order>();
    public virtual ICollection<Order> OrdersAsArtisan { get; set; } = new List<Order>();
    public virtual ICollection<Chat> ChatsAsClient { get; set; } = new List<Chat>();
    public virtual ICollection<Chat> ChatsAsArtisan { get; set; } = new List<Chat>();
    public virtual ICollection<Review> ReviewsAsClient { get; set; } = new List<Review>();
    public virtual ICollection<Review> ReviewsAsArtisan { get; set; } = new List<Review>();
}
