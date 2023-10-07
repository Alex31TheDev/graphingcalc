using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;


//stuff

namespace ConsolaGraphicsEngine
{
    public class GraphicsHandler
    {

        #region handle

        [DllImport("user32.dll",EntryPoint = "GetAsyncKeyState")]
        public static extern short GetAsyncKeyStateShort(System.Windows.Forms.Keys vKey);
        [DllImport("user32.dll",EntryPoint = "GetAsyncKeyState")]
        public static extern bool GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern SafeFileHandle CreateFile(
            string fileName,
            [MarshalAs(UnmanagedType.U4)] uint fileAccess,
            [MarshalAs(UnmanagedType.U4)] uint fileShare,
            IntPtr securityAttributes,
            [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
            [MarshalAs(UnmanagedType.U4)] int flags,
            IntPtr template);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteConsoleOutput(
          IntPtr hConsoleOutput,
          CharInfo[] lpBuffer,
          Coord dwBufferSize,
          Coord dwBufferCoord,
          ref SmallRect lpWriteRegion);

        const int STD_OUTPUT_HANDLE = -11;
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCursorPosition")]
        internal static extern int SetCursorPossition
           (IntPtr hConsoleOutput, short x, short y);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FlushConsoleInputBuffer(IntPtr hConsoleInput);

        [StructLayout(LayoutKind.Sequential)]
        public struct Coord
        {
            public short X;
            public short Y;

            public Coord(short X, short Y)
            {
                this.X = X;
                this.Y = Y;
            }
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct CharUnion
        {
            [FieldOffset(0)] public char UnicodeChar;
            [FieldOffset(0)] public byte AsciiChar;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct CharInfo
        {
            [FieldOffset(0)] public CharUnion Char;
            [FieldOffset(2)] public short Attributes;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SmallRect
        {
            public short Left;
            public short Top;
            public short Right;
            public short Bottom;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal unsafe struct CONSOLE_FONT_INFO_EX
        {
            internal uint cbSize;
            internal uint nFont;
            internal COORD dwFontSize;
            internal int FontFamily;
            internal int FontWeight;
            internal fixed char FaceName[32];
        }
        [StructLayout(LayoutKind.Sequential)]
        internal struct COORD
        {
            internal short X;
            internal short Y;

            internal COORD(short x, short y)
            {
                X = x;
                Y = y;
            }
        }

        [DllImport("kernel32.dll")]
        static extern bool SetCurrentConsoleFontEx(
            IntPtr consoleOutput,
            bool maximumWindow,
            ref CONSOLE_FONT_INFO_EX consoleCurrentFontEx);



        #endregion

        public void SetConsoleFont(short fontSizeX, short fontSizeY, string fontName = "Consolas")
        {
            unsafe
            {
                // Set console font to Lucida Console.
                CONSOLE_FONT_INFO_EX newInfo = new CONSOLE_FONT_INFO_EX();
             //   newInfo.cbSize = (uint)Marshal.SizeOf(newInfo);
            //    newInfo.FontFamily = 0 << 4;

                // Get some settings from current font.
              //  newInfo.dwFontSize = new COORD(fontSizeX, fontSizeY);
              //  newInfo.FontWeight = 12;
                SetCurrentConsoleFontEx(h, true, ref newInfo);
                //throw new StackOverflowException();
            }
        }

        public CharInfo[] buf;
        public SmallRect rect;
        public IntPtr h;

        public int screenWidth = 128;
        public int screenHeight = 50;

        public int fontSizeX = 1;
        public int fontSizeY = 1;

        public enum PIXEL_TYPE
        {
            PIXEL_SOLID = 219,
            PIXEL_THREEQ = 178,
            PIXEL_HALF = 177,
            PIXEL_ONEQ = 176
        }

        public enum COLOUR
        {
            FG_BLACK = 0x0000,
            FG_DARK_BLUE = 0x0001,
            FG_DARK_GREEN = 0x0002,
            FG_DARK_CYAN = 0x0003,
            FG_DARK_RED = 0x0004,
            FG_DARK_MAGENTA = 0x0005,
            FG_DARK_YELLOW = 0x0006,
            FG_GREY = 0x0007, // Thanks MS :-/
            FG_DARK_GREY = 0x0008,
            FG_BLUE = 0x0009,
            FG_GREEN = 0x000A,
            FG_CYAN = 0x000B,
            FG_RED = 0x000C,
            FG_MAGENTA = 0x000D,
            FG_YELLOW = 0x000E,
            FG_WHITE = 0x000F,
            BG_BLACK = 0x0000,
            BG_DARK_BLUE = 0x0010,
            BG_DARK_GREEN = 0x0020,
            BG_DARK_CYAN = 0x0030,
            BG_DARK_RED = 0x0040,
            BG_DARK_MAGENTA = 0x0050,
            BG_DARK_YELLOW = 0x0060,
            BG_GREY = 0x0070,
            BG_DARK_GREY = 0x0080,
            BG_BLUE = 0x0090,
            BG_GREEN = 0x00A0,
            BG_CYAN = 0x00B0,
            BG_RED = 0x00C0,
            BG_MAGENTA = 0x00D0,
            BG_YELLOW = 0x00E0,
            BG_WHITE = 0x00F0,
        };


        //public DebugWindow debugWindow;

        StreamWriter w;

        public GraphicsHandler()
        {


            h = GetStdHandle(STD_OUTPUT_HANDLE);

            buf = new CharInfo[screenWidth * (screenHeight-0)];
            rect = new SmallRect() { Left = 0, Top = 0, Right = (short)screenWidth, Bottom = (short)(screenHeight) };

            Console.WindowHeight = screenHeight;
            Console.WindowWidth = screenWidth;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SetConsoleFont(22,22,"mayaeproastaaaaaaaa");
           
            
            //ThreadStart ts = new ThreadStart(runform);
            //Thread t = new Thread(ts);
            //t.Start();
            Start();
            screenCorner = new Coord()
            {
                X = (short)screenWidth,
                Y = (short)screenHeight
            };
            zeroCoord = new Coord(0, 0);

                //  while (true)
                //  {
                //      Update();
                //      //WriteDebugMsg("ass bae");
                //  }


                //  Console.ReadKey();
            }

        public void WriteDebugMsg(string msg)
        {


            //Pipe p = new Pipe();
        }

        public char boxChar = (char)219;

        public virtual void Start ()
        {

        }

        public virtual void Update ()
        {
            
        }

        public void DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3, PIXEL_TYPE c =PIXEL_TYPE.PIXEL_SOLID, short col = 0x000F)
        {
            drawLine(x1, y1, x2, y2, col, (short)c);
            drawLine(x2, y2, x3, y3, col, (short)c);
            drawLine(x3, y3, x1, y1, col, (short)c);
        }

        public void DrawTriangleMine (int p0) {
            drawLine(0, 0, p0, 0, 15, 219);
            drawLine(p0, 0, p0, p0, 15,219);
            drawLine(0, 0, p0, p0, 15,219);
        }

        public void Fill (int x1, int y1, int x2, int y2, char c = '#', short color = 15)
        {
            x2 += x1;
            y2 += y1;
            for (int x = x1; x < x2; x++)
            {
                for (int y = y1; y < y2; y++)
                {
                    Draw(c, (byte)x, (byte)y, color);
                    //Thread.Sleep(100);
                }
                //Thread.Sleep(100);
            }
        }

        

        public void drawLine(int x, int y, int x2, int y2, int color, short c)
        {
            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;

            if (w < 0)
                dx1 = -1;
            else if (w > 0)
                dx1 = 1;

            if (h < 0)
                dy1 = -1;
            else if (h > 0)
                dy1 = 1;

            if (w < 0)
                dx2 = -1;
            else if (w > 0)
                dx2 = 1;

            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);

            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);

                if (h < 0)
                    dy2 = -1;
                else if (h > 0)
                    dy2 = 1;

                dx2 = 0;
            }

            int numerator = longest >> 1;

            for (int i = 0; i <= longest; i++)
            {
                Draw((byte)x, (byte)y,c, (short)color);

                numerator += shortest;

                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
        }
        void circleBres(int xc, int yc, int r)
        {
            int x = 0, y = r;
            int d = 3 - 2 * r;
            drawCircle(xc, yc, x, y);
            while (y >= x)
            {
                // for each pixel we will 
                // draw all eight pixels 

                x++;

                // check for decision parameter 
                // and correspondingly  
                // update d, x, y 
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                    d = d + 4 * x + 6;
                drawCircle(xc, yc, x, y);
            }
        }

        void drawCircle(int xc, int yc, int x, int y)
        {
            Draw('█',(byte)(xc + x), (byte)(yc + y));
            Draw('█',(byte)(xc - x), (byte)(yc + y));
            Draw('█',(byte)(xc + x), (byte)(yc - y));
            Draw('█',(byte)(xc - x), (byte)(yc - y));
            Draw('█',(byte)(xc + y), (byte)(yc + x));
            Draw('█',(byte)(xc - y), (byte)(yc + x));
            Draw('█',(byte)(xc + y), (byte)(yc - x));
            Draw('█', (byte)(xc - y), (byte)(yc - x));
        }

        //deprecated
        public void writeCol(string @string, ConsoleColor color, byte x, byte y)
        {
            // parsing to make it  fly
            // fill the buffer with the string 
            for (int ci = 0; ci < @string.Length; ci++)
            {
                switch (@string[ci])
                {
                    case '\n': // newline char, move to next line, aka y=y+1
                        y++;
                        break;
                    case '\r': // carriage return, aka back to start of line
                        x = 0;
                        break;
                    case ' ': // a space, move the cursor to the right
                        x++;
                        break;
                    default:
                        // calculate where we should be in the buffer
                        int i = y * screenWidth + x;
                        // color
                        buf[i].Attributes = (short)color;
                        // put the current char from the string in the buffer
                        buf[i].Char.AsciiChar = (byte)@string[ci];
                        x++;
                        break;
                }
            }
            // we handled our string, let's write the whole screen at once
            bool success = WriteConsoleOutput(h, buf,
                         new Coord() { X = (short)screenWidth, Y = (short)screenHeight },
                         new Coord() { X = 0, Y = 0 },
                         ref rect);
        }

        public void Draw(string @string, int x, int y, ConsoleColor color = ConsoleColor.White)
        {
            if (x > -screenWidth && x < screenWidth && y > -screenHeight && y < screenHeight)
            {
                for (int ci = 0; ci < @string.Length; ci++)
                {
                    switch (@string[ci])
                    {
                        case '\n': // newline char, move to next line, aka y=y+1
                            y++;
                            break;
                        case '\r': // carriage return, aka back to start of line
                            x = 0;
                            break;
                        case ' ': // a space, move the cursor to the right
                            x++;
                            break;
                        default:
                            // calculate where we should be in the buffer
                            int i = y * screenWidth + x;
                            if (x > -screenWidth && x < screenWidth && y > -screenHeight && y < screenHeight)
                            {
                                // color
                                buf[i].Attributes = (short)color;
                                // put the current char from the string in the buffer
                                buf[i].Char.AsciiChar = (byte)@string[ci];
                                x++;
                            }
                                break;
                    }
                }
            }
        }
        public void Draw(char c, int x, int y, short color = 15)
        {
            if (x > -screenWidth && x < screenWidth && y > -screenHeight && y < screenHeight)
            {
                int i = y * screenWidth + x;
                // color
                buf[i].Attributes = color;
                // put the current char from the string in the buffer
                buf[i].Char.AsciiChar = (byte)c;
                x++;
            }
        }
        public void Draw(int x, int y, int c, short color = 15)
        {

            if (x > -screenWidth && x < screenWidth && y > -screenHeight && y < screenHeight)
            {
                int i = y * screenWidth + x;
                // color
                buf[i].Attributes = color;
                // put the current char from the string in the buffer
                buf[i].Char.AsciiChar = (byte)c;
                x++;
            }
        }
        public void Draw(int x, int y, PIXEL_TYPE c, short color = 15)
        {
            int i = y * screenWidth + x;
            // color

            if (x > -screenWidth && x < screenWidth && y > -screenHeight && y < screenHeight)
            {

                buf[i].Attributes = color;
                // put the current char from the string in the buffer
                buf[i].Char.AsciiChar = (byte)c;
                x++;
            }
        }
        public void Draw(int x, int y, PIXEL_TYPE c, COLOUR colour)
        {
            int i = y * screenWidth + x;
            // color
            if (x > -screenWidth && x < screenWidth && y > -screenHeight && y < screenHeight)
            {
                buf[i].Attributes = (short)colour;
                // put the current char from the string in the buffer
                buf[i].Char.AsciiChar = (byte)c;
            }
            x++;
        }
        public void Draw(byte x, byte y, PIXEL_TYPE c, COLOUR FGcolour, COLOUR BGcolour)
        {
            if (x > -screenWidth && x < screenWidth && y > -screenHeight && y < screenHeight)
            {
                int i = y * screenWidth + x;
                // color
                buf[i].Attributes = (short)((short)FGcolour + (short)BGcolour);
                // put the current char from the string in the buffer
                buf[i].Char.AsciiChar = (byte)c;
            }
            x++;
        }
        Coord screenCorner;
        Coord zeroCoord;
        public void updateScreen ()
        {
            // we handled our string, let's write the whole screen at once
            bool success = WriteConsoleOutput(h, buf,
                          screenCorner,
                         zeroCoord,
                         ref rect);
        }

        //deprecated
        public void clearScreen () {
            buf = new CharInfo[screenWidth * screenHeight];
        }

        public int ScreenHeight()
        {
            return screenHeight-1;
        }

        public COLOUR IntToColour(int i)
        {
            if (i == 0)  return COLOUR.FG_BLACK;
            if (i == 1)  return COLOUR.FG_DARK_BLUE;
            if (i == 2)  return COLOUR.FG_DARK_GREEN;
            if (i == 3)  return COLOUR.FG_DARK_CYAN;
            if (i == 4)  return COLOUR.FG_DARK_RED;
            if (i == 5)  return COLOUR.FG_DARK_MAGENTA;
            if (i == 6)  return COLOUR.FG_DARK_YELLOW;
            if (i == 7)  return COLOUR.FG_GREY;
            if (i == 8)  return COLOUR.FG_DARK_GREY;
            if (i == 9)  return COLOUR.FG_BLUE;
            if (i == 10) return COLOUR.FG_GREEN;
            if (i == 11) return COLOUR.FG_CYAN;
            if (i == 12) return COLOUR.FG_RED;
            if (i == 13) return COLOUR.FG_MAGENTA;
            if (i == 14) return COLOUR.FG_YELLOW;
            if (i == 15) return COLOUR.FG_WHITE;
            if (i == 16) return COLOUR.BG_BLACK;
            if (i == 17) return COLOUR.BG_DARK_BLUE;
            if (i == 18) return COLOUR.BG_DARK_GREEN;
            if (i == 19) return COLOUR.BG_DARK_CYAN;
            if (i == 20) return COLOUR.BG_DARK_RED;
            if (i == 21) return COLOUR.BG_DARK_MAGENTA;
            if (i == 22) return COLOUR.BG_DARK_YELLOW;
            if (i == 23) return COLOUR.BG_GREY;
            if (i == 24) return COLOUR.BG_DARK_GREY;
            if (i == 25) return COLOUR.BG_BLUE;
            if (i == 26) return COLOUR.BG_GREEN;
            if (i == 27) return COLOUR.BG_CYAN;
            if (i == 28) return COLOUR.BG_RED;
            if (i == 29) return COLOUR.BG_MAGENTA;
            if (i == 30) return COLOUR.BG_YELLOW;
            if (i == 31) return COLOUR.BG_WHITE;

            return COLOUR.FG_WHITE;
        }

    }

}