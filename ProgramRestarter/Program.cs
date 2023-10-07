using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace ProgramRestarter
{
    class Program
    {
        [DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")]
        public static extern short GetAsyncKeyStateShort(System.Windows.Forms.Keys vKey);

      public struct KeyState
        {
            public bool bPressed;
            public bool bReleased;
            public bool bHeld;
        }

      static  long[] keyNewState = new long[256];
      static  long[] keyOldState = new long[256];
      static  KeyState[] keys = new KeyState[256];

       static  int shitcounter = 0;

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(MainThread));
            t.Start();

        }


        public static void MainThread()
        {
            while (true)
            {
                for (int i = 0; i < 256; i++)
                {
                    keyNewState[i] = GetAsyncKeyStateShort((Keys)i);

                    keys[i].bPressed = false;
                    keys[i].bReleased = false;

                    if (keyNewState[i] != keyOldState[i])
                    {
                        //-32768 is the value that it gives when you press the key or you hold it
                        if (keyNewState[i] == -32768)
                        {
                            keys[i].bPressed = !keys[i].bHeld;
                            keys[i].bHeld = true;
                        }
                        else
                        {
                            keys[i].bReleased = true;
                            keys[i].bHeld = false;
                        }
                    }

                    keyOldState[i] = keyNewState[i];
                }



                if (GetKeyState(Keys.Add).bPressed)
                {
                    shitcounter++;
                }

                if (GetKeyState(Keys.Escape).bPressed)
                {
                    Process p = Process.GetProcessesByName("GraphingCalc")[0];
                    p.Kill();
                }
                // Console.WriteLine(shitcounter);
                //200


                if (shitcounter == 200)
                {
                    Console.WriteLine("Restarting program");
                    try
                    {
                        shitcounter = 0;
                        Process p = Process.GetProcessesByName("GraphingCalc")[0];

                        //string path = Application.ExecutablePath + @"\..\..\..\..\GraphingCalc\bin\Debug\GraphingCalc.exe";
                        string path = "GraphingCalc.exe";
                        p.Kill();
                        Thread.Sleep(1000);
                        p = new Process();
                        p.StartInfo.FileName = path;
                        //p.StartInfo.WorkingDirectory = path.Remove(path.Length - 17, 17);
                        p.Start();
                        p.Dispose();
                        Console.WriteLine("Restart succeded!");
                    } catch
                    {
                        shitcounter = 0;
                        Console.WriteLine("Restart failed!");
                    }
                }
                if (Process.GetProcessesByName("GraphingCalc").Length == 0)
                {
                    Process.GetCurrentProcess().Kill();
                }
            }
        }

        public static KeyState GetKeyState(Keys k)
            {
                return keys[(int)k];
            }
    }
}
