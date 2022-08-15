﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SL_WCF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IOperaciones")]
    public interface IOperaciones {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Suma", ReplyAction="http://tempuri.org/IOperaciones/SumaResponse")]
        int Suma(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Suma", ReplyAction="http://tempuri.org/IOperaciones/SumaResponse")]
        System.Threading.Tasks.Task<int> SumaAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Resta", ReplyAction="http://tempuri.org/IOperaciones/RestaResponse")]
        int Resta(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Resta", ReplyAction="http://tempuri.org/IOperaciones/RestaResponse")]
        System.Threading.Tasks.Task<int> RestaAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Multiplicacion", ReplyAction="http://tempuri.org/IOperaciones/MultiplicacionResponse")]
        int Multiplicacion(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Multiplicacion", ReplyAction="http://tempuri.org/IOperaciones/MultiplicacionResponse")]
        System.Threading.Tasks.Task<int> MultiplicacionAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Divicion", ReplyAction="http://tempuri.org/IOperaciones/DivicionResponse")]
        int Divicion(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOperaciones/Divicion", ReplyAction="http://tempuri.org/IOperaciones/DivicionResponse")]
        System.Threading.Tasks.Task<int> DivicionAsync(int num1, int num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOperacionesChannel : SL_WCF.ServiceReference1.IOperaciones, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OperacionesClient : System.ServiceModel.ClientBase<SL_WCF.ServiceReference1.IOperaciones>, SL_WCF.ServiceReference1.IOperaciones {
        
        public OperacionesClient() {
        }
        
        public OperacionesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OperacionesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperacionesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OperacionesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Suma(int num1, int num2) {
            return base.Channel.Suma(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> SumaAsync(int num1, int num2) {
            return base.Channel.SumaAsync(num1, num2);
        }
        
        public int Resta(int num1, int num2) {
            return base.Channel.Resta(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> RestaAsync(int num1, int num2) {
            return base.Channel.RestaAsync(num1, num2);
        }
        
        public int Multiplicacion(int num1, int num2) {
            return base.Channel.Multiplicacion(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> MultiplicacionAsync(int num1, int num2) {
            return base.Channel.MultiplicacionAsync(num1, num2);
        }
        
        public int Divicion(int num1, int num2) {
            return base.Channel.Divicion(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> DivicionAsync(int num1, int num2) {
            return base.Channel.DivicionAsync(num1, num2);
        }
    }
}