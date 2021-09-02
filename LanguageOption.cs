using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmophobia_Ghost_Finding
{
    public static class LanguageOption
    {
        public enum Language
        {
            ZH,
            EN
        }
        public static Language Option { get; set; } = Language.ZH;
    }
}
