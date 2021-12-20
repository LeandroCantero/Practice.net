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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentDC", Namespace="http://schemas.datacontract.org/2004/07/firstProyectWithWCF.Entidades")]
    public partial class StudentDC : object
    {
        
        private int CourseIdField;
        
        private int IdField;
        
        private string LastnameField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CourseId
        {
            get
            {
                return this.CourseIdField;
            }
            set
            {
                this.CourseIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lastname
        {
            get
            {
                return this.LastnameField;
            }
            set
            {
                this.LastnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IStudentService")]
    public interface IStudentService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetStudents", ReplyAction="http://tempuri.org/IStudentService/GetStudentsResponse")]
        ServiceReference1.StudentDC GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetStudents", ReplyAction="http://tempuri.org/IStudentService/GetStudentsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.StudentDC> GetStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetStudentById", ReplyAction="http://tempuri.org/IStudentService/GetStudentByIdResponse")]
        ServiceReference1.StudentDC GetStudentById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetStudentById", ReplyAction="http://tempuri.org/IStudentService/GetStudentByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.StudentDC> GetStudentByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/SaveStudent", ReplyAction="http://tempuri.org/IStudentService/SaveStudentResponse")]
        void SaveStudent(string name, string lastName, int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/SaveStudent", ReplyAction="http://tempuri.org/IStudentService/SaveStudentResponse")]
        System.Threading.Tasks.Task SaveStudentAsync(string name, string lastName, int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/DeleteStudent", ReplyAction="http://tempuri.org/IStudentService/DeleteStudentResponse")]
        void DeleteStudent(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/DeleteStudent", ReplyAction="http://tempuri.org/IStudentService/DeleteStudentResponse")]
        System.Threading.Tasks.Task DeleteStudentAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/UpdateNameStudent", ReplyAction="http://tempuri.org/IStudentService/UpdateNameStudentResponse")]
        void UpdateNameStudent(int id, string newName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/UpdateNameStudent", ReplyAction="http://tempuri.org/IStudentService/UpdateNameStudentResponse")]
        System.Threading.Tasks.Task UpdateNameStudentAsync(int id, string newName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface IStudentServiceChannel : ServiceReference1.IStudentService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class StudentServiceClient : System.ServiceModel.ClientBase<ServiceReference1.IStudentService>, ServiceReference1.IStudentService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public StudentServiceClient() : 
                base(StudentServiceClient.GetDefaultBinding(), StudentServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IStudentService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(StudentServiceClient.GetBindingForEndpoint(endpointConfiguration), StudentServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(StudentServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(StudentServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceReference1.StudentDC GetStudents()
        {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.StudentDC> GetStudentsAsync()
        {
            return base.Channel.GetStudentsAsync();
        }
        
        public ServiceReference1.StudentDC GetStudentById(int id)
        {
            return base.Channel.GetStudentById(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.StudentDC> GetStudentByIdAsync(int id)
        {
            return base.Channel.GetStudentByIdAsync(id);
        }
        
        public void SaveStudent(string name, string lastName, int courseId)
        {
            base.Channel.SaveStudent(name, lastName, courseId);
        }
        
        public System.Threading.Tasks.Task SaveStudentAsync(string name, string lastName, int courseId)
        {
            return base.Channel.SaveStudentAsync(name, lastName, courseId);
        }
        
        public void DeleteStudent(int id)
        {
            base.Channel.DeleteStudent(id);
        }
        
        public System.Threading.Tasks.Task DeleteStudentAsync(int id)
        {
            return base.Channel.DeleteStudentAsync(id);
        }
        
        public void UpdateNameStudent(int id, string newName)
        {
            base.Channel.UpdateNameStudent(id, newName);
        }
        
        public System.Threading.Tasks.Task UpdateNameStudentAsync(int id, string newName)
        {
            return base.Channel.UpdateNameStudentAsync(id, newName);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IStudentService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IStudentService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:52636/Servicio/Impl/StudentServiceImpl.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return StudentServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IStudentService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return StudentServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IStudentService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IStudentService,
        }
    }
}