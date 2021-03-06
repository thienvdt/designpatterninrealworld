﻿using System;
using System.ComponentModel;

namespace StaticObj
{
    public static class CommonObj
    {
        public enum SQLEnum
        {
            [Description("This is handle for SQLServer")]
            SQLServer,
            [Description("This is handle for MySQL")]
            MySQL
        }
        public enum SleepTime
        {
            [Description("Sleep 1 seconds")]
            OneSecond = 1000,
            [Description("Sleep 2 seconds")]
            TwoSeconds = 2000
        }
        public enum LoginErrorMessage
        {

            [Description("Cannot login {0} user(s) at the same time")]
            MultipleLoginErrorMessage,
        }
        public enum MilkTeaIngedients
        {
            [Description("sugar")]
            Sugar,
            [Description("coffee")]
            Coffee,
            [Description("milk")]
            Milk,
            [Description("pearl")]
            Pearl,
            [Description("water")]
            Water,
            [Description("tea")]
            Tea
        }
        public enum PhoneCableType
        {
            [Description("lightning")]
            Lightning,
            [Description("microusb")]
            MicroUSBCable
        }
    }
}
