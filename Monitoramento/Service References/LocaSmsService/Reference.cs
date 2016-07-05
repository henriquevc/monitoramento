﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Monitoramento.LocaSmsService {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LocaSmsService.ServiceSMSSoap")]
    public interface ServiceSMSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendSMS(string User, string Pwd, Monitoramento.LocaSmsService.rSMS SmsMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SendSMSAsync(string User, string Pwd, Monitoramento.LocaSmsService.rSMS SmsMessage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetStatus(string User, string Pwd, string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStatus", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetStatusAsync(string User, string Pwd, string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStatusByRef", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetStatusByRef(string User, string Pwd, string Id, string Ref);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStatusByRef", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetStatusByRefAsync(string User, string Pwd, string Id, string Ref);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBalance", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetBalance(string User, string Pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBalance", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetBalanceAsync(string User, string Pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetHoldSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SetHoldSMS(string User, string Pwd, string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetHoldSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SetHoldSMSAsync(string User, string Pwd, string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetReleaseSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SetReleaseSMS(string User, string Pwd, string Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetReleaseSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SetReleaseSMSAsync(string User, string Pwd, string Id);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class rSMS : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string subjectField;
        
        private string msgField;
        
        private Destination[] destinationsField;
        
        private System.Nullable<System.DateTime> jobDateTimeField;
        
        private bool flashField;
        
        private bool warningBeginningTransmissionField;
        
        private bool presoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
                this.RaisePropertyChanged("Subject");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Msg {
            get {
                return this.msgField;
            }
            set {
                this.msgField = value;
                this.RaisePropertyChanged("Msg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public Destination[] Destinations {
            get {
                return this.destinationsField;
            }
            set {
                this.destinationsField = value;
                this.RaisePropertyChanged("Destinations");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<System.DateTime> JobDateTime {
            get {
                return this.jobDateTimeField;
            }
            set {
                this.jobDateTimeField = value;
                this.RaisePropertyChanged("JobDateTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool Flash {
            get {
                return this.flashField;
            }
            set {
                this.flashField = value;
                this.RaisePropertyChanged("Flash");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool WarningBeginningTransmission {
            get {
                return this.warningBeginningTransmissionField;
            }
            set {
                this.warningBeginningTransmissionField = value;
                this.RaisePropertyChanged("WarningBeginningTransmission");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool Preso {
            get {
                return this.presoField;
            }
            set {
                this.presoField = value;
                this.RaisePropertyChanged("Preso");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Destination : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string numberField;
        
        private string nameField;
        
        private string refField;
        
        private string param1Field;
        
        private string param2Field;
        
        private string param3Field;
        
        private string param4Field;
        
        private string param5Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
                this.RaisePropertyChanged("Number");
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
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
                this.RaisePropertyChanged("Ref");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Param1 {
            get {
                return this.param1Field;
            }
            set {
                this.param1Field = value;
                this.RaisePropertyChanged("Param1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Param2 {
            get {
                return this.param2Field;
            }
            set {
                this.param2Field = value;
                this.RaisePropertyChanged("Param2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Param3 {
            get {
                return this.param3Field;
            }
            set {
                this.param3Field = value;
                this.RaisePropertyChanged("Param3");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Param4 {
            get {
                return this.param4Field;
            }
            set {
                this.param4Field = value;
                this.RaisePropertyChanged("Param4");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Param5 {
            get {
                return this.param5Field;
            }
            set {
                this.param5Field = value;
                this.RaisePropertyChanged("Param5");
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
    public interface ServiceSMSSoapChannel : Monitoramento.LocaSmsService.ServiceSMSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSMSSoapClient : System.ServiceModel.ClientBase<Monitoramento.LocaSmsService.ServiceSMSSoap>, Monitoramento.LocaSmsService.ServiceSMSSoap {
        
        public ServiceSMSSoapClient() {
        }
        
        public ServiceSMSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSMSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSMSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSMSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SendSMS(string User, string Pwd, Monitoramento.LocaSmsService.rSMS SmsMessage) {
            return base.Channel.SendSMS(User, Pwd, SmsMessage);
        }
        
        public System.Threading.Tasks.Task<string> SendSMSAsync(string User, string Pwd, Monitoramento.LocaSmsService.rSMS SmsMessage) {
            return base.Channel.SendSMSAsync(User, Pwd, SmsMessage);
        }
        
        public System.Data.DataSet GetStatus(string User, string Pwd, string Id) {
            return base.Channel.GetStatus(User, Pwd, Id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetStatusAsync(string User, string Pwd, string Id) {
            return base.Channel.GetStatusAsync(User, Pwd, Id);
        }
        
        public System.Data.DataSet GetStatusByRef(string User, string Pwd, string Id, string Ref) {
            return base.Channel.GetStatusByRef(User, Pwd, Id, Ref);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetStatusByRefAsync(string User, string Pwd, string Id, string Ref) {
            return base.Channel.GetStatusByRefAsync(User, Pwd, Id, Ref);
        }
        
        public string GetBalance(string User, string Pwd) {
            return base.Channel.GetBalance(User, Pwd);
        }
        
        public System.Threading.Tasks.Task<string> GetBalanceAsync(string User, string Pwd) {
            return base.Channel.GetBalanceAsync(User, Pwd);
        }
        
        public string SetHoldSMS(string User, string Pwd, string Id) {
            return base.Channel.SetHoldSMS(User, Pwd, Id);
        }
        
        public System.Threading.Tasks.Task<string> SetHoldSMSAsync(string User, string Pwd, string Id) {
            return base.Channel.SetHoldSMSAsync(User, Pwd, Id);
        }
        
        public string SetReleaseSMS(string User, string Pwd, string Id) {
            return base.Channel.SetReleaseSMS(User, Pwd, Id);
        }
        
        public System.Threading.Tasks.Task<string> SetReleaseSMSAsync(string User, string Pwd, string Id) {
            return base.Channel.SetReleaseSMSAsync(User, Pwd, Id);
        }
    }
}
