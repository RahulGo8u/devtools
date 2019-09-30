using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BusinessLayer.Enums
{
    public enum CharacterSetEnum
    {
        None = 0,
        ASCII = 1,
        UTF7 = 2,
        UTF8 = 3,
        [Description("Unicode")]
        UTF16 = 4,
        UTF32 = 5,
        ISO_8859_1 = 6
    }
}
