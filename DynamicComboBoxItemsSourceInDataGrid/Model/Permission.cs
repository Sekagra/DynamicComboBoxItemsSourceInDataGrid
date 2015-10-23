using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicComboBoxItemsSourceInDataGrid.Model
{
    /// <summary>
    /// Just a plain model to populate this sample with data. This would most likely be a EF Entity in your real-life environment.
    /// </summary>
    class Permission
    {
        public OwnerType OwnerType { get; set; }
        public Guid Owner { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
        public bool Delete { get; set; }
    }
}
