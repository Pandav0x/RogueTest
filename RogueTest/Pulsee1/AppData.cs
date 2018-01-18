﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulsee1
{
    class AppData
    {
        public static string name = "P.U.L.S.E-Engine";
        public static string nameFull = "Panda Unlimited Low Spec Experience Engine";

        public static string version = "0.1.1";

        public static string buildName = "El Bridget";

        public static string buildDate = DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_"+ DateTime.Now.Year.ToString();
     
        public static BuildType buildType = BuildType.Debug;

        public static string devName = "Pandav0x";

        public static bool BuildIsDebug(){return AppData.buildType == BuildType.Debug;}
    }

    public enum BuildType
    {
        Release,
        Debug
    }
}
