using System;
using System.Collections.Generic;

public interface IAlertDAO
{
    Guid AddAlert(DateTime time);
    DateTime GetAlert(Guid id);
}

public class AlertService
{
    private readonly IAlertDAO storage;

    public AlertService(IAlertDAO alertDAO) //constructor 
    {
        this.storage = alertDAO; // everytime an alert service is created it will have access to the storage field,
                                 // which holds a reference to an object that implements the 'IAlertDAO' interface   
    }

    public Guid RaiseAlert()
    {
        return this.storage.AddAlert(DateTime.Now);
    }

    public DateTime GetAlertTime(Guid id)
    {
        return this.storage.GetAlert(id);
    }
}

public class AlertDAO : IAlertDAO
{
    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

    public Guid AddAlert(DateTime time)
    {
        Guid id = Guid.NewGuid();
        this.alerts.Add(id, time);
        return id;
    }

    public DateTime GetAlert(Guid id)
    {
        return this.alerts[id];
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IAlertDAO alertDAO = new AlertDAO();
        AlertService alertService = new AlertService(alertDAO);

        Guid alertId = alertService.RaiseAlert();
        DateTime alertTime = alertService.GetAlertTime(alertId);

        Console.WriteLine($"Alert raised at: {alertTime}");
    }
}
