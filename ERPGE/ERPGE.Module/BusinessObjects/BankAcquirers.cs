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
    public class BankAcquirers : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public BankAcquirers(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string createdUSer;
        DateTime createdDate;
        string acquirer;
        string terminalNumber;
        string bankAccount;
        string organization;
        string owner;
        string uniqueCode;
        object fullName;
        [XafDisplayName("Name"), ToolTip("Message")]
        public object FullName
        {
            get => fullName;
            set => SetPropertyValue(nameof(FullName), ref fullName, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string UniqueCode
        {
            get => uniqueCode;
            set => SetPropertyValue(nameof(UniqueCode), ref uniqueCode, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Owner
        {
            get => owner;
            set => SetPropertyValue(nameof(Owner), ref owner, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Organization
        {
            get => organization;
            set => SetPropertyValue(nameof(Organization), ref organization, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string BankAccount
        {
            get => bankAccount;
            set => SetPropertyValue(nameof(BankAccount), ref bankAccount, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string TerminalNumber
        {
            get => terminalNumber;
            set => SetPropertyValue(nameof(TerminalNumber), ref terminalNumber, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Acquirer
        {
            get => acquirer;
            set => SetPropertyValue(nameof(Acquirer), ref acquirer, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public DateTime CreatedDate
        {
            get => createdDate;
            set => SetPropertyValue(nameof(CreatedDate), ref createdDate, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string CreatedUSer
        {
            get => createdUSer;
            set => SetPropertyValue(nameof(CreatedUSer), ref createdUSer, value);
        }
    }
}