//타이머 및 파일오픈
using System;

class Program
{
    static void Main(String[] args)
    {
        DateTime cmpTime = new DateTime(2016, 8, 22, 17, 00, 00);
        int result = 1;
        while (result != 0)
        {
            DateTime curTime = DateTime.Now;
            if (cmpTime == curTime) return;
            result = DateTime.Compare(cmpTime, curTime);
            if (result <= 0)
            {
                System.Diagnostics.Process.Start("C:\\Users\\yunsubaek_df\\Downloads\\resttime.txt");
                break;
            }
            System.Threading.Thread.Sleep(1000);
        }
    }
}
