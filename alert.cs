//타이머 및 파일오픈
using System;

class Program
{
    static void Main(String[] args)
    {
        DateTime cmpTime = new DateTime(2016, 8, 22, 20, 59, 30);
        while (true)
        {
            if (DateTime.Compare(cmpTime, DateTime.Now) <= 0)
            {
                System.Diagnostics.Process.Start("C:\\Users\\yunsubaek_df\\Downloads\\conference.txt");
                break;
            }
            System.Threading.Thread.Sleep(1000);
        }
    }
}
