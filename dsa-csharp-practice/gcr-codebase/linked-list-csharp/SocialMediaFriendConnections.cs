using System;
using System.Collections.Generic;

class UserNode
{
    public int UserId;
    public string Name;
    public int Age;
    public List<int> Friends;
    public UserNode Next;

    public UserNode(int id, string name, int age)
    {
        UserId = id;
        Name = name;
        Age = age;
        Friends = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private UserNode head;

    public void AddUser(int id, string name, int age)
    {
        UserNode newNode = new UserNode(id, name, age);
        newNode.Next = head;
        head = newNode;
    }

    private UserNode FindUser(int id)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserId == id)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void AddFriend(int id1, int id2)
    {
        UserNode u1 = FindUser(id1);
        UserNode u2 = FindUser(id2);

        if (u1 == null || u2 == null)
        {
            Console.WriteLine("User not found");
            return;
        }

        u1.Friends.Add(id2);
        u2.Friends.Add(id1);
    }

    public void RemoveFriend(int id1, int id2)
    {
        UserNode u1 = FindUser(id1);
        UserNode u2 = FindUser(id2);

        if (u1 != null && u2 != null)
        {
            u1.Friends.Remove(id2);
            u2.Friends.Remove(id1);
        }
    }

    public void MutualFriends(int id1, int id2)
    {
        UserNode u1 = FindUser(id1);
        UserNode u2 = FindUser(id2);

        Console.WriteLine("Mutual Friends:");
        foreach (int f in u1.Friends)
        {
            if (u2.Friends.Contains(f))
                Console.WriteLine("User ID: " + f);
        }
    }

    public void DisplayFriends(int id)
    {
        UserNode user = FindUser(id);
        Console.WriteLine("Friends of " + user.Name);
        foreach (int f in user.Friends)
            Console.WriteLine("Friend ID: " + f);
    }

    public void SearchUser(int id)
    {
        UserNode user = FindUser(id);
        if (user != null)
            Console.WriteLine("Found: " + user.Name);
    }

    public void CountFriends()
    {
        UserNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Name + " has " + temp.Friends.Count + " friends");
            temp = temp.Next;
        }
    }
}

class SocialMediaFriendConnections
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia();
        sm.AddUser(1, "Alice", 22);
        sm.AddUser(2, "Bob", 24);
        sm.AddUser(3, "Charlie", 23);

        sm.AddFriend(1, 2);
        sm.AddFriend(1, 3);

        sm.DisplayFriends(1);
        sm.MutualFriends(2, 3);
        sm.CountFriends();
    }
}
