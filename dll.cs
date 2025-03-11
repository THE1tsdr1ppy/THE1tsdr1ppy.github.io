using System;
using System.Diagnostics;

public class Program
{
    public void main(string[] args)
    {
        KillBadTasks();
    }
    public void KillBadTasks()
    {
        Process.FindProcessByName("Roblox.exe")
        {
            Process.Kill();
        }
    }   
}
