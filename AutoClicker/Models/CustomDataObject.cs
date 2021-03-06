﻿using System.Collections.Generic;

namespace AutoClicker.Models
{
    public class CustomDataObject
    {
        public string ClientName { get; set; }
        public bool FullScreenWhenAuto { get; set; }
        public ScreenResolution ScreenResolution { get; set; }
        public List<Profile> Profiles { get; set; }
    }
}
