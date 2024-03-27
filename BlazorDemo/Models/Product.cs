using System;
using System.Collections.Generic;

namespace BlazorDemo.Models;

public partial class Product
{
    public string Id { get; set; } = null!;

    public string? Maker { get; set; }

    public string? Img { get; set; }

    public string? Url { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
}
