using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RLCore.FileSystem
{
    public class FileSystem
    {
        public string RootPath { get; set; }
        public string WebRootPath { get; set; }

        public string TempPath {
            get {
                var full = RootPath + "/tmp";
                if (!Directory.Exists(full))
                {
                    Directory.CreateDirectory(full);
                }
                return full;
            }
        }
    }
}
