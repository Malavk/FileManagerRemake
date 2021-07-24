using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFileManager
{
    class Config
    {
        public int InfoWindowHeight { get; }
        public int CommandLineHeight { get; }
        public string LastFolder { get; set; }
        public string SettingsFile { get; }
        public int NumberOfPages { get; set; }
        public int PageLines { get; }
        public int ConsoleHeight { get; }
        public int ConsoleWidth { get; }
        public int bufferHeight { get; }
        public int bufferWidth { get; }
        
        public Config()
        {
            InfoWindowHeight = 5;
            CommandLineHeight = 2;
            LastFolder = "C:\\";
            SettingsFile = "Settings.json";
            NumberOfPages = 1;
            PageLines = 45;
            ConsoleHeight = PageLines + InfoWindowHeight + CommandLineHeight + 1;
            ConsoleWidth = 200;
            bufferHeight = ConsoleHeight;
            bufferWidth = 200;
        }
    }
}
