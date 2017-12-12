# Service Fabric with SignalR

## Sample
The sample code creates a simple MVC application that has a button to send a message to the other SignalR clients.  

We created out Service Fabric cluster using the new PS command [New-AzureRmServiceCluster](https://docs.microsoft.com/en-us/azure/service-fabric/scripts/service-fabric-powershell-create-secure-cluster-cert).  This command creates a Secure Service Fabric Cluster with the number of nodes specified on the *clustersize* parameter. 

### Tips for Cluster Creation

1. You MUST create the certfolder on your machine ahead of time.  
2. Your #clustername should be all *lowercase*!
3. No need to create the Resource Group, Key Vault, or any other Azure resources as the script **WILL DO THIS FOR YOU!**
4. Your Key Vault name must be unique to the Azure Universe as it creates a DNS name for your Key Vault service.  

## Scaling SignalR

Due to the nature of websockets the SignalR Application does not send messages to clients unless they are connected to the same host (web node).  In order to get our sample to work we had to scale the deployment of our app DOWN to 1 node in Service Fabric (FB) to see the messages flow.  To achieve scale you will need to implement a backplane.  The suggestion is to create a custom backplane, which is difficult! 

SignalR can create the backplane for you on Service Bus,SQL Backplane or Redis backplane.  The links below show the examples of these backplanes.  

<em> **The recomendation however is to just write (publish) your messages straight to the Service Bus and then have your clients subscribe to the bus to recieve new messages.  Until SignalR makes scaling easier.** </em> 

### References

- [Scaling out with SignalR](https://docs.microsoft.com/en-us/aspnet/signalr/overview/performance/scaleout-in-signalr)
- [Scaling with Azure Service Bus](https://docs.microsoft.com/en-us/aspnet/signalr/overview/performance/scaleout-with-windows-azure-service-bus)
- [Scaling with Redis](https://docs.microsoft.com/en-us/aspnet/signalr/overview/performance/scaleout-with-redis)
