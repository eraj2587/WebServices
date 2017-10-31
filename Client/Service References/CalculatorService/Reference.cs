﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CalculatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorService.CalculatorServiceSoap")]
    public interface CalculatorServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        // CODEGEN: Generating message contract since message GetEmployeeByNameRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetEmployeeByName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Client.CalculatorService.GetEmployeeByNameResponse GetEmployeeByName(Client.CalculatorService.GetEmployeeByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetEmployeeByName", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.CalculatorService.GetEmployeeByNameResponse> GetEmployeeByNameAsync(Client.CalculatorService.GetEmployeeByNameRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UserDetail : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string userNameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("userName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Employee : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nameField;
        
        private string addressField;
        
        private int salaryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int Salary {
            get {
                return this.salaryField;
            }
            set {
                this.salaryField = value;
                this.RaisePropertyChanged("Salary");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeByName", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeeByNameRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Client.CalculatorService.UserDetail UserDetail;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string name;
        
        public GetEmployeeByNameRequest() {
        }
        
        public GetEmployeeByNameRequest(Client.CalculatorService.UserDetail UserDetail, string name) {
            this.UserDetail = UserDetail;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeByNameResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetEmployeeByNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public Client.CalculatorService.Employee[] GetEmployeeByNameResult;
        
        public GetEmployeeByNameResponse() {
        }
        
        public GetEmployeeByNameResponse(Client.CalculatorService.Employee[] GetEmployeeByNameResult) {
            this.GetEmployeeByNameResult = GetEmployeeByNameResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorServiceSoapChannel : Client.CalculatorService.CalculatorServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceSoapClient : System.ServiceModel.ClientBase<Client.CalculatorService.CalculatorServiceSoap>, Client.CalculatorService.CalculatorServiceSoap {
        
        public CalculatorServiceSoapClient() {
        }
        
        public CalculatorServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.CalculatorService.GetEmployeeByNameResponse Client.CalculatorService.CalculatorServiceSoap.GetEmployeeByName(Client.CalculatorService.GetEmployeeByNameRequest request) {
            return base.Channel.GetEmployeeByName(request);
        }
        
        public Client.CalculatorService.Employee[] GetEmployeeByName(Client.CalculatorService.UserDetail UserDetail, string name) {
            Client.CalculatorService.GetEmployeeByNameRequest inValue = new Client.CalculatorService.GetEmployeeByNameRequest();
            inValue.UserDetail = UserDetail;
            inValue.name = name;
            Client.CalculatorService.GetEmployeeByNameResponse retVal = ((Client.CalculatorService.CalculatorServiceSoap)(this)).GetEmployeeByName(inValue);
            return retVal.GetEmployeeByNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.CalculatorService.GetEmployeeByNameResponse> Client.CalculatorService.CalculatorServiceSoap.GetEmployeeByNameAsync(Client.CalculatorService.GetEmployeeByNameRequest request) {
            return base.Channel.GetEmployeeByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.CalculatorService.GetEmployeeByNameResponse> GetEmployeeByNameAsync(Client.CalculatorService.UserDetail UserDetail, string name) {
            Client.CalculatorService.GetEmployeeByNameRequest inValue = new Client.CalculatorService.GetEmployeeByNameRequest();
            inValue.UserDetail = UserDetail;
            inValue.name = name;
            return ((Client.CalculatorService.CalculatorServiceSoap)(this)).GetEmployeeByNameAsync(inValue);
        }
    }
}