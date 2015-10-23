using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicComboBoxItemsSourceInDataGrid.Model
{
    /// <summary>
    /// Just a plain model to populate this sample with data. This would most likely be a EF Entity in your real-life environment.
    /// </summary>
    class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        //... and many more like eMail, Address etc.
    }
}
