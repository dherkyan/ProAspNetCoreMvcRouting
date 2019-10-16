using System.Collections.Generic;

namespace ProAspNetCoreMvcRouting.Models
{
    public class Resultado
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public IDictionary<string, object> Data { get; } = new Dictionary<string, object>();
    }
}
