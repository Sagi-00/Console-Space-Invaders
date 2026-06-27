using GameLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int ScreenWidth = 93;
            int ScreenHeight = 43;
            Player Ship = new Player(ScreenWidth / 2, ScreenHeight -2);


            SetScreenSize(ScreenWidth, ScreenHeight);


            while (true)
            {
                
                DrawScreen(ScreenWidth, ScreenHeight, Ship);


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Escape) break;

                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        Ship.Move(Ship.PlayerSpeed, ScreenWidth);
                    }
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        Ship.Move(-Ship.PlayerSpeed, ScreenWidth);
                    }
                }
                Thread.Sleep(33);
            }

         }
            
               






            






        
        static void DrawScreen(int ScreenWidth, int ScreenHeight, Player Ship)
        {
          
            StringBuilder renderBuffer = new StringBuilder(ScreenWidth * ScreenHeight);
            char[,] backBuffer = new char[ScreenHeight, ScreenWidth];


            for (int i = 0; i < ScreenHeight; i++)
            {

                for (int j = 0; j < ScreenWidth; j++)
                {
                    backBuffer[i, j] = ' ';
                }
            }
               
                  
         

            backBuffer[Ship.PlayerPosY, Ship.PlayerPosX] = '#';




            // renders the back buffer to the screen
            renderBuffer.Clear();
            for (int i = 0; i < ScreenHeight; i++)
            {
                for (int j = 0; j < ScreenWidth; j++)
                {
                    renderBuffer.Append(backBuffer[i, j]);
                }
                if (i < ScreenHeight - 1) renderBuffer.AppendLine();
            }


            Console.SetCursorPosition(0, 0);
            Console.Write(renderBuffer.ToString());
            
        }

        static void SetScreenSize(int ScreenWidth, int ScreenHeight)
        {

            // Make the Console 700*700 pixels
            if (OperatingSystem.IsWindows())
            {
                Console.SetWindowSize(ScreenWidth, ScreenHeight);

                // Ensure buffer is larger than or equal to window size
               Console.SetBufferSize(ScreenWidth, ScreenHeight);

            }
        }

    }
}
