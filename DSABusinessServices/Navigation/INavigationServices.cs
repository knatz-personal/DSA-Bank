using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace DSABusinessServices.Navigation
{
    [ServiceContract]
    public interface INavigationServices
    {
        #region CRUD

        [OperationContract]
        IQueryable<MenuView> ListAll();

        [OperationContract]
        void Create(MenuView menu);

        [OperationContract]
        MenuView Read(MenuView itemToRead);

        [OperationContract]
        MenuView Update(MenuView updatedItem);

        [OperationContract]
        void Delete(MenuView itemToDelete);

        #endregion

        [OperationContract]
        IEnumerable<MenuView> GetMenuByRole(int roleId);

        [OperationContract]
        IEnumerable<MenuView> GetSubMenus(int roleId);
    }

    [DataContract]
    public class MenuView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? SortOrder { get; set; }

        [DataMember]
        public int? ParentID { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string ActionName { get; set; }

        [DataMember]
        public string ControllerName { get; set; }
    }
}