using UbiParser;
using Newtonsoft.Json;

namespace ParserGUI
{
    public partial class ParserGUI : Form
    {
        private string openFile = "Manifest";
        public ParserGUI()
        {
            InitializeComponent();
        }

        private void OpenFileAsButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    if (filePath.Length > 0)
                    {
                        string ParsedText = "Currently nothing parsed";
                        switch (openFile)
                        {
                            case "ClubCache":
                                var parsedClub = Parsers.ParseClubCacheFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parsedClub, Formatting.Indented);
                                break;
                            case "ConfigurationCache":
                                var parsedConf = Parsers.ParseConfigurationCacheFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parsedConf, Formatting.Indented);
                                break;
                            case "ConversationCache":
                                var parsedConv = Parsers.ParseConversationFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parsedConv, Formatting.Indented);
                                break;
                            case "DownloadInstallState":
                                var parsedState = Parsers.ParseDownloadStateFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parsedState, Formatting.Indented);
                                break;
                            case "DownloadManifest":
                                var parsedManifest = Parsers.ParseManifestFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parsedManifest, Formatting.Indented);
                                break;
                            case "GameActivationListCache":
                                var parsedActivation = Parsers.ParseActivationsFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parsedActivation, Formatting.Indented);
                                break;
                            case "GameStatsCache":
                                var parsedStats = Parsers.ParseStatsFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parsedStats, Formatting.Indented);
                                break;
                            case "OwnershipCache":
                                var parsedOwnership = Parsers.ParseOwnerShipFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parsedOwnership, Formatting.Indented);
                                break;
                            case "PlaytimeCache":
                                var parseTime = Parsers.ParsePlaytimeFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parseTime, Formatting.Indented);
                                break;
                            case "UserDat":
                                var parseUserDat = Parsers.ParseUserDatFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parseUserDat, Formatting.Indented);
                                break;
                            case "UserSettings":
                                var parseUserSettings = Parsers.ParseUserSettingsFile(filePath);
                                ParsedText = JsonConvert.SerializeObject(parseUserSettings, Formatting.Indented);
                                break;
                            default:
                                return;
                        }

                        richTextBox1.Text = ParsedText;
                    }
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);

            openFile = checkedListBox1.Items[e.Index].ToString();
        }
    }
}