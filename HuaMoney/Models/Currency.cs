using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HuaMoney.Models;

public class Currency
{
    [Key] 
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
}  