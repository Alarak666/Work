using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ERPGE.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Division : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Division(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        int createdUser;
        DateTime createdDate;
        string parentDivision;
        string ownerParent;
        string uniqueCode;
        string fullName;

        public string FullName
        {
            get => fullName;
            set => SetPropertyValue(nameof(FullName), ref fullName, value);
        }

        public string UniqueCode
        {
            get => uniqueCode;
            set => SetPropertyValue(nameof(UniqueCode), ref uniqueCode, value);
        }

        public string OwnerParent //?
        {
            get => ownerParent;
            set => SetPropertyValue(nameof(OwnerParent), ref ownerParent, value);
        }
        public string ParentDivision
        {
            get => parentDivision;
            set => SetPropertyValue(nameof(ParentDivision), ref parentDivision, value);
        }
        public DateTime CreatedDate
        {
            get => createdDate;
            set => SetPropertyValue(nameof(CreatedDate), ref createdDate, value);
        }

        public int CreatedUser
        {
            get => createdUser;
            set => SetPropertyValue(nameof(CreatedUser), ref createdUser, value);
        }
    }
}