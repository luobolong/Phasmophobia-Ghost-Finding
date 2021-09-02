using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmophobia_Ghost_Finding
{
    public class GhostTypeModel
    {
        public string Name_ZH { get; set; }
        public string Name_EN { get; set; }
        public string Introduction_ZH { get; set; }
        public string Introduction_EN { get; set; }
        public string Unique_Strenths_ZH { get; set; }
        public string Unique_Strenths_EN { get; set; }
        public string Weaknesses_ZH { get; set; }
        public string Weaknesses_EN { get; set; }
        public EvidenceModel Evidence { get; set; }

        public override string ToString()
        {
            if (LanguageOption.Option == LanguageOption.Language.ZH)
            {
                return Name_ZH + "\n" + Introduction_ZH + "\n特征：" + Unique_Strenths_ZH + "\n弱点：" + Weaknesses_ZH + "\n证据：" + Evidence.ToString() + "。\n";
            }
            else if (LanguageOption.Option == LanguageOption.Language.EN)
            {
                return Name_EN + "\n" + Introduction_EN + "\nUnique Strenths: " + Unique_Strenths_EN + "\nWeaknesses: " + Weaknesses_EN + "\nEvidence: " + Evidence.ToString() + ".\n";
            }
            return "";
        }

        public string ToString(EvidenceModel found_evidence)
        {
            if (LanguageOption.Option == LanguageOption.Language.ZH)
            {
                return Name_ZH + "\n" + Introduction_ZH + "\n特征：" + Unique_Strenths_ZH + "\n弱点：" + Weaknesses_ZH + "\n证据：" + Evidence.ToString(found_evidence) + "。\n";
            }
            else if (LanguageOption.Option == LanguageOption.Language.EN)
            {
                return Name_EN + "\n" + Introduction_EN + "\nUnique Strenths: " + Unique_Strenths_EN + "\nWeaknesses: " + Weaknesses_EN + "\nEvidence: " + Evidence.ToString(found_evidence) + ".\n";
            }
            return "";
        }
    }
}
