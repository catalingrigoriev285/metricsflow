using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metricsflow.app.models;

public class ModelHasRole
{
    public int id { get; set; }
    public int role_id { get; set; }
    public int model_id { get; set; }
    public string model_type { get; set; } = null!;
}