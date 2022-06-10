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
    public class Company : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Company(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        string tin;
        string email;
        string telephoneNumber;
        string actualaddress;
        string legalAddress;
        int bankAccount;
        string legalForm;
        DateTime registrationDate;
        string description;
        string fullName;

        public string FullName
        {
            get => fullName;
            set => SetPropertyValue(nameof(FullName), ref fullName, value);
        }

        public string Description
        {
            get => description;
            set => SetPropertyValue(nameof(Description), ref description, value);
        }

        public DateTime RegistrationDate
        {
            get => registrationDate;
            set => SetPropertyValue(nameof(RegistrationDate), ref registrationDate, value);
        }
        
        public string Tin
        {
            get => tin;
            set => SetPropertyValue(nameof(Tin), ref tin, value);
        }
        public string LegalForm
        {
            get => legalForm;
            set => SetPropertyValue(nameof(LegalForm), ref legalForm, value);
        }

        public int BankAccount
        {
            get => bankAccount;
            set => SetPropertyValue(nameof(BankAccount), ref bankAccount, value);
        }

        public string LegalAddress
        {
            get => legalAddress;
            set => SetPropertyValue(nameof(LegalAddress), ref legalAddress, value);
        }
        [XafDisplayName("Address")]
        public string ActualAddress
        {
            get => actualaddress;
            set => SetPropertyValue(nameof(ActualAddress), ref actualaddress, value);
        }
        [XafDisplayName("Telephone Number")]
        public string TelephoneNumber
        {
            get => telephoneNumber;
            set => SetPropertyValue(nameof(TelephoneNumber), ref telephoneNumber, value);
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
        [XafDisplayName("Email")]
        
        public string  Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }
    }
}