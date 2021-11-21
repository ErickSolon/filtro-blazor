using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace crudblazor
{
    public partial class Pessoas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Idade { get; set; }
    }
}
