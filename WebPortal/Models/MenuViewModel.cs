using System.Collections.Generic;

namespace WebPortal.Models
{
    public class MenuModel
    {
      
        public int ID { get; set; }


        public string Name { get; set; }


        public int? SortOrder { get; set; }


        public string Url { get; set; }


        public int? ParentID { get; set; }


        public string Description { get; set; }


        public string ActionName { get; set; }

        public string ControllerName { get; set; }
        
    }

    public class MenuViewModel
    {
        public IEnumerable<MenuModel> RootMenu { get; set; }
        public IEnumerable<MenuModel> SubMenu { get; set; }
    }
}