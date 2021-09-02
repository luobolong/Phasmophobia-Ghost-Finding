using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Phasmophobia_Ghost_Finding
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        EvidenceModel found_evidence = new EvidenceModel();
        EvidenceModel impossible_evidence = new EvidenceModel();
        EvidenceModel missing_evidence = new EvidenceModel();
        List<int> ghost_index_list = new List<int>();
        
        public MainWindow()
        {
            InitializeComponent();
            SetDefaultLanguageOption();
            FillGhostIndexList();
            ShowAllGhosts();
        }

        private void SetDefaultLanguageOption()
        {
            LanguageOption.Option = LanguageOption.Language.ZH;
        }

        private void UpdateConditions()
        {
            found_evidence.SetFoundEvidence(
                (bool)CheckBoxY1.IsChecked,
                (bool)CheckBoxY2.IsChecked,
                (bool)CheckBoxY3.IsChecked,
                (bool)CheckBoxY4.IsChecked,
                (bool)CheckBoxY5.IsChecked,
                (bool)CheckBoxY6.IsChecked,
                (bool)CheckBoxY7.IsChecked);
            impossible_evidence.SetFoundEvidence(
                (bool)CheckBoxN1.IsChecked,
                (bool)CheckBoxN2.IsChecked,
                (bool)CheckBoxN3.IsChecked,
                (bool)CheckBoxN4.IsChecked,
                (bool)CheckBoxN5.IsChecked,
                (bool)CheckBoxN6.IsChecked,
                (bool)CheckBoxN7.IsChecked);
        }

        private void FillGhostIndexList()
        {
            ghost_index_list.Clear();
            for (int i = 0; i < GhostTypesData.GhostTypes.Count; i++)
            {
                ghost_index_list.Add(i);
            }
        }

        private void UpdateGhostIndexList()
        {
            missing_evidence.SetAllFalse();
            ghost_index_list.Clear();
            for (int i = 0; i < GhostTypesData.GhostTypes.Count; i++)
            {
                if (GhostTypesData.GhostTypes[i].Evidence.CheckConditions(found_evidence, impossible_evidence))
                {
                    ghost_index_list.Add(i);
                    missing_evidence = missing_evidence | GhostTypesData.GhostTypes[i].Evidence.GetMissingEvidence(found_evidence);
                }
            }
        }

        private void SwitchLanguage()
        {
            if (LanguageOption.Option == LanguageOption.Language.ZH)
            {
                Label1.Content = EvidenceNamesData.ZH.EMF_Level_5;
                Label2.Content = EvidenceNamesData.ZH.Spirit_Box;
                Label3.Content = EvidenceNamesData.ZH.Fingerprints;
                Label4.Content = EvidenceNamesData.ZH.Ghost_Orbs;
                Label5.Content = EvidenceNamesData.ZH.Ghost_Writing;
                Label6.Content = EvidenceNamesData.ZH.Freezing_Temperatures;
                Label7.Content = EvidenceNamesData.ZH.DOTS_Projector;
                LabelMissingEvidence.Content = "缺少的证据：";
                ButtonClear.Content = "清空";
                ButtonCopy.Content = "一键复制";
                if (LabelCopy.Content != "")
                {
                    LabelCopy.Content = "已复制";
                }
            }
            else if (LanguageOption.Option == LanguageOption.Language.EN)
            {
                Label1.Content = EvidenceNamesData.EN.EMF_Level_5;
                Label2.Content = EvidenceNamesData.EN.Spirit_Box;
                Label3.Content = EvidenceNamesData.EN.Fingerprints;
                Label4.Content = EvidenceNamesData.EN.Ghost_Orbs;
                Label5.Content = EvidenceNamesData.EN.Ghost_Writing;
                Label6.Content = EvidenceNamesData.EN.Freezing_Temperatures;
                Label7.Content = EvidenceNamesData.EN.DOTS_Projector;
                LabelMissingEvidence.Content = "Missing evidence:";
                ButtonClear.Content = "Clear";
                ButtonCopy.Content = "Copy";
                if (LabelCopy.Content != "")
                {
                    LabelCopy.Content = "Copied";
                }
            }
            ShowMatchedGhosts();
            ShowMissingEvidence();
        }

        private void ShowAllGhosts()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < GhostTypesData.GhostTypes.Count; i++)
            {
                sb.Append(GhostTypesData.GhostTypes[i].ToString() + "\n");
            }
            TextBox1.Text = sb.ToString().Trim();
        }

        private void ShowMatchedGhosts()
        {
            if (ghost_index_list.Count == 0)
            {
                if (LanguageOption.Option == LanguageOption.Language.ZH)
                {
                    TextBox1.Text = "无此种类型的鬼。";
                }
                else if (LanguageOption.Option == LanguageOption.Language.EN)
                {
                    TextBox1.Text = "There is no such type of ghost.";
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (int i in ghost_index_list)
                {
                    sb.Append(GhostTypesData.GhostTypes[i].ToString(found_evidence) + "\n");
                }
                TextBox1.Text = sb.ToString().Trim();
            }
        }

        private void ShowMissingEvidence()
        {
            TextBoxMissingEvidence.Text = missing_evidence.ToString();
        }

        private void LookUp()
        {
            UpdateConditions();
            UpdateGhostIndexList();
            ShowMatchedGhosts();
            ShowMissingEvidence();
        }

        private void CheckBoxY1_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN1.IsChecked)
            {
                CheckBoxN1.IsChecked = false;
            }
            LookUp();
        }

        private void CheckBoxN1_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxY1.IsChecked)
            {
                CheckBoxY1.IsChecked = false;
            }
            LookUp();
        }
        private void CheckBoxY2_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN2.IsChecked)
            {
                CheckBoxN2.IsChecked = false;
            }
            LookUp();
        }

        private void CheckBoxN2_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN2.IsChecked)
            {
                CheckBoxY2.IsChecked = false;
            }
            LookUp();
        }
        private void CheckBoxY3_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN3.IsChecked)
            {
                CheckBoxN3.IsChecked = false;
            }
            LookUp();
        }

        private void CheckBoxN3_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN3.IsChecked)
            {
                CheckBoxY3.IsChecked = false;
            }
            LookUp();
        }
        private void CheckBoxY4_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN4.IsChecked)
            {
                CheckBoxN4.IsChecked = false;
            }
            LookUp();
        }

        private void CheckBoxN4_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN4.IsChecked)
            {
                CheckBoxY4.IsChecked = false;
            }
            LookUp();
        }
        private void CheckBoxY5_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN5.IsChecked)
            {
                CheckBoxN5.IsChecked = false;
            }
            LookUp();
        }

        private void CheckBoxN5_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN5.IsChecked)
            {
                CheckBoxY5.IsChecked = false;
            }
            LookUp();
        }
        private void CheckBoxY6_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN6.IsChecked)
            {
                CheckBoxN6.IsChecked = false;
            }
            LookUp();
        }

        private void CheckBoxN6_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN6.IsChecked)
            {
                CheckBoxY6.IsChecked = false;
            }
            LookUp();
        }
        private void CheckBoxY7_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN7.IsChecked)
            {
                CheckBoxN7.IsChecked = false;
            }
            LookUp();
        }

        private void CheckBoxN7_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxN7.IsChecked)
            {
                CheckBoxY7.IsChecked = false;
            }
            LookUp();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            LookUp();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            CheckBoxY1.IsChecked = false;
            CheckBoxY2.IsChecked = false;
            CheckBoxY3.IsChecked = false;
            CheckBoxY4.IsChecked = false;
            CheckBoxY5.IsChecked = false;
            CheckBoxY6.IsChecked = false;
            CheckBoxY7.IsChecked = false;
            CheckBoxN1.IsChecked = false;
            CheckBoxN2.IsChecked = false;
            CheckBoxN3.IsChecked = false;
            CheckBoxN4.IsChecked = false;
            CheckBoxN5.IsChecked = false;
            CheckBoxN6.IsChecked = false;
            CheckBoxN7.IsChecked = false;
            TextBoxMissingEvidence.Text = "";
            LabelCopy.Content = "";
            UpdateConditions();
            FillGhostIndexList();
            ShowAllGhosts();
        }

        private void RadioButtonZH_Unchecked(object sender, RoutedEventArgs e)
        {
            LanguageOption.Option = LanguageOption.Language.EN;
            SwitchLanguage();
        }

        private void RadioButtonEN_Unchecked(object sender, RoutedEventArgs e)
        {
            LanguageOption.Option = LanguageOption.Language.ZH;
            SwitchLanguage();
        }

        private void ButtonCopy_Click(object sender, RoutedEventArgs e)
        {
            if (LanguageOption.Option == LanguageOption.Language.ZH)
            {
                if (TextBoxMissingEvidence.Text == "")
                {
                    MessageBox.Show("字段为空");
                }
                else
                {
                    Clipboard.SetDataObject(TextBoxMissingEvidence.Text);
                    LabelCopy.Content = "已复制";
                }
            }
            else if (LanguageOption.Option == LanguageOption.Language.EN)
            {
                if (TextBoxMissingEvidence.Text == "")
                {
                    MessageBox.Show("Field is empty");
                }
                else
                {
                    Clipboard.SetDataObject(TextBoxMissingEvidence.Text);
                    LabelCopy.Content = "Copied";
                }
            }
        }
    }
}
