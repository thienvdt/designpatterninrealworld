using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoadBalancerSingleInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is load balancer server");
            LoadBalancerPattern balancer = LoadBalancerPattern.GetLoadBalancer();
            for (int i = 0; i < 10; i++)
            {
                var server = balancer.NextServer();
                Console.WriteLine($"Request {i} Dispatched to server: {server.Name}| CPU {server.GetCPUUsed()}");
            }
        }
    }

    sealed class LoadBalancerPattern
    {
        private static readonly LoadBalancerPattern _instance = new LoadBalancerPattern();
        public int _serverDeathCounter=0;
        private List<Server> _servers;
        private Random _random = new Random();
        private object _lockObjThreadSafe = new object();
        private LoadBalancerPattern()
        {
            lock (_lockObjThreadSafe)
            {
                _servers = new List<Server>
            {
                new Server("Server 1","192.168.1.1"),
                new Server("Server 2","192.168.1.2"),
                new Server("Server 3","192.168.1.3"),
                new Server("Server 4","192.168.1.4"),
                new Server("Server 5","192.168.1.5"),
                new Server("Server 6","192.168.1.6"),
                new Server("Server 7","192.168.1.7"),
                new Server("Server 8","192.168.1.8")
            };
            }

        }
        public static LoadBalancerPattern GetLoadBalancer()
        {
            return _instance;
        }

        public Server NextServer()
        {
            int r = _random.Next(_servers.Count);
            if (!_servers[r].IsHealthy())
            {
                Console.WriteLine($"Server{ _servers[r].Name} Taken { _servers[r].GetCPUUsed()} CPU is going to die");
                _serverDeathCounter++;
                if (_serverDeathCounter < _servers.Count)
                {
                    Console.WriteLine("Dispatch to another server");
                    return NextServer();
                }
                else
                {
                    throw new Exception("No more server to execute request");
                }
               
            }
            else
            {
                _servers[r].AddResource();
                return _servers[r];
            }
           
        }
    }
}


public class Server
{
    public Server(string Name, string IP)
    {
        this.Name = Name;
        this.IP = IP;
    }
    public string Name { get; set; }
    public string IP { get; set; }
    [Range(0, 100)]
    public int ServerResourcePercent { get; set; }
    public void RestartServer()
    {
        ServerResourcePercent = 0;
    }
    public void AddResource()
    {
        _ = ServerResourcePercent > 100 ? throw new OutOfMemoryException("Server is ruinning  of memory") : ServerResourcePercent += new Random().Next(0, 100);

    }
    public int GetCPUUsed()
    {
        return ServerResourcePercent;
    }
    public bool IsHealthy()
    {
        return ServerResourcePercent < 80;
    }

}
