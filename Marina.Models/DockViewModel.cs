using Marina.Utils;
using System.Collections.Generic;

namespace Marina.Models
{
    public class DockViewModel
    {
        public IEnumerable<Dock> Docks { get; set; }
        public Dock SelectedDock { get; set; }
        public PaginatedList<Slip> PaginatedSlips { get; set; }
    }
}
