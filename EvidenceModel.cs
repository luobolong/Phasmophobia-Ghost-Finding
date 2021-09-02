using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmophobia_Ghost_Finding
{
    public class EvidenceModel
    {
        public bool EMF_Level_5 { get; set; }
        public bool Spirit_Box { get; set; }
        public bool Fingerprints { get; set; }
        public bool Ghost_Orbs { get; set; }
        public bool Ghost_Writing { get; set; }
        public bool Freezing_Temperatures { get; set; }
        public bool DOTS_Projector { get; set; }

        public EvidenceModel()
        {
            SetAllFalse();
        }

        public EvidenceModel(bool EMF_Level_5, bool Spirit_Box, bool Fingerprints, bool Ghost_Orbs, bool Ghost_Writing, bool Freezing_Temperatures, bool DOTS_Projector)
        {
            SetFoundEvidence(EMF_Level_5, Spirit_Box, Fingerprints, Ghost_Orbs, Ghost_Writing, Freezing_Temperatures, DOTS_Projector);
        }

        public void SetAllFalse()
        {
            EMF_Level_5 = false;
            Spirit_Box = false;
            Fingerprints = false;
            Ghost_Orbs = false;
            Ghost_Writing = false;
            Freezing_Temperatures = false;
            DOTS_Projector = false;
        }

        public void SetFoundEvidence(bool EMF_Level_5, bool Spirit_Box, bool Fingerprints, bool Ghost_Orbs, bool Ghost_Writing, bool Freezing_Temperatures, bool DOTS_Projector)
        {
            this.EMF_Level_5 = EMF_Level_5;
            this.Spirit_Box = Spirit_Box;
            this.Fingerprints = Fingerprints;
            this.Ghost_Orbs = Ghost_Orbs;
            this.Ghost_Writing = Ghost_Writing;
            this.Freezing_Temperatures = Freezing_Temperatures;
            this.DOTS_Projector = DOTS_Projector;
        }

        public bool CheckFoundEvidence(EvidenceModel found_evidence)
        {
            if ((!found_evidence.EMF_Level_5 || EMF_Level_5 == found_evidence.EMF_Level_5) &&
            (!found_evidence.Spirit_Box || Spirit_Box == found_evidence.Spirit_Box) &&
            (!found_evidence.Fingerprints || Fingerprints == found_evidence.Fingerprints) &&
            (!found_evidence.Ghost_Orbs || Ghost_Orbs == found_evidence.Ghost_Orbs) &&
            (!found_evidence.Ghost_Writing || Ghost_Writing == found_evidence.Ghost_Writing) &&
            (!found_evidence.Freezing_Temperatures || Freezing_Temperatures == found_evidence.Freezing_Temperatures) &&
            (!found_evidence.DOTS_Projector || DOTS_Projector == found_evidence.DOTS_Projector))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckConditions(EvidenceModel found_evidence, EvidenceModel impossible_evidence)
        {
            if (((!EMF_Level_5 && !found_evidence.EMF_Level_5) || (EMF_Level_5 && !impossible_evidence.EMF_Level_5)) &&
                ((!Spirit_Box && !found_evidence.Spirit_Box) || (Spirit_Box && !impossible_evidence.Spirit_Box)) &&
                ((!Fingerprints && !found_evidence.Fingerprints) || (Fingerprints && !impossible_evidence.Fingerprints)) &&
                ((!Ghost_Orbs && !found_evidence.Ghost_Orbs) || (Ghost_Orbs && !impossible_evidence.Ghost_Orbs)) &&
                ((!Ghost_Writing && !found_evidence.Ghost_Writing) || (Ghost_Writing && !impossible_evidence.Ghost_Writing)) &&
                ((!Freezing_Temperatures && !found_evidence.Freezing_Temperatures) || (Freezing_Temperatures && !impossible_evidence.Freezing_Temperatures)) &&
                ((!DOTS_Projector && !found_evidence.DOTS_Projector) || (DOTS_Projector && !impossible_evidence.DOTS_Projector)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public EvidenceModel GetMissingEvidence(EvidenceModel found_evidence)
        {
            return new EvidenceModel(
                EMF_Level_5 && !found_evidence.EMF_Level_5,
                Spirit_Box && !found_evidence.Spirit_Box,
                Fingerprints && !found_evidence.Fingerprints,
                Ghost_Orbs && !found_evidence.Ghost_Orbs,
                Ghost_Writing && !found_evidence.Ghost_Writing,
                Freezing_Temperatures && !found_evidence.Freezing_Temperatures,
                DOTS_Projector && !found_evidence.DOTS_Projector);
        }

        public static EvidenceModel operator |(EvidenceModel evidence1, EvidenceModel evidence2)
        {
            return new EvidenceModel(
                evidence1.EMF_Level_5 || evidence2.EMF_Level_5,
                evidence1.Spirit_Box || evidence2.Spirit_Box,
                evidence1.Fingerprints || evidence2.Fingerprints,
                evidence1.Ghost_Orbs || evidence2.Ghost_Orbs,
                evidence1.Ghost_Writing || evidence2.Ghost_Writing,
                evidence1.Freezing_Temperatures || evidence2.Freezing_Temperatures,
                evidence1.DOTS_Projector || evidence2.DOTS_Projector
                );
        }

        public override string ToString()
        {
            EvidenceNameModel evidence_names = new EvidenceNameModel();
            if (LanguageOption.Option == LanguageOption.Language.ZH)
            {
                evidence_names = EvidenceNamesData.ZH;
            }
            else if (LanguageOption.Option == LanguageOption.Language.EN)
            {
                evidence_names = EvidenceNamesData.EN;
            }
            List<string> evidence_list = new List<string>();
            if (EMF_Level_5)
            {
                evidence_list.Add(evidence_names.EMF_Level_5);
            }
            if (Spirit_Box)
            {
                evidence_list.Add(evidence_names.Spirit_Box);
            }
            if (Freezing_Temperatures)
            {
                evidence_list.Add(evidence_names.Freezing_Temperatures);
            }
            if (Fingerprints)
            {
                evidence_list.Add(evidence_names.Fingerprints);
            }
            if (Ghost_Orbs)
            {
                evidence_list.Add(evidence_names.Ghost_Orbs);
            }
            if (Ghost_Writing)
            {
                evidence_list.Add(evidence_names.Ghost_Writing);
            }
            if (DOTS_Projector)
            {
                evidence_list.Add(evidence_names.DOTS_Projector);
            }

            StringBuilder evidence_string = new StringBuilder();
            for (int i = 0; i < evidence_list.Count; i++)
            {
                evidence_string.Append(evidence_list[i]);
                if (i < evidence_list.Count - 1)
                {
                    if (LanguageOption.Option == LanguageOption.Language.ZH)
                    {
                        evidence_string.Append("、");
                    }
                    else if (LanguageOption.Option == LanguageOption.Language.EN)
                    {
                        evidence_string.Append(", ");
                    }
                }
            }
            return evidence_string.ToString();
        }

        public string ToString(EvidenceModel found_evidence)
        {
            EvidenceNameModel evidence_names = new EvidenceNameModel();
            if (LanguageOption.Option == LanguageOption.Language.ZH)
            {
                evidence_names = EvidenceNamesData.ZH;
            }
            else if (LanguageOption.Option == LanguageOption.Language.EN)
            {
                evidence_names = EvidenceNamesData.EN;
            }
            List<string> needed_evidence_list = new List<string>();
            if (EMF_Level_5 && !found_evidence.EMF_Level_5)
            {
                needed_evidence_list.Add(evidence_names.EMF_Level_5);
            }
            if (Spirit_Box && !found_evidence.Spirit_Box)
            {
                needed_evidence_list.Add(evidence_names.Spirit_Box);
            }
            if (Fingerprints && !found_evidence.Fingerprints)
            {
                needed_evidence_list.Add(evidence_names.Fingerprints);
            }
            if (Ghost_Orbs && !found_evidence.Ghost_Orbs)
            {
                needed_evidence_list.Add(evidence_names.Ghost_Orbs);
            }
            if (Ghost_Writing && !found_evidence.Ghost_Writing)
            {
                needed_evidence_list.Add(evidence_names.Ghost_Writing);
            }
            if (Freezing_Temperatures && !found_evidence.Freezing_Temperatures)
            {
                needed_evidence_list.Add(evidence_names.Freezing_Temperatures);
            }
            if (DOTS_Projector && !found_evidence.DOTS_Projector)
            {
                needed_evidence_list.Add(evidence_names.DOTS_Projector);
            }
            if (needed_evidence_list.Count == 0)
            {
                if (LanguageOption.Option == LanguageOption.Language.ZH)
                {
                    needed_evidence_list.Add("无");
                }
                else if (LanguageOption.Option == LanguageOption.Language.EN)
                {
                    needed_evidence_list.Add("None");
                }
            }
            StringBuilder needed_evidence_string = new StringBuilder();
            for (int i = 0; i < needed_evidence_list.Count; i++)
            {
                needed_evidence_string.Append(needed_evidence_list[i]);
                if (i < needed_evidence_list.Count - 1)
                {
                    if (LanguageOption.Option == LanguageOption.Language.ZH)
                    {
                        needed_evidence_string.Append("、");
                    }
                    else if (LanguageOption.Option == LanguageOption.Language.EN)
                    {
                        needed_evidence_string.Append(", ");
                    }
                }
            }
            return needed_evidence_string.ToString();
        }
    }
}
