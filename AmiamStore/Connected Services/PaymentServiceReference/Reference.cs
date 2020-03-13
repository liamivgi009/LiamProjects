﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmiamStore.PaymentServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PaymentServiceReference.PaymentWebServiceSoap")]
    public interface PaymentWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name creditCardNumber from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Pay", ReplyAction="*")]
        AmiamStore.PaymentServiceReference.PayResponse Pay(AmiamStore.PaymentServiceReference.PayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Pay", ReplyAction="*")]
        System.Threading.Tasks.Task<AmiamStore.PaymentServiceReference.PayResponse> PayAsync(AmiamStore.PaymentServiceReference.PayRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PayRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Pay", Namespace="http://tempuri.org/", Order=0)]
        public AmiamStore.PaymentServiceReference.PayRequestBody Body;
        
        public PayRequest() {
        }
        
        public PayRequest(AmiamStore.PaymentServiceReference.PayRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PayRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string creditCardNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string cvv;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public double amount;
        
        public PayRequestBody() {
        }
        
        public PayRequestBody(string creditCardNumber, string cvv, double amount) {
            this.creditCardNumber = creditCardNumber;
            this.cvv = cvv;
            this.amount = amount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PayResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PayResponse", Namespace="http://tempuri.org/", Order=0)]
        public AmiamStore.PaymentServiceReference.PayResponseBody Body;
        
        public PayResponse() {
        }
        
        public PayResponse(AmiamStore.PaymentServiceReference.PayResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PayResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool PayResult;
        
        public PayResponseBody() {
        }
        
        public PayResponseBody(bool PayResult) {
            this.PayResult = PayResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PaymentWebServiceSoapChannel : AmiamStore.PaymentServiceReference.PaymentWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaymentWebServiceSoapClient : System.ServiceModel.ClientBase<AmiamStore.PaymentServiceReference.PaymentWebServiceSoap>, AmiamStore.PaymentServiceReference.PaymentWebServiceSoap {
        
        public PaymentWebServiceSoapClient() {
        }
        
        public PaymentWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaymentWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AmiamStore.PaymentServiceReference.PayResponse AmiamStore.PaymentServiceReference.PaymentWebServiceSoap.Pay(AmiamStore.PaymentServiceReference.PayRequest request) {
            return base.Channel.Pay(request);
        }
        
        public bool Pay(string creditCardNumber, string cvv, double amount) {
            AmiamStore.PaymentServiceReference.PayRequest inValue = new AmiamStore.PaymentServiceReference.PayRequest();
            inValue.Body = new AmiamStore.PaymentServiceReference.PayRequestBody();
            inValue.Body.creditCardNumber = creditCardNumber;
            inValue.Body.cvv = cvv;
            inValue.Body.amount = amount;
            AmiamStore.PaymentServiceReference.PayResponse retVal = ((AmiamStore.PaymentServiceReference.PaymentWebServiceSoap)(this)).Pay(inValue);
            return retVal.Body.PayResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AmiamStore.PaymentServiceReference.PayResponse> AmiamStore.PaymentServiceReference.PaymentWebServiceSoap.PayAsync(AmiamStore.PaymentServiceReference.PayRequest request) {
            return base.Channel.PayAsync(request);
        }
        
        public System.Threading.Tasks.Task<AmiamStore.PaymentServiceReference.PayResponse> PayAsync(string creditCardNumber, string cvv, double amount) {
            AmiamStore.PaymentServiceReference.PayRequest inValue = new AmiamStore.PaymentServiceReference.PayRequest();
            inValue.Body = new AmiamStore.PaymentServiceReference.PayRequestBody();
            inValue.Body.creditCardNumber = creditCardNumber;
            inValue.Body.cvv = cvv;
            inValue.Body.amount = amount;
            return ((AmiamStore.PaymentServiceReference.PaymentWebServiceSoap)(this)).PayAsync(inValue);
        }
    }
}
