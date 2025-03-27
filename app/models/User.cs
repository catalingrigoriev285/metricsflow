using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metricsflow.app.models;

public class User
{
    public int id { get; set; }
    public string name { get; set; } = null!;
    public string prename { get; set; } = null!;
    public string email { get; set; } = null!;
    public string password { get; set; } = null!;

    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
}