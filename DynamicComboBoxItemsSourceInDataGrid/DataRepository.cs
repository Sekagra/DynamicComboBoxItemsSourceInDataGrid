using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DynamicComboBoxItemsSourceInDataGrid.Model;

namespace DynamicComboBoxItemsSourceInDataGrid
{
    /// <summary>
    /// Just a static data repository; predefined Guids so that the data is coherent
    /// </summary>
    class DataRepository
    {
        public IEnumerable<Group> GetGroups()
        {
            var __list = new List<Group>();
            __list.Add(new Group() { Id = Guid.Parse("7e150024-2952-46af-8079-8162b97bee47"), Name = "Administrators" });
            __list.Add(new Group() { Id = Guid.Parse("9e016146-8801-4d2e-adba-a5e8cb92fed7"), Name = "Users" });
            __list.Add(new Group() { Id = Guid.Parse("b8681823-cb2f-44f4-8602-a8ae11fa1194"), Name = "Guests" });
            return __list;
        }

        public IEnumerable<User> GetUsers()
        {
            var __list = new List<User>();
            __list.Add(new User() { Id = Guid.Parse("7f156247-3b31-4836-9752-7316d7e2efe4"), Username = "Taeyeon", Surname = "Kim", Name = "Taeyeon" });
            __list.Add(new User() { Id = Guid.Parse("c457e5b9-e576-45e5-8240-efee522a6e5f"), Username = "Jessica", Surname = "Jung", Name = "Jessica" });
            __list.Add(new User() { Id = Guid.Parse("88cd1c11-d296-48c0-87a5-f8247263aabb"), Username = "Sunny", Surname = "Lee", Name = "Soonkyu" });
            __list.Add(new User() { Id = Guid.Parse("ba386f18-97f1-4cc2-a6f6-a4bc0d6c8a13"), Username = "Tiffany", Surname = "Hwang", Name = "Tiffany" });
            __list.Add(new User() { Id = Guid.Parse("306a7b5a-2bac-460b-a2a6-d74012793369"), Username = "Hyoyeon", Surname = "Kim", Name = "Hyoyeon" });
            __list.Add(new User() { Id = Guid.Parse("f9aef2de-3a65-4c4c-866c-ffa778f37307"), Username = "Yuri", Surname = "Kwon", Name = "Yuri" });
            __list.Add(new User() { Id = Guid.Parse("3281ba56-622f-4d90-aaf7-67e4b91ccbb2"), Username = "Sooyoung", Surname = "Sooyoung", Name = "Choi" });
            __list.Add(new User() { Id = Guid.Parse("915a386c-b45d-4043-866e-ac9fa3e96d6f"), Username = "Yoona", Surname = "Im", Name = "Yoona" });
            __list.Add(new User() { Id = Guid.Parse("8992ff99-a588-4de3-abc5-7f53b5084ae1"), Username = "Seohyun", Surname = "Seo", Name = "Joohyun" });
            return __list;
        }


        public IEnumerable<Permission> GetPermissions()
        {
            var __list = new List<Permission>();
            __list.Add(new Permission() { OwnerType = OwnerType.GROUP, Owner = Guid.Parse("7e150024-2952-46af-8079-8162b97bee47"), Read = true, Write = true, Delete = true });
            __list.Add(new Permission() { OwnerType = OwnerType.GROUP, Owner = Guid.Parse("b8681823-cb2f-44f4-8602-a8ae11fa1194"), Read = true, Write = false, Delete = false });
            __list.Add(new Permission() { OwnerType = OwnerType.USER, Owner = Guid.Parse("7f156247-3b31-4836-9752-7316d7e2efe4"), Read = true, Write = true, Delete = false });
            __list.Add(new Permission() { OwnerType = OwnerType.USER, Owner = Guid.Parse("88cd1c11-d296-48c0-87a5-f8247263aabb"), Read = true, Write = false, Delete = true });
            __list.Add(new Permission() { OwnerType = OwnerType.USER, Owner = Guid.Parse("ba386f18-97f1-4cc2-a6f6-a4bc0d6c8a13"), Read = true, Write = false, Delete = false });
            __list.Add(new Permission() { OwnerType = OwnerType.USER, Owner = Guid.Parse("3281ba56-622f-4d90-aaf7-67e4b91ccbb2"), Read = true, Write = true, Delete = true });
            __list.Add(new Permission() { OwnerType = OwnerType.USER, Owner = Guid.Parse("915a386c-b45d-4043-866e-ac9fa3e96d6f"), Read = true, Write = false, Delete = false });
            return __list;
        }
    }
}
