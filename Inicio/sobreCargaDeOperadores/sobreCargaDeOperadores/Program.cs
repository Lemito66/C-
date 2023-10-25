// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Tienen el mismo nombre pero diferentes parametros

void StopService(string serviceName, int timeoutMilliseconds)
{
    // ...
}

void StopService(string serviceName, TimeSpan timeout)
{
    // ...
}

// Tienen el mismo nombre y los mismos parametros pero diferentes tipos de retorno
void StopService(string serviceName, int timeoutMilliseconds)
{
    // ...
}