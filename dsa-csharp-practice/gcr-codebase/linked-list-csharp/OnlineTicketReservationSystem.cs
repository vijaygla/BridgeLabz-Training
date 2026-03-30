using System;

class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public string BookingTime;
    public TicketNode Next;

    public TicketNode(int id, string customer, string movie, string seat, string time)
    {
        TicketId = id;
        CustomerName = customer;
        MovieName = movie;
        SeatNumber = seat;
        BookingTime = time;
        Next = null;
    }
}

class TicketSystem
{
    private TicketNode head;

    public void AddTicket(int id, string customer, string movie, string seat, string time)
    {
        TicketNode newNode = new TicketNode(id, customer, movie, seat, time);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            return;
        }

        TicketNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newNode;
        newNode.Next = head;
    }

    public void RemoveTicket(int id)
    {
        if (head == null) return;

        TicketNode temp = head;
        TicketNode prev = null;

        do
        {
            if (temp.TicketId == id)
            {
                if (prev != null)
                    prev.Next = temp.Next;
                else
                {
                    TicketNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void Display()
    {
        if (head == null) return;

        TicketNode temp = head;
        do
        {
            Console.WriteLine(
                "Ticket ID: " + temp.TicketId +
                ", Customer: " + temp.CustomerName +
                ", Movie: " + temp.MovieName
            );
            temp = temp.Next;
        } while (temp != head);
    }

    public void CountTickets()
    {
        if (head == null)
        {
            Console.WriteLine("Total Tickets: 0");
            return;
        }

        int count = 0;
        TicketNode temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("Total Tickets: " + count);
    }
}

class OnlineTicketReservationSystem
{
    static void Main()
    {
        TicketSystem ts = new TicketSystem();
        ts.AddTicket(1, "Amit", "Inception", "A1", "10:00");
        ts.AddTicket(2, "Ravi", "Avatar", "B2", "10:05");

        ts.Display();
        ts.CountTickets();
    }
}
