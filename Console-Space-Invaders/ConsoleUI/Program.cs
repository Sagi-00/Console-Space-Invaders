using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using GameLogic;
namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ScreenWidth = 87;
            int ScreenHeight = 43;

            // Make the Console 700*700 pixels
            if (OperatingSystem.IsWindows())
            {
                Console.SetWindowSize(ScreenWidth, ScreenHeight);

                // Ensure buffer is larger than or equal to window size
                Console.BufferWidth = ScreenWidth;
                Console.BufferHeight = ScreenHeight;

            }






        }
    }
}
