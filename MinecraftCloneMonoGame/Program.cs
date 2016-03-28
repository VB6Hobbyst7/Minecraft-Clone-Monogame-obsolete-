﻿using System;

namespace MinecraftCloneMonoGame
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new MinecraftClone.MinecraftClone())
                game.Run();
        }
    }
#endif
}