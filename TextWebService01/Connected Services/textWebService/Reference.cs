﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TextWebService01.textWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://northwindtraders.com/", ConfigurationName="textWebService.TextWebServiceSoap")]
    public interface TextWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name inputString from namespace http://northwindtraders.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://northwindtraders.com/ToUpper", ReplyAction="*")]
        TextWebService01.textWebService.ToUpperResponse ToUpper(TextWebService01.textWebService.ToUpperRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://northwindtraders.com/ToUpper", ReplyAction="*")]
        System.Threading.Tasks.Task<TextWebService01.textWebService.ToUpperResponse> ToUpperAsync(TextWebService01.textWebService.ToUpperRequest request);
        
        // CODEGEN: Generating message contract since element name inputString from namespace http://northwindtraders.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://northwindtraders.com/ToLower", ReplyAction="*")]
        TextWebService01.textWebService.ToLowerResponse ToLower(TextWebService01.textWebService.ToLowerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://northwindtraders.com/ToLower", ReplyAction="*")]
        System.Threading.Tasks.Task<TextWebService01.textWebService.ToLowerResponse> ToLowerAsync(TextWebService01.textWebService.ToLowerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ToUpperRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ToUpper", Namespace="http://northwindtraders.com/", Order=0)]
        public TextWebService01.textWebService.ToUpperRequestBody Body;
        
        public ToUpperRequest() {
        }
        
        public ToUpperRequest(TextWebService01.textWebService.ToUpperRequestBody Body) {
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
        public TextWebService01.textWebService.ToUpperResponseBody Body;
        
        public ToUpperResponse() {
        }
        
        public ToUpperResponse(TextWebService01.textWebService.ToUpperResponseBody Body) {
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
        public TextWebService01.textWebService.ToLowerRequestBody Body;
        
        public ToLowerRequest() {
        }
        
        public ToLowerRequest(TextWebService01.textWebService.ToLowerRequestBody Body) {
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
        public TextWebService01.textWebService.ToLowerResponseBody Body;
        
        public ToLowerResponse() {
        }
        
        public ToLowerResponse(TextWebService01.textWebService.ToLowerResponseBody Body) {
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
    public interface TextWebServiceSoapChannel : TextWebService01.textWebService.TextWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TextWebServiceSoapClient : System.ServiceModel.ClientBase<TextWebService01.textWebService.TextWebServiceSoap>, TextWebService01.textWebService.TextWebServiceSoap {
        
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
        TextWebService01.textWebService.ToUpperResponse TextWebService01.textWebService.TextWebServiceSoap.ToUpper(TextWebService01.textWebService.ToUpperRequest request) {
            return base.Channel.ToUpper(request);
        }
        
        public string ToUpper(string inputString) {
            TextWebService01.textWebService.ToUpperRequest inValue = new TextWebService01.textWebService.ToUpperRequest();
            inValue.Body = new TextWebService01.textWebService.ToUpperRequestBody();
            inValue.Body.inputString = inputString;
            TextWebService01.textWebService.ToUpperResponse retVal = ((TextWebService01.textWebService.TextWebServiceSoap)(this)).ToUpper(inValue);
            return retVal.Body.ToUpperResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TextWebService01.textWebService.ToUpperResponse> TextWebService01.textWebService.TextWebServiceSoap.ToUpperAsync(TextWebService01.textWebService.ToUpperRequest request) {
            return base.Channel.ToUpperAsync(request);
        }
        
        public System.Threading.Tasks.Task<TextWebService01.textWebService.ToUpperResponse> ToUpperAsync(string inputString) {
            TextWebService01.textWebService.ToUpperRequest inValue = new TextWebService01.textWebService.ToUpperRequest();
            inValue.Body = new TextWebService01.textWebService.ToUpperRequestBody();
            inValue.Body.inputString = inputString;
            return ((TextWebService01.textWebService.TextWebServiceSoap)(this)).ToUpperAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TextWebService01.textWebService.ToLowerResponse TextWebService01.textWebService.TextWebServiceSoap.ToLower(TextWebService01.textWebService.ToLowerRequest request) {
            return base.Channel.ToLower(request);
        }
        
        public string ToLower(string inputString) {
            TextWebService01.textWebService.ToLowerRequest inValue = new TextWebService01.textWebService.ToLowerRequest();
            inValue.Body = new TextWebService01.textWebService.ToLowerRequestBody();
            inValue.Body.inputString = inputString;
            TextWebService01.textWebService.ToLowerResponse retVal = ((TextWebService01.textWebService.TextWebServiceSoap)(this)).ToLower(inValue);
            return retVal.Body.ToLowerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TextWebService01.textWebService.ToLowerResponse> TextWebService01.textWebService.TextWebServiceSoap.ToLowerAsync(TextWebService01.textWebService.ToLowerRequest request) {
            return base.Channel.ToLowerAsync(request);
        }
        
        public System.Threading.Tasks.Task<TextWebService01.textWebService.ToLowerResponse> ToLowerAsync(string inputString) {
            TextWebService01.textWebService.ToLowerRequest inValue = new TextWebService01.textWebService.ToLowerRequest();
            inValue.Body = new TextWebService01.textWebService.ToLowerRequestBody();
            inValue.Body.inputString = inputString;
            return ((TextWebService01.textWebService.TextWebServiceSoap)(this)).ToLowerAsync(inValue);
        }
    }
}
