﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using _3DScanning.Model;

namespace _3DScanning.ViewModel
{
    class ScanManagerVM
    {
        private ScanManager Model { get; set; }

        public ScanManagerVM()
        {
            /*
            using (StreamReader r = new StreamReader("defaultJson.json"))
            {
                var jsonString = r.ReadToEnd();
                Model = JsonSerializer.Deserialize<ScanManager>(jsonString);
            }
            */

        }

        public void Capture()
        {
            Model.SavePointCloud(Model.ScanObject(), "xyz");
        }

        public void Calibrate()
        {
            Model.Calibrate();
        }
    }
}
