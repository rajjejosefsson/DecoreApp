﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Decore.ClientApp.TicketServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TicketServiceReference.ITicketService")]
    public interface ITicketService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/GetTickets", ReplyAction="http://tempuri.org/ITicketService/GetTicketsResponse")]
        Decore.Models.Ticket[] GetTickets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/GetTickets", ReplyAction="http://tempuri.org/ITicketService/GetTicketsResponse")]
        System.Threading.Tasks.Task<Decore.Models.Ticket[]> GetTicketsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/AddTicket", ReplyAction="http://tempuri.org/ITicketService/AddTicketResponse")]
        void AddTicket(Decore.Models.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/AddTicket", ReplyAction="http://tempuri.org/ITicketService/AddTicketResponse")]
        System.Threading.Tasks.Task AddTicketAsync(Decore.Models.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/CreateTicket", ReplyAction="http://tempuri.org/ITicketService/CreateTicketResponse")]
        void CreateTicket(Decore.Models.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicketService/CreateTicket", ReplyAction="http://tempuri.org/ITicketService/CreateTicketResponse")]
        System.Threading.Tasks.Task CreateTicketAsync(Decore.Models.Ticket ticket);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITicketServiceChannel : Decore.ClientApp.TicketServiceReference.ITicketService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TicketServiceClient : System.ServiceModel.ClientBase<Decore.ClientApp.TicketServiceReference.ITicketService>, Decore.ClientApp.TicketServiceReference.ITicketService {
        
        public TicketServiceClient() {
        }
        
        public TicketServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TicketServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Decore.Models.Ticket[] GetTickets() {
            return base.Channel.GetTickets();
        }
        
        public System.Threading.Tasks.Task<Decore.Models.Ticket[]> GetTicketsAsync() {
            return base.Channel.GetTicketsAsync();
        }
        
        public void AddTicket(Decore.Models.Ticket ticket) {
            base.Channel.AddTicket(ticket);
        }
        
        public System.Threading.Tasks.Task AddTicketAsync(Decore.Models.Ticket ticket) {
            return base.Channel.AddTicketAsync(ticket);
        }
        
        public void CreateTicket(Decore.Models.Ticket ticket) {
            base.Channel.CreateTicket(ticket);
        }
        
        public System.Threading.Tasks.Task CreateTicketAsync(Decore.Models.Ticket ticket) {
            return base.Channel.CreateTicketAsync(ticket);
        }
    }
}
