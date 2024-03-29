﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lonsun.API.EChi {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EChi.SendSmsSoap")]
    public interface SendSmsSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetPrice", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetPrice(string suser, string spass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int SendSMS(string suser, string spass, string telList, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int SendSMSTime(string suser, string spass, string telList, string content, string datetime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSE", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int SendSMSE(string suser, string spass, string telList, string content, string extnum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSLM", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int SendSMSLM(string suser, string spass, string telList, string content, string islongmsg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSLots", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int SendSMSLots(string suser, string spass, string telList, string content, long lot);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSMore", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int SendSMSMore(string suser, string spass, string telLists, string contents, string lots);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetReadback", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetReadback(string suser, string spass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetReadbackt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetReadbackt(string suser, string spass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetReadState", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetReadState(string suser, string spass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetReadStatet", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetReadStatet(string suser, string spass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSendState", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSendState(string suser, string spass, string uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSendStatet", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetSendStatet(string suser, string spass, string uid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFatherName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetFatherName(string suser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSonPrice", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSonPrice(string suser, string spass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetSonPrice", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SetSonPrice(string suser, string spass, int recharge, string rcuser);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SendSmsSoapChannel : Lonsun.API.EChi.SendSmsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendSmsSoapClient : System.ServiceModel.ClientBase<Lonsun.API.EChi.SendSmsSoap>, Lonsun.API.EChi.SendSmsSoap {
        
        public SendSmsSoapClient() {
        }
        
        public SendSmsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SendSmsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendSmsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendSmsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPrice(string suser, string spass) {
            return base.Channel.GetPrice(suser, spass);
        }
        
        public int SendSMS(string suser, string spass, string telList, string content) {
            return base.Channel.SendSMS(suser, spass, telList, content);
        }
        
        public int SendSMSTime(string suser, string spass, string telList, string content, string datetime) {
            return base.Channel.SendSMSTime(suser, spass, telList, content, datetime);
        }
        
        public int SendSMSE(string suser, string spass, string telList, string content, string extnum) {
            return base.Channel.SendSMSE(suser, spass, telList, content, extnum);
        }
        
        public int SendSMSLM(string suser, string spass, string telList, string content, string islongmsg) {
            return base.Channel.SendSMSLM(suser, spass, telList, content, islongmsg);
        }
        
        public int SendSMSLots(string suser, string spass, string telList, string content, long lot) {
            return base.Channel.SendSMSLots(suser, spass, telList, content, lot);
        }
        
        public int SendSMSMore(string suser, string spass, string telLists, string contents, string lots) {
            return base.Channel.SendSMSMore(suser, spass, telLists, contents, lots);
        }
        
        public System.Data.DataSet GetReadback(string suser, string spass) {
            return base.Channel.GetReadback(suser, spass);
        }
        
        public string GetReadbackt(string suser, string spass) {
            return base.Channel.GetReadbackt(suser, spass);
        }
        
        public System.Data.DataSet GetReadState(string suser, string spass) {
            return base.Channel.GetReadState(suser, spass);
        }
        
        public string GetReadStatet(string suser, string spass) {
            return base.Channel.GetReadStatet(suser, spass);
        }
        
        public System.Data.DataSet GetSendState(string suser, string spass, string uid) {
            return base.Channel.GetSendState(suser, spass, uid);
        }
        
        public string GetSendStatet(string suser, string spass, string uid) {
            return base.Channel.GetSendStatet(suser, spass, uid);
        }
        
        public string GetFatherName(string suser) {
            return base.Channel.GetFatherName(suser);
        }
        
        public System.Data.DataSet GetSonPrice(string suser, string spass) {
            return base.Channel.GetSonPrice(suser, spass);
        }
        
        public string SetSonPrice(string suser, string spass, int recharge, string rcuser) {
            return base.Channel.SetSonPrice(suser, spass, recharge, rcuser);
        }
    }
}
