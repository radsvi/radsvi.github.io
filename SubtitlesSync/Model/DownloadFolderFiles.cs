﻿using SubtitlesSync.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitlesSync.Model
{
    internal class DownloadFolderFiles : ViewModelBase
    {
        private string fileName; // full name with path and suffix

        public string FileName
        {
            get { return fileName; }
            set {
                fileName = value;
                OnPropertyChanged();
            }
        }

        public string BaseName { get; set; } // name without suffix and without path
        public string ShortName { get; set; } // name with suffix, but without path
        public string Suffix { get; set; } // suffix in format ".srt"
        public bool ToTransfer { get; set; }
    }
}
