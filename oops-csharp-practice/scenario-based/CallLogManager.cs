using System;

class CallLog
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
    public DateTime TimeStamp { get; set; }

    public void Display()
    {
        Console.WriteLine($"Phone: {PhoneNumber}");
        Console.WriteLine($"Message: {Message}");
        Console.WriteLine($"Time: {TimeStamp}");
        Console.WriteLine("---------------------------------");
    }
}

class CallLogManager
{
    private CallLog[] logs;
    private int count;

    public CallLogManager(int size)
    {
        logs = new CallLog[size];
        count = 0;
    }

    // Add a call log
    public void AddCallLog(string phone, string message, DateTime time)
    {
        if (count >= logs.Length)
        {
            Console.WriteLine("Log storage is full!");
            return;
        }

        logs[count] = new CallLog
        {
            PhoneNumber = phone,
            Message = message,
            TimeStamp = time
        };

        count++;
    }

    // Search logs by keyword in message
    public void SearchByKeyword(string keyword)
    {
        Console.WriteLine($"\nSearching logs for keyword: \"{keyword}\"");
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (logs[i].Message.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No logs found with the given keyword.");
        }
    }

    // Filter logs by time range
    public void FilterByTime(DateTime start, DateTime end)
    {
        Console.WriteLine($"\nLogs between {start} and {end}");
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (logs[i].TimeStamp >= start && logs[i].TimeStamp <= end)
            {
                logs[i].Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No logs found in the given time range.");
        }
    }
}

class Program
{
    static void Main()
    {
        CallLogManager manager = new CallLogManager(10);

        // Adding sample call logs
        manager.AddCallLog("9876543210", "Internet not working", DateTime.Now.AddHours(-3));
        manager.AddCallLog("9123456789", "Slow network issue", DateTime.Now.AddHours(-2));
        manager.AddCallLog("9988776655", "Billing problem", DateTime.Now.AddHours(-1));

        // Search by keyword
        manager.SearchByKeyword("network");

        // Filter by time range
        DateTime startTime = DateTime.Now.AddHours(-4);
        DateTime endTime = DateTime.Now.AddHours(-1);

        manager.FilterByTime(startTime, endTime);
    }
}
