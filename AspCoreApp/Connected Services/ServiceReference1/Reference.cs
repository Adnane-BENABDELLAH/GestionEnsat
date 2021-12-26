﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="eleve", Namespace="http://schemas.datacontract.org/2004/07/")]
    public partial class eleve : object
    {
        
        private string cneField;
        
        private string emailField;
        
        private string filiereField;
        
        private string nomField;
        
        private string prenomField;
        
        private string telField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cne
        {
            get
            {
                return this.cneField;
            }
            set
            {
                this.cneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string filiere
        {
            get
            {
                return this.filiereField;
            }
            set
            {
                this.filiereField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nom
        {
            get
            {
                return this.nomField;
            }
            set
            {
                this.nomField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prenom
        {
            get
            {
                return this.prenomField;
            }
            set
            {
                this.prenomField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tel
        {
            get
            {
                return this.telField;
            }
            set
            {
                this.telField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        ServiceReference1.eleve[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        System.Threading.Tasks.Task<ServiceReference1.eleve[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Insert", ReplyAction="http://tempuri.org/IService/InsertResponse")]
        int Insert(string cne, string prenom, string nom, string email, string filiere, string tel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Insert", ReplyAction="http://tempuri.org/IService/InsertResponse")]
        System.Threading.Tasks.Task<int> InsertAsync(string cne, string prenom, string nom, string email, string filiere, string tel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteEleve", ReplyAction="http://tempuri.org/IService/DeleteEleveResponse")]
        int DeleteEleve(string cne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteEleve", ReplyAction="http://tempuri.org/IService/DeleteEleveResponse")]
        System.Threading.Tasks.Task<int> DeleteEleveAsync(string cne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateEleve", ReplyAction="http://tempuri.org/IService/UpdateEleveResponse")]
        int UpdateEleve(string cne, string prenom, string nom, string email, string filiere, string tel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateEleve", ReplyAction="http://tempuri.org/IService/UpdateEleveResponse")]
        System.Threading.Tasks.Task<int> UpdateEleveAsync(string cne, string prenom, string nom, string email, string filiere, string tel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetOne", ReplyAction="http://tempuri.org/IService/GetOneResponse")]
        ServiceReference1.eleve GetOne(string cne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetOne", ReplyAction="http://tempuri.org/IService/GetOneResponse")]
        System.Threading.Tasks.Task<ServiceReference1.eleve> GetOneAsync(string cne);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IServiceChannel : ServiceReference1.IService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ServiceReference1.IService>, ServiceReference1.IService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceClient() : 
                base(ServiceClient.GetDefaultBinding(), ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceReference1.eleve[] GetAll()
        {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.eleve[]> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public int Insert(string cne, string prenom, string nom, string email, string filiere, string tel)
        {
            return base.Channel.Insert(cne, prenom, nom, email, filiere, tel);
        }
        
        public System.Threading.Tasks.Task<int> InsertAsync(string cne, string prenom, string nom, string email, string filiere, string tel)
        {
            return base.Channel.InsertAsync(cne, prenom, nom, email, filiere, tel);
        }
        
        public int DeleteEleve(string cne)
        {
            return base.Channel.DeleteEleve(cne);
        }
        
        public System.Threading.Tasks.Task<int> DeleteEleveAsync(string cne)
        {
            return base.Channel.DeleteEleveAsync(cne);
        }
        
        public int UpdateEleve(string cne, string prenom, string nom, string email, string filiere, string tel)
        {
            return base.Channel.UpdateEleve(cne, prenom, nom, email, filiere, tel);
        }
        
        public System.Threading.Tasks.Task<int> UpdateEleveAsync(string cne, string prenom, string nom, string email, string filiere, string tel)
        {
            return base.Channel.UpdateEleveAsync(cne, prenom, nom, email, filiere, tel);
        }
        
        public ServiceReference1.eleve GetOne(string cne)
        {
            return base.Channel.GetOne(cne);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.eleve> GetOneAsync(string cne)
        {
            return base.Channel.GetOneAsync(cne);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:63368/Service.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService,
        }
    }
}
