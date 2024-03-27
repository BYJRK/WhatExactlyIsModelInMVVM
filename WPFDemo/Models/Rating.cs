using System;
using System.Collections.Generic;

namespace WPFDemo.Models;

public partial class Rating
{
    public int Id { get; set; }

    public int Score { get; set; }

    public string? ProductId { get; set; }

    public virtual Product? Product { get; set; }
}
