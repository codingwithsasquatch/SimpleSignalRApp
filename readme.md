Scaling SignalR

Due to the nature of websockets the SignalR Application does not send messages to clients unless they are connected to the same host (web node).  In order to get our sample to work we had to scale the deployment of the app to 1 node in Service Fabric (FB).  To achieve scale

References
Scaling out with SignalR - https://docs.microsoft.com/en-us/aspnet/signalr/overview/performance/scaleout-in-signalr
Scaling with Azure Service Bus - https://docs.microsoft.com/en-us/aspnet/signalr/overview/performance/scaleout-with-windows-azure-service-bus
Scaling with Redis - https://docs.microsoft.com/en-us/aspnet/signalr/overview/performance/scaleout-with-redis