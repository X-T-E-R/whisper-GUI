using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser.Model;
using IniParser;



namespace whisperGUI
{
    public partial class Form1 : Form
    {

        void SaveIni()
        {
            // create a new INI file parser
            var parser = new FileIniDataParser();

            // load the INI file
            IniParser.Model.IniData iniData;
            if (!File.Exists("config.ini"))
            {
                // create an empty ini data
                iniData = new IniParser.Model.IniData();
            }
            else
            {
                // load the INI file
                iniData = parser.ReadFile("config.ini");
            }

            // set the values of the sections
            iniData["ComboLan"]["Value"] = (string)ComboLan.SelectedItem;
            iniData["ComboModel"]["Value"] = (string)ComboModel.SelectedItem;
            iniData["cmdPopCheck"]["Value"] = cmdPopCheck.Checked.ToString();
            StringBuilder selectedItems = new StringBuilder();
            foreach (var item in saveExtentionSelect.CheckedItems)
            {
                selectedItems.Append(item + ",");
            }

            iniData["saveExtentionSelect"]["Value"] = selectedItems.ToString();
            iniData["autoclear"]["Value"] = autoClear.Checked.ToString();

            // save the INI file
            parser.WriteFile("config.ini", iniData);
        }
        void ReadIni()
        {
            // create a new INI file parser
            var parser = new FileIniDataParser();

            // load the INI file
            IniParser.Model.IniData iniData;
            if (!File.Exists("config.ini"))
            {
                // create an empty ini data
                iniData = new IniParser.Model.IniData();

            }
            else
            {
                // load the INI file
                iniData = parser.ReadFile("config.ini");
            }
            try
            {
                // load the INI file

                string ComboLanValue = iniData["ComboLan"]["Value"];
                if (string.IsNullOrWhiteSpace(ComboLanValue))
                {
                    ComboLanValue = "Chinese";
                }
                ComboLan.SelectedItem = ComboLanValue;

                string ComboModelValue = iniData["ComboModel"]["Value"];
                if (string.IsNullOrWhiteSpace(ComboModelValue))
                {
                    ComboModelValue = "medium";
                }
                ComboModel.SelectedItem = ComboModelValue;

                string cmdPopCheckValue = iniData["cmdPopCheck"]["Value"];
                if (string.IsNullOrWhiteSpace(cmdPopCheckValue))
                {
                    cmdPopCheckValue = "True";
                }
                cmdPopCheck.Checked = bool.Parse(cmdPopCheckValue);

                string ext = iniData["saveExtentionSelect"]["Value"];
                if (string.IsNullOrWhiteSpace(ext))
                {
                    ext = ".srt";
                }
                string[] selectedItems = ext.Split(',');
                for (int i = 0; i < selectedItems.Length; i++)
                {
                    saveExtentionSelect.SetItemChecked(saveExtentionSelect.Items.IndexOf(selectedItems[i]), true);
                }

                string autoClearValue = iniData["autoclear"]["Value"];
                if (string.IsNullOrWhiteSpace(autoClearValue))
                {
                    cmdPopCheckValue = "False";
                }
                autoClear.Checked = Convert.ToBoolean(autoClearValue);
                // set the values to the corresponding controls

                    
                    
            }
            catch (Exception ex)
            {
                //在这里处理异常,例如显示错误信息给用户
                MessageBox.Show(ex.Message);
            }
            if (!File.Exists("config.ini"))
            {
                // create an empty ini data
                SaveIni();
            }

            // get the values of the sections
        }
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("FileName", "File Name"); // Create a new column named "FileName" and display name "File Name"
            dataGridView1.Columns.Add("Status", "Status");  // Create a new column named "Status" and display name "Status"
            dataGridView1.Columns[0].Width = 200;
            ReadIni();
            
        }
        List<string> filesToDealWith = new List<string>();
        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Text = string.Join("/", openFileDialog1.FileName);
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string file in openFileDialog1.FileNames)
            {
                filesToDealWith.Add(file);
                string fileName = Path.GetFileName(file);
                dataGridView1.Rows.Add(fileName, "Wait");
            }
        }
        private void clearQueue_Click(object sender, EventArgs e)
        {
            filesToDealWith.Clear();
                
        }
        string RemoveLastDot(string fileName)
        {
            int lastDotIndex = fileName.LastIndexOf(".");
            if (lastDotIndex != -1)
            {
                fileName = fileName.Substring(0, lastDotIndex);
            }
            return fileName;
        }
        void clearSRT(string file,string BatFileName)
        {
            try
            {
                string fileName = Path.GetFileName(file);
                string pureFileName = RemoveLastDot(fileName);
                string[] extentions = { ".srt", ".vtt", ".txt" };
                foreach (var extention in extentions)
                {
                    if (saveExtentionSelect.CheckedItems.Contains(extention))
                    {
                        string newFileName = pureFileName + extention;
                        string oldFile = fileName + extention;
                        string newFile = Path.Combine(Path.GetDirectoryName(file), newFileName);
                        if (autoClear.Checked)
                            File.Move(oldFile, newFile);
                        else
                            File.Copy(oldFile, newFile);
                    }
                    else
                    {
                        string oldFile = fileName + extention;
                        if (autoClear.Checked)
                            File.Delete(oldFile);
                    }
                }
                if(autoClear.Checked)
                    File.Delete(BatFileName);
            }
            catch (FileNotFoundException e)
            {
                // File not found, handle the exception
                Console.WriteLine("The file was not found: " + e.Message);
            }
            catch (IOException e)
            {
                // An I/O error occurred, handle the exception
                Console.WriteLine("An I/O error occurred: " + e.Message);
            }
        }
        void ExecuteBatFile(string fileName)
        {
            Process process = new Process();
            process.StartInfo.FileName = fileName;
            if (cmdPopCheck.Checked)
            {
                process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            }
            else
            {
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            }
            process.Start();
            process.WaitForExit();
        }
        void UpdateStatus(string fileName, string status)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == fileName)
                {
                    row.Cells[1].Value = status;
                    row.Selected=true;
                    break;
                }
            }
        }
        string modelQuality, SelectedLanguage;
        private void startButton_Click(object sender, EventArgs e)
        {
            
            foreach (string file in filesToDealWith)
            {
                string fileName = Path.GetFileName(file);
                string BatFileName = "whisper_" + fileName + ".bat";
                List<string> lines = new List<string>();
                lines.Add("whisper \"" + file + "\" --model "+ modelQuality+" --language "+ SelectedLanguage);
                File.WriteAllLines(BatFileName, lines, Encoding.GetEncoding("GB2312"));
                UpdateStatus(fileName, "In progress");
                ExecuteBatFile(BatFileName);
                clearSRT(file, BatFileName);
                UpdateStatus(fileName, "Done");
            }
            filesToDealWith.Clear();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SaveIni();
        }
        private void clearList_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            filesToDealWith.Clear();
        }
        private void ComboLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedLanguage = ComboLan.Text;
            SaveIni();
        }

        private void autoClear_CheckedChanged(object sender, EventArgs e)
        {
            SaveIni();
        }

        private void saveExtentionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveIni();
        }

        private void ComboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelQuality = ComboModel.Text;
            SaveIni();
        }


    }
}
