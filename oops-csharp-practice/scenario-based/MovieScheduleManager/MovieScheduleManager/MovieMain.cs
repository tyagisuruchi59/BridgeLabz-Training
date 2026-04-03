using System;
using System.Collections.Generic;
using System.Text;
using BridgeLabzTraining.oops.scenarioBased.movieScheduleManager;

namespace BridgeLabzTraining.oops.scenarioBased.movieScheduleManager
{
    internal class MovieMain
    {
        public static void Main(string[] args)
        {
            MovieMenu menu = new MovieMenu();
            menu.ShowMenu();
        }
    }
}
