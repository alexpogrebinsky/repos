﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TextWebServiceClient001.textWebReferance {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://northwindtraders.com/", ConfigurationName="textWebReferance.TextWebServiceSoap")]
    public interface TextWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name inputString from namespace http://northwindtraders.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://northwindtraders.com/ToUpper", ReplyAction="*")]
        TextWebServiceClient001.textWebReferance.ToUpperResponse ToUpper(TextWebServiceClient001.textWebReferance.ToUpperRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://northwindtraders.com/ToUpper", ReplyAction="*")]
        System.Threading.Tasks.Task<TextWebServiceClient001.textWebReferance.ToUpperResponse> ToUpperAsync(TextWebServiceClient001.textWebReferance.ToUpperRequest request);
        
        // CODEGEN: Generating message contract since element name inputString from namespace http://northwindtraders.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://northwindtraders.com/ToLower", ReplyAction="*")]
        TextWebServiceClient001.textWebReferance.ToLowerResponse ToLower(TextWebServiceClient001.textWebReferance.ToLowerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://northwindtraders.com/ToLower", ReplyAction="*")]
        System.Threading.Tasks.Task<TextWebServiceClient001.textWebReferance.ToLowerResponse> ToLowerAsync(TextWebServiceClient001.textWebReferance.ToLowerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ToUpperRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ToUpper", Namespace="http://northwindtraders.com/", Order=0)]
        public TextWebServiceClient001.textWebReferance.ToUpperRequestBody Body;
        
        public ToUpperRequest() {
        }
        
        public ToUpperRequest(TextWebServiceClient001.textWebReferance.ToUpperRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://northwindtraders.com/")]
    public partial class ToUpperRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string inputString;
        
        public ToUpperRequestBody() {
        }
        
        public ToUpperRequestBody(string inputString) {
            this.inputString = inputString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ToUpperResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ToUpperResponse", Namespace="http://northwindtraders.com/", Order=0)]
        public TextWebServiceClient001.textWebReferance.ToUpperResponseBody Body;
        
        public ToUpperResponse() {
        }
        
        public ToUpperResponse(TextWebServiceClient001.textWebReferance.ToUpperResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://northwindtraders.com/")]
    public partial class ToUpperResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ToUpperResult;
        
        public ToUpperResponseBody() {
        }
        
        public ToUpperResponseBody(string ToUpperResult) {
            this.ToUpperResult = ToUpperResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ToLowerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ToLower", Namespace="http://northwindtraders.com/", Order=0)]
        public TextWebServiceClient001.textWebReferance.ToLowerRequestBody Body;
        
        public ToLowerRequest() {
        }
        
        public ToLowerRequest(TextWebServiceClient001.textWebReferance.ToLowerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://northwindtraders.com/")]
    public partial class ToLowerRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string inputString;
        
        public ToLowerRequestBody() {
        }
        
        public ToLowerRequestBody(string inputString) {
            this.inputString = inputString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ToLowerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ToLowerResponse", Namespace="http://northwindtraders.com/", Order=0)]
        public TextWebServiceClient001.textWebReferance.ToLowerResponseBody Body;
        
        public ToLowerResponse() {
        }
        
        public ToLowerResponse(TextWebServiceClient001.textWebReferance.ToLowerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://northwindtraders.com/")]
    public partial class ToLowerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ToLowerResult;
        
        public ToLowerResponseBody() {
        }
        
        public ToLowerResponseBody(string ToLowerResult) {
            this.ToLowerResult = ToLowerResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TextWebServiceSoapChannel : TextWebServiceClient001.textWebReferance.TextWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TextWebServiceSoapClient : System.ServiceModel.ClientBase<TextWebServiceClient001.textWebReferance.TextWebServiceSoap>, TextWebServiceClient001.textWebReferance.TextWebServiceSoap {
        
        public TextWebServiceSoapClient() {
        }
        
        public TextWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TextWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TextWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TextWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TextWebServiceClient001.textWebReferance.ToUpperResponse TextWebServiceClient001.textWebReferance.TextWebServiceSoap.ToUpper(TextWebServiceClient001.textWebReferance.ToUpperRequest request) {
            return base.Channel.ToUpper(request);
        }
        
        public string ToUpper(string inputString) {
            TextWebServiceClient001.textWebReferance.ToUpperRequest inValue = new TextWebServiceClient001.textWebReferance.ToUpperRequest();
            inValue.Body = new TextWebServiceClient001.textWebReferance.ToUpperRequestBody();
            inValue.Body.inputString = inputString;
            TextWebServiceClient001.textWebReferance.ToUpperResponse retVal = ((TextWebServiceClient001.textWebReferance.TextWebServiceSoap)(this)).ToUpper(inValue);
            return retVal.Body.ToUpperResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TextWebServiceClient001.textWebReferance.ToUpperResponse> TextWebServiceClient001.textWebReferance.TextWebServiceSoap.ToUpperAsync(TextWebServiceClient001.textWebReferance.ToUpperRequest request) {
            return base.Channel.ToUpperAsync(request);
        }
        
        public System.Threading.Tasks.Task<TextWebServiceClient001.textWebReferance.ToUpperResponse> ToUpperAsync(string inputString) {
            TextWebServiceClient001.textWebReferance.ToUpperRequest inValue = new TextWebServiceClient001.textWebReferance.ToUpperRequest();
            inValue.Body = new TextWebServiceClient001.textWebReferance.ToUpperRequestBody();
            inValue.Body.inputString = inputString;
            return ((TextWebServiceClient001.textWebReferance.TextWebServiceSoap)(this)).ToUpperAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TextWebServiceClient001.textWebReferance.ToLowerResponse TextWebServiceClient001.textWebReferance.TextWebServiceSoap.ToLower(TextWebServiceClient001.textWebReferance.ToLowerRequest request) {
            return base.Channel.ToLower(request);
        }
        
        public string ToLower(string inputString) {
            TextWebServiceClient001.textWebReferance.ToLowerRequest inValue = new TextWebServiceClient001.textWebReferance.ToLowerRequest();
            inValue.Body = new TextWebServiceClient001.textWebReferance.ToLowerRequestBody();
            inValue.Body.inputString = inputString;
            TextWebServiceClient001.textWebReferance.ToLowerResponse retVal = ((TextWebServiceClient001.textWebReferance.TextWebServiceSoap)(this)).ToLower(inValue);
            return retVal.Body.ToLowerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TextWebServiceClient001.textWebReferance.ToLowerResponse> TextWebServiceClient001.textWebReferance.TextWebServiceSoap.ToLowerAsync(TextWebServiceClient001.textWebReferance.ToLowerRequest request) {
            return base.Channel.ToLowerAsync(request);
        }
        
        public System.Threading.Tasks.Task<TextWebServiceClient001.textWebReferance.ToLowerResponse> ToLowerAsync(string inputString) {
            TextWebServiceClient001.textWebReferance.ToLowerRequest inValue = new TextWebServiceClient001.textWebReferance.ToLowerRequest();
            inValue.Body = new TextWebServiceClient001.textWebReferance.ToLowerRequestBody();
            inValue.Body.inputString = inputString;
            return ((TextWebServiceClient001.textWebReferance.TextWebServiceSoap)(this)).ToLowerAsync(inValue);
        }
    }
}
