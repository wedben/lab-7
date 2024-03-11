using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public class V3discipline
    {
        public string Title { get; } 
        public string Reduction { get;} 
        public V3discipline(string title, string reduction)
        {
            Title = title;
            Reduction = reduction;
        }
    }
}

