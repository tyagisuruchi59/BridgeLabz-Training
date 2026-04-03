using System;

class StageNode
{
    public string StageName;
    public StageNode Next;

    public StageNode(string name)
    {
        StageName = name;
        Next = null;
    }
}

class ParcelTracker
{
    private StageNode head;

    // Add stage at end
    public void AddStage(string stage)
    {
        StageNode newNode = new StageNode(stage);

        if (head == null)
        {
            head = newNode;
            return;
        }

        StageNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Insert checkpoint after a given stage
    public void InsertAfter(string existingStage, string newStage)
    {
        StageNode temp = head;

        while (temp != null)
        {
            if (temp.StageName == existingStage)
            {
                StageNode node = new StageNode(newStage);
                node.Next = temp.Next;
                temp.Next = node;
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Stage not found!");
    }

    // Forward tracking
    public void TrackParcel()
    {
        if (head == null)
        {
            Console.WriteLine("Parcel lost (no stages found)");
            return;
        }

        StageNode temp = head;
        while (temp != null)
        {
            Console.Write(temp.StageName + " → ");
            temp = temp.Next;
        }
        Console.WriteLine("END");
    }

    static void Main()
    {
        ParcelTracker parcel = new ParcelTracker();

        parcel.AddStage("Packed");
        parcel.AddStage("Shipped");
        parcel.AddStage("In Transit");
        parcel.AddStage("Delivered");

        parcel.InsertAfter("Shipped", "Customs Check");

        parcel.TrackParcel();
    }
}
