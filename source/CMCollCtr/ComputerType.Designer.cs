﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace CMHealthMon
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ComputerContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ComputerContainer object using the connection string found in the 'ComputerContainer' section of the application configuration file.
        /// </summary>
        public ComputerContainer() : base("name=ComputerContainer", "ComputerContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ComputerContainer object.
        /// </summary>
        public ComputerContainer(string connectionString) : base(connectionString, "ComputerContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ComputerContainer object.
        /// </summary>
        public ComputerContainer(EntityConnection connection) : base(connection, "ComputerContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Computer> ComputerSet
        {
            get
            {
                if ((_ComputerSet == null))
                {
                    _ComputerSet = base.CreateObjectSet<Computer>("ComputerSet");
                }
                return _ComputerSet;
            }
        }
        private ObjectSet<Computer> _ComputerSet;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ComputerSet EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToComputerSet(Computer computer)
        {
            base.AddObject("ComputerSet", computer);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model1", Name="Computer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Computer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Computer object.
        /// </summary>
        /// <param name="computerName">Initial value of the ComputerName property.</param>
        /// <param name="onlineTimeStamp">Initial value of the OnlineTimeStamp property.</param>
        /// <param name="errorTimeStamp">Initial value of the ErrorTimeStamp property.</param>
        /// <param name="healthTimeStamp">Initial value of the HealthTimeStamp property.</param>
        /// <param name="lastRebootDiff">Initial value of the LastRebootDiff property.</param>
        /// <param name="healthUpdateMissingIcon">Initial value of the HealthUpdateMissingIcon property.</param>
        /// <param name="healthInstallationRunningIcon">Initial value of the HealthInstallationRunningIcon property.</param>
        /// <param name="statusMessage">Initial value of the StatusMessage property.</param>
        public static Computer CreateComputer(global::System.String computerName, global::System.DateTime onlineTimeStamp, global::System.DateTime errorTimeStamp, global::System.DateTime healthTimeStamp, global::System.String lastRebootDiff, global::System.Byte[] healthUpdateMissingIcon, global::System.Byte[] healthInstallationRunningIcon, global::System.String statusMessage)
        {
            Computer computer = new Computer();
            computer.ComputerName = computerName;
            computer.OnlineTimeStamp = onlineTimeStamp;
            computer.ErrorTimeStamp = errorTimeStamp;
            computer.HealthTimeStamp = healthTimeStamp;
            computer.LastRebootDiff = lastRebootDiff;
            computer.HealthUpdateMissingIcon = healthUpdateMissingIcon;
            computer.HealthInstallationRunningIcon = healthInstallationRunningIcon;
            computer.StatusMessage = statusMessage;
            return computer;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ComputerName
        {
            get
            {
                return _ComputerName;
            }
            set
            {
                if (_ComputerName != value)
                {
                    OnComputerNameChanging(value);
                    ReportPropertyChanging("ComputerName");
                    _ComputerName = StructuralObject.SetValidValue(value, false, "ComputerName");
                    ReportPropertyChanged("ComputerName");
                    OnComputerNameChanged();
                }
            }
        }
        private global::System.String _ComputerName;
        partial void OnComputerNameChanging(global::System.String value);
        partial void OnComputerNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String IPAddress
        {
            get
            {
                return _IPAddress;
            }
            set
            {
                OnIPAddressChanging(value);
                ReportPropertyChanging("IPAddress");
                _IPAddress = StructuralObject.SetValidValue(value, true, "IPAddress");
                ReportPropertyChanged("IPAddress");
                OnIPAddressChanged();
            }
        }
        private global::System.String _IPAddress;
        partial void OnIPAddressChanging(global::System.String value);
        partial void OnIPAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] HealthIcon
        {
            get
            {
                return StructuralObject.GetValidValue(_HealthIcon);
            }
            set
            {
                OnHealthIconChanging(value);
                ReportPropertyChanging("HealthIcon");
                _HealthIcon = StructuralObject.SetValidValue(value, true, "HealthIcon");
                ReportPropertyChanged("HealthIcon");
                OnHealthIconChanged();
            }
        }
        private global::System.Byte[] _HealthIcon;
        partial void OnHealthIconChanging(global::System.Byte[] value);
        partial void OnHealthIconChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SiteCode
        {
            get
            {
                return _SiteCode;
            }
            set
            {
                OnSiteCodeChanging(value);
                ReportPropertyChanging("SiteCode");
                _SiteCode = StructuralObject.SetValidValue(value, true, "SiteCode");
                ReportPropertyChanged("SiteCode");
                OnSiteCodeChanged();
            }
        }
        private global::System.String _SiteCode;
        partial void OnSiteCodeChanging(global::System.String value);
        partial void OnSiteCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AgentVersion
        {
            get
            {
                return _AgentVersion;
            }
            set
            {
                OnAgentVersionChanging(value);
                ReportPropertyChanging("AgentVersion");
                _AgentVersion = StructuralObject.SetValidValue(value, true, "AgentVersion");
                ReportPropertyChanged("AgentVersion");
                OnAgentVersionChanged();
            }
        }
        private global::System.String _AgentVersion;
        partial void OnAgentVersionChanging(global::System.String value);
        partial void OnAgentVersionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 OnlineStatus
        {
            get
            {
                return _OnlineStatus;
            }
            set
            {
                OnOnlineStatusChanging(value);
                ReportPropertyChanging("OnlineStatus");
                _OnlineStatus = StructuralObject.SetValidValue(value, "OnlineStatus");
                ReportPropertyChanged("OnlineStatus");
                OnOnlineStatusChanged();
            }
        }
        private global::System.Int16 _OnlineStatus = 0;
        partial void OnOnlineStatusChanging(global::System.Int16 value);
        partial void OnOnlineStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime OnlineTimeStamp
        {
            get
            {
                return _OnlineTimeStamp;
            }
            set
            {
                OnOnlineTimeStampChanging(value);
                ReportPropertyChanging("OnlineTimeStamp");
                _OnlineTimeStamp = StructuralObject.SetValidValue(value, "OnlineTimeStamp");
                ReportPropertyChanged("OnlineTimeStamp");
                OnOnlineTimeStampChanged();
            }
        }
        private global::System.DateTime _OnlineTimeStamp;
        partial void OnOnlineTimeStampChanging(global::System.DateTime value);
        partial void OnOnlineTimeStampChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Error
        {
            get
            {
                return _Error;
            }
            set
            {
                OnErrorChanging(value);
                ReportPropertyChanging("Error");
                _Error = StructuralObject.SetValidValue(value, "Error");
                ReportPropertyChanged("Error");
                OnErrorChanged();
            }
        }
        private global::System.Boolean _Error = false;
        partial void OnErrorChanging(global::System.Boolean value);
        partial void OnErrorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ErrorMessage
        {
            get
            {
                return _ErrorMessage;
            }
            set
            {
                OnErrorMessageChanging(value);
                ReportPropertyChanging("ErrorMessage");
                _ErrorMessage = StructuralObject.SetValidValue(value, true, "ErrorMessage");
                ReportPropertyChanged("ErrorMessage");
                OnErrorMessageChanged();
            }
        }
        private global::System.String _ErrorMessage;
        partial void OnErrorMessageChanging(global::System.String value);
        partial void OnErrorMessageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ErrorTimeStamp
        {
            get
            {
                return _ErrorTimeStamp;
            }
            set
            {
                OnErrorTimeStampChanging(value);
                ReportPropertyChanging("ErrorTimeStamp");
                _ErrorTimeStamp = StructuralObject.SetValidValue(value, "ErrorTimeStamp");
                ReportPropertyChanged("ErrorTimeStamp");
                OnErrorTimeStampChanged();
            }
        }
        private global::System.DateTime _ErrorTimeStamp;
        partial void OnErrorTimeStampChanging(global::System.DateTime value);
        partial void OnErrorTimeStampChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime HealthTimeStamp
        {
            get
            {
                return _HealthTimeStamp;
            }
            set
            {
                OnHealthTimeStampChanging(value);
                ReportPropertyChanging("HealthTimeStamp");
                _HealthTimeStamp = StructuralObject.SetValidValue(value, "HealthTimeStamp");
                ReportPropertyChanged("HealthTimeStamp");
                OnHealthTimeStampChanged();
            }
        }
        private global::System.DateTime _HealthTimeStamp;
        partial void OnHealthTimeStampChanging(global::System.DateTime value);
        partial void OnHealthTimeStampChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> LastReboot
        {
            get
            {
                return _LastReboot;
            }
            set
            {
                OnLastRebootChanging(value);
                ReportPropertyChanging("LastReboot");
                _LastReboot = StructuralObject.SetValidValue(value, "LastReboot");
                ReportPropertyChanged("LastReboot");
                OnLastRebootChanged();
            }
        }
        private Nullable<global::System.DateTime> _LastReboot;
        partial void OnLastRebootChanging(Nullable<global::System.DateTime> value);
        partial void OnLastRebootChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] HealthRebootIcon
        {
            get
            {
                return StructuralObject.GetValidValue(_HealthRebootIcon);
            }
            set
            {
                OnHealthRebootIconChanging(value);
                ReportPropertyChanging("HealthRebootIcon");
                _HealthRebootIcon = StructuralObject.SetValidValue(value, true, "HealthRebootIcon");
                ReportPropertyChanged("HealthRebootIcon");
                OnHealthRebootIconChanged();
            }
        }
        private global::System.Byte[] _HealthRebootIcon;
        partial void OnHealthRebootIconChanging(global::System.Byte[] value);
        partial void OnHealthRebootIconChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 HealthRebootStatus
        {
            get
            {
                return _HealthRebootStatus;
            }
            set
            {
                OnHealthRebootStatusChanging(value);
                ReportPropertyChanging("HealthRebootStatus");
                _HealthRebootStatus = StructuralObject.SetValidValue(value, "HealthRebootStatus");
                ReportPropertyChanged("HealthRebootStatus");
                OnHealthRebootStatusChanged();
            }
        }
        private global::System.Int16 _HealthRebootStatus = 0;
        partial void OnHealthRebootStatusChanging(global::System.Int16 value);
        partial void OnHealthRebootStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastRebootDiff
        {
            get
            {
                return _LastRebootDiff;
            }
            set
            {
                OnLastRebootDiffChanging(value);
                ReportPropertyChanging("LastRebootDiff");
                _LastRebootDiff = StructuralObject.SetValidValue(value, false, "LastRebootDiff");
                ReportPropertyChanged("LastRebootDiff");
                OnLastRebootDiffChanged();
            }
        }
        private global::System.String _LastRebootDiff;
        partial void OnLastRebootDiffChanging(global::System.String value);
        partial void OnLastRebootDiffChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] HealthUpdateMissingIcon
        {
            get
            {
                return StructuralObject.GetValidValue(_HealthUpdateMissingIcon);
            }
            set
            {
                OnHealthUpdateMissingIconChanging(value);
                ReportPropertyChanging("HealthUpdateMissingIcon");
                _HealthUpdateMissingIcon = StructuralObject.SetValidValue(value, false, "HealthUpdateMissingIcon");
                ReportPropertyChanged("HealthUpdateMissingIcon");
                OnHealthUpdateMissingIconChanged();
            }
        }
        private global::System.Byte[] _HealthUpdateMissingIcon;
        partial void OnHealthUpdateMissingIconChanging(global::System.Byte[] value);
        partial void OnHealthUpdateMissingIconChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte[] HealthInstallationRunningIcon
        {
            get
            {
                return StructuralObject.GetValidValue(_HealthInstallationRunningIcon);
            }
            set
            {
                OnHealthInstallationRunningIconChanging(value);
                ReportPropertyChanging("HealthInstallationRunningIcon");
                _HealthInstallationRunningIcon = StructuralObject.SetValidValue(value, false, "HealthInstallationRunningIcon");
                ReportPropertyChanged("HealthInstallationRunningIcon");
                OnHealthInstallationRunningIconChanged();
            }
        }
        private global::System.Byte[] _HealthInstallationRunningIcon;
        partial void OnHealthInstallationRunningIconChanging(global::System.Byte[] value);
        partial void OnHealthInstallationRunningIconChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StatusMessage
        {
            get
            {
                return _StatusMessage;
            }
            set
            {
                OnStatusMessageChanging(value);
                ReportPropertyChanging("StatusMessage");
                _StatusMessage = StructuralObject.SetValidValue(value, false, "StatusMessage");
                ReportPropertyChanged("StatusMessage");
                OnStatusMessageChanged();
            }
        }
        private global::System.String _StatusMessage;
        partial void OnStatusMessageChanging(global::System.String value);
        partial void OnStatusMessageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> UsersLoggedOnStatus
        {
            get
            {
                return _UsersLoggedOnStatus;
            }
            set
            {
                OnUsersLoggedOnStatusChanging(value);
                ReportPropertyChanging("UsersLoggedOnStatus");
                _UsersLoggedOnStatus = StructuralObject.SetValidValue(value, "UsersLoggedOnStatus");
                ReportPropertyChanged("UsersLoggedOnStatus");
                OnUsersLoggedOnStatusChanged();
            }
        }
        private Nullable<global::System.Boolean> _UsersLoggedOnStatus;
        partial void OnUsersLoggedOnStatusChanging(Nullable<global::System.Boolean> value);
        partial void OnUsersLoggedOnStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] UsersLoggedOnIcon
        {
            get
            {
                return StructuralObject.GetValidValue(_UsersLoggedOnIcon);
            }
            set
            {
                OnUsersLoggedOnIconChanging(value);
                ReportPropertyChanging("UsersLoggedOnIcon");
                _UsersLoggedOnIcon = StructuralObject.SetValidValue(value, true, "UsersLoggedOnIcon");
                ReportPropertyChanged("UsersLoggedOnIcon");
                OnUsersLoggedOnIconChanged();
            }
        }
        private global::System.Byte[] _UsersLoggedOnIcon;
        partial void OnUsersLoggedOnIconChanging(global::System.Byte[] value);
        partial void OnUsersLoggedOnIconChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> HealthUpdateMissingStatus
        {
            get
            {
                return _HealthUpdateMissingStatus;
            }
            set
            {
                OnHealthUpdateMissingStatusChanging(value);
                ReportPropertyChanging("HealthUpdateMissingStatus");
                _HealthUpdateMissingStatus = StructuralObject.SetValidValue(value, "HealthUpdateMissingStatus");
                ReportPropertyChanged("HealthUpdateMissingStatus");
                OnHealthUpdateMissingStatusChanged();
            }
        }
        private Nullable<global::System.Boolean> _HealthUpdateMissingStatus;
        partial void OnHealthUpdateMissingStatusChanging(Nullable<global::System.Boolean> value);
        partial void OnHealthUpdateMissingStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> HealthInstallationRunningStatus
        {
            get
            {
                return _HealthInstallationRunningStatus;
            }
            set
            {
                OnHealthInstallationRunningStatusChanging(value);
                ReportPropertyChanging("HealthInstallationRunningStatus");
                _HealthInstallationRunningStatus = StructuralObject.SetValidValue(value, "HealthInstallationRunningStatus");
                ReportPropertyChanged("HealthInstallationRunningStatus");
                OnHealthInstallationRunningStatusChanged();
            }
        }
        private Nullable<global::System.Boolean> _HealthInstallationRunningStatus;
        partial void OnHealthInstallationRunningStatusChanging(Nullable<global::System.Boolean> value);
        partial void OnHealthInstallationRunningStatusChanged();

        #endregion

    }

    #endregion

}