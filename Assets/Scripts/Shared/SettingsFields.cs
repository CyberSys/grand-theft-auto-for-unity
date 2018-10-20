﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace GrandTheftAuto.Shared {
    public partial class Settings : ISerializationCallbackReceiver {

        public string gtaIII;
        public string gtaVC;
        public string gtaSA;

        public int numberOfThreads;

        public bool gpuDecoding = false;
        public bool useMipmaps = false;
        public bool compressTextures = true;
        public string logFilePath;
        public string timingsFolder;
        public string fileBrowser;

        public Settings() {
            numberOfThreads = SystemInfo.processorCount;
            logFilePath = Path.Combine("log.txt");
            timingsFolder = Path.Combine("Timings");
            fileBrowser = Path.Combine(Application.streamingAssetsPath, "FileBrowser", "FileBrowser.exe");
        }

        public void OnBeforeSerialize() { }

        public void OnAfterDeserialize() { }

    }
}