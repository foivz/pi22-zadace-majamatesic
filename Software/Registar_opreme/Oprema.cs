
namespace Registar_opreme
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oprema
    {
        public int ID_oprema { get; set; }
        public string nazivOpreme { get; set; }
        public string vrstaOpreme { get; set; }
        public int kolicinaJediniceOpreme { get; set; }
        public int dostupnoOpreme { get; set; }
    }
}
