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
    public class SupplierClient : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public SupplierClient(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string additional;
        string other;
        string email;
        string telephoneNumber;
        string actualAddress;
        string legalAddress;
        string mainBankAccount;
        string country;
        string legalForm;
        string tIN;
        string vatTaxable;
        string fullName;
        string description;
        string parent;

        public string Parent
        {
            get => parent;
            set => SetPropertyValue(nameof(Parent), ref parent, value);
        }

        public string Description
        {
            get => description;
            set => SetPropertyValue(nameof(Description), ref description, value);
        }

        public string FullName
        {
            get => fullName;
            set => SetPropertyValue(nameof(FullName), ref fullName, value);
        }

        public string VatTaxable
        {
            get => vatTaxable;
            set => SetPropertyValue(nameof(VatTaxable), ref vatTaxable, value);
        }

        public string TIN
        {
            get => tIN;
            set => SetPropertyValue(nameof(TIN), ref tIN, value);
        }

        public string LegalForm
        {
            get => legalForm;
            set => SetPropertyValue(nameof(LegalForm), ref legalForm, value);
        }

        public string Country
        {
            get => country;
            set => SetPropertyValue(nameof(Country), ref country, value);
        }

        public string MainBankAccount
        {
            get => mainBankAccount;
            set => SetPropertyValue(nameof(MainBankAccount), ref mainBankAccount, value);
        }

        public string LegalAddress
        {
            get => legalAddress;
            set => SetPropertyValue(nameof(LegalAddress), ref legalAddress, value);
        }

        public string ActualAddress
        {
            get => actualAddress;
            set => SetPropertyValue(nameof(ActualAddress), ref actualAddress, value);
        }

        public string TelephoneNumber
        {
            get => telephoneNumber;
            set => SetPropertyValue(nameof(TelephoneNumber), ref telephoneNumber, value);
        }

        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }

        public string Other
        {
            get => other;
            set => SetPropertyValue(nameof(Other), ref other, value);
        }
        
        public string Additional
        {
            get => additional;
            set => SetPropertyValue(nameof(Additional), ref additional, value);
        }
    }
}