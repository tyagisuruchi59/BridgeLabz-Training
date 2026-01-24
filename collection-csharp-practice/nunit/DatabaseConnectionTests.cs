using NUnit.Framework;

public class DatabaseConnection
{
    public bool IsConnected { get; private set; }
    public void Connect() => IsConnected = true;
    public void Disconnect() => IsConnected = false;
}

[TestFixture]
public class DatabaseConnectionTests
{
    DatabaseConnection db;

    [SetUp]
    public void Init()
    {
        db = new DatabaseConnection();
        db.Connect();
    }

    [TearDown]
    public void Cleanup()
    {
        db.Disconnect();
    }

    [Test]
    public void Connection_Test()
    {
        Assert.IsTrue(db.IsConnected);
    }
}
