using System;
using System.Runtime.InteropServices;

namespace Codes
{    
    class Program
    {
        [DllImport("imm32.dll")]        
        static extern IntPtr ImmGetDefaultIMEWnd(IntPtr hWnd);        

        [DllImport("user32.dll", CharSet = CharSet.Auto)]        
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr IParam);        
        const int WM_IME_CONTROL = 643;

              
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(isKorean(args[0]));
        }
        
        static int isKorean(String pname)
        {
            /* 
                Return 값 설명
                0: Null / 1: 한국어 / 2: 영어 
            */
                     
            if (Process.GetProcessesByName(pname).FirstOrDefault() == null)
            {
                Console.WriteLine("프로세스 발견 못함");
                return 0;
            }
                
        
            IntPtr hwnd = Process.GetProcessesByName(pname).FirstOrDefault().MainWindowHandle;
            IntPtr hime = ImmGetDefaultIMEWnd(hwnd);
            IntPtr status = SendMessage(hime, WM_IME_CONTROL, new IntPtr(0x5), new IntPtr(0));
        
            if (status.ToInt32() != 0) // 한글인경우
                return 1;
            
            else
                return 2;
        }     
       
    }
}



