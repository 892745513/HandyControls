﻿using System;
using System.Windows;

namespace HandyControl.Data
{
    public class GrowlInfo
    {
        public string Message { get; set; }

        public bool ShowDateTime { get; set; } = true;

        public bool ShowPersianDateTime { get; set; } = false;

        public int WaitTime { get; set; } = 6;

        public string CancelStr { get; set; } = Properties.Langs.Lang.Cancel;

        public string ConfirmStr { get; set; } = Properties.Langs.Lang.Confirm;

        public Func<bool, bool> ActionBeforeClose { get; set; }

        public bool StaysOpen { get; set; }

        public bool IsCustom { get; set; }

        public InfoType Type { get; set; }

        public string IconKey { get; set; }

        public string IconBrushKey { get; set; }

        public bool ShowCloseButton { get; set; } = true;

        public string Token { get; set; }

        public FlowDirection FlowDirection { get; set; }
    }
}
