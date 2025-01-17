﻿using System;

namespace TelephoneBook.TelephonesLib
{
    public static class StringExt
    {
        public static int? ToNullableInt32(this string s)
        {
            int i;
            if (Int32.TryParse(s, out i)) return i;
            return null;
        }
    }
}