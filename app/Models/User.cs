using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metricsflow.app.Models;

public class User
{
    public int id { get; set; }
    public string username { get; set; } = null!;
    public string password { get; set; } = null!;
    public string email { get; set; } = null!;
    public string role { get; set; } = null!;
}