﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.EmployeeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SalaryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenericFaultContract", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    public partial class GenericFaultContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string errorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string stackField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string error {
            get {
                return this.errorField;
            }
            set {
                if ((object.ReferenceEquals(this.errorField, value) != true)) {
                    this.errorField = value;
                    this.RaisePropertyChanged("error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string stack {
            get {
                return this.stackField;
            }
            set {
                if ((object.ReferenceEquals(this.stackField, value) != true)) {
                    this.stackField = value;
                    this.RaisePropertyChanged("stack");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IWCFService")]
    public interface IWCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/GetEmployeeByName", ReplyAction="http://tempuri.org/IWCFService/GetEmployeeByNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Client.EmployeeService.GenericFaultContract), Action="http://tempuri.org/IWCFService/GetEmployeeByNameGenericFaultContractFault", Name="GenericFaultContract", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
        System.Collections.Generic.List<Client.EmployeeService.Employee> GetEmployeeByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/GetEmployeeByName", ReplyAction="http://tempuri.org/IWCFService/GetEmployeeByNameResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Client.EmployeeService.Employee>> GetEmployeeByNameAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFServiceChannel : Client.EmployeeService.IWCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFServiceClient : System.ServiceModel.ClientBase<Client.EmployeeService.IWCFService>, Client.EmployeeService.IWCFService {
        
        public WCFServiceClient() {
        }
        
        public WCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Client.EmployeeService.Employee> GetEmployeeByName(string name) {
            return base.Channel.GetEmployeeByName(name);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Client.EmployeeService.Employee>> GetEmployeeByNameAsync(string name) {
            return base.Channel.GetEmployeeByNameAsync(name);
        }
    }
}