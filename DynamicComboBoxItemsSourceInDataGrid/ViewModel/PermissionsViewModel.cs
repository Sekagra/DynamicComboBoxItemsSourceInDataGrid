using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using DynamicComboBoxItemsSourceInDataGrid.Model;

namespace DynamicComboBoxItemsSourceInDataGrid.ViewModel
{
    class PermissionsViewModel
    {
        #region Fields/Properties
            public IEnumerable<User> Users { get; private set; }
            public IEnumerable<Group> Groups { get; private set; }
            public IEnumerable<OwnerType> OwnerTypes { get; private set; }

            public IEnumerable<Permission> Permissions { get; private set; }
        #endregion

        #region Constructor
            public PermissionsViewModel()
            {
                var __repository = new DataRepository();
                Permissions = __repository.GetPermissions();
                Groups = __repository.GetGroups();
                Users = __repository.GetUsers();

                OwnerTypes = System.Enum.GetValues(typeof(OwnerType)).OfType<OwnerType>().ToList();
                //It's of course possible to bind directly to the enum in the XAML, but that would tie up the View with the Model.
                //However, if you are interested in how this would be done, check out the "InstructionEditor.xaml" in my "TuringMachine" implementation:
                //http://sekagra.com/wp/2011/11/turning-machine-simulator/
            }
        #endregion
    }
}
