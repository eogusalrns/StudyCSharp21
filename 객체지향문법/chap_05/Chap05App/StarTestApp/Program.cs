﻿using System;

namespace StarTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 첫번째별모양
            for (int i = 0; i < 5; i++) //행
            {
                for (int j = 0; j < i + 1; j++) //열
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            #endregion

            #region 두번째별모양
            for (int i = 0; i < 5; i++) //행
            {
                for (int j = 0; j < 5-i; j++) //열
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            #endregion
        }
    }
}
