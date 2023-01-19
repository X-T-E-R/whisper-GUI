
namespace whisperGUI
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.clearQueue = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComboLan = new System.Windows.Forms.ComboBox();
            this.ComboModel = new System.Windows.Forms.ComboBox();
            this.clearList = new System.Windows.Forms.Button();
            this.cmdPopCheck = new System.Windows.Forms.CheckBox();
            this.saveExtentionSelect = new System.Windows.Forms.CheckedListBox();
            this.autoClear = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clearQueue
            // 
            this.clearQueue.Location = new System.Drawing.Point(26, 172);
            this.clearQueue.Name = "clearQueue";
            this.clearQueue.Size = new System.Drawing.Size(170, 47);
            this.clearQueue.TabIndex = 0;
            this.clearQueue.Text = "clear queue";
            this.clearQueue.UseVisualStyleBackColor = true;
            this.clearQueue.Click += new System.EventHandler(this.clearQueue_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "音视频文件|*.mp4;*.mp3;*.mkv;*.flac;*.wav|所有文件|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("等线", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(834, 47);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(689, 32);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(171, 168);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 90;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(834, 699);
            this.dataGridView1.TabIndex = 2;
            // 
            // ComboLan
            // 
            this.ComboLan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboLan.Font = new System.Drawing.Font("等线", 14F);
            this.ComboLan.FormattingEnabled = true;
            this.ComboLan.Items.AddRange(new object[] {
            "Chinese",
            "English",
            "Japanese",
            "Afrikaans",
            "Albanian",
            "Amharic",
            "Arabic",
            "Armenian",
            "Assamese",
            "Azerbaijani",
            "Bashkir",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bosnian",
            "Breton",
            "Bulgarian",
            "Burmese",
            "Castilian",
            "Catalan",
            "Chinese",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Estonian",
            "Faroese",
            "Finnish",
            "Flemish",
            "French",
            "Galician",
            "Georgian",
            "German",
            "Greek",
            "Gujarati",
            "Haitian",
            "Haitian Creole",
            "Hausa",
            "Hawaiian",
            "Hebrew",
            "Hindi",
            "Hungarian",
            "Icelandic",
            "Indonesian",
            "Italian",
            "Japanese",
            "Javanese",
            "Kannada",
            "Kazakh",
            "Khmer",
            "Korean",
            "Lao",
            "Latin",
            "Latvian",
            "Letzeburgesch",
            "Lingala",
            "Lithuanian",
            "Luxembourgish",
            "Macedonian",
            "Malagasy",
            "Malay",
            "Malayalam",
            "Maltese",
            "Maori",
            "Marathi",
            "Moldavian",
            "Moldovan",
            "Mongolian",
            "Myanmar",
            "Nepali",
            "Norwegian",
            "Nynorsk",
            "Occitan",
            "Panjabi",
            "Pashto",
            "Persian",
            "Polish",
            "Portuguese",
            "Punjabi",
            "Pushto",
            "Romanian",
            "Russian",
            "Sanskrit",
            "Serbian",
            "Shona",
            "Sindhi",
            "Sinhala",
            "Sinhalese",
            "Slovak",
            "Slovenian",
            "Somali",
            "Spanish",
            "Sundanese",
            "Swahili",
            "Swedish",
            "Tagalog",
            "Tajik",
            "Tamil",
            "Tatar",
            "Telugu",
            "Thai",
            "Tibetan",
            "Turkish",
            "Turkmen",
            "Ukrainian",
            "Urdu",
            "Uzbek",
            "Valencian",
            "Vietnamese",
            "Welsh",
            "Yiddish",
            "Yoruba"});
            this.ComboLan.Location = new System.Drawing.Point(26, 32);
            this.ComboLan.Name = "ComboLan";
            this.ComboLan.Size = new System.Drawing.Size(348, 47);
            this.ComboLan.TabIndex = 4;
            this.ComboLan.SelectedIndexChanged += new System.EventHandler(this.ComboLan_SelectedIndexChanged);
            // 
            // ComboModel
            // 
            this.ComboModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboModel.Font = new System.Drawing.Font("等线", 14F);
            this.ComboModel.FormattingEnabled = true;
            this.ComboModel.Items.AddRange(new object[] {
            "tiny",
            "base",
            "small",
            "medium",
            "large"});
            this.ComboModel.Location = new System.Drawing.Point(26, 100);
            this.ComboModel.Name = "ComboModel";
            this.ComboModel.Size = new System.Drawing.Size(348, 47);
            this.ComboModel.TabIndex = 5;
            this.ComboModel.SelectedIndexChanged += new System.EventHandler(this.ComboModel_SelectedIndexChanged);
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(202, 172);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(172, 47);
            this.clearList.TabIndex = 6;
            this.clearList.Text = "clear list";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // cmdPopCheck
            // 
            this.cmdPopCheck.AutoSize = true;
            this.cmdPopCheck.Location = new System.Drawing.Point(412, 148);
            this.cmdPopCheck.Name = "cmdPopCheck";
            this.cmdPopCheck.Size = new System.Drawing.Size(198, 28);
            this.cmdPopCheck.TabIndex = 7;
            this.cmdPopCheck.Text = "silent pop-up";
            this.cmdPopCheck.UseVisualStyleBackColor = true;
            this.cmdPopCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // saveExtentionSelect
            // 
            this.saveExtentionSelect.FormattingEnabled = true;
            this.saveExtentionSelect.Items.AddRange(new object[] {
            ".srt",
            ".vtt",
            ".txt"});
            this.saveExtentionSelect.Location = new System.Drawing.Point(412, 32);
            this.saveExtentionSelect.Name = "saveExtentionSelect";
            this.saveExtentionSelect.Size = new System.Drawing.Size(117, 100);
            this.saveExtentionSelect.TabIndex = 8;
            this.saveExtentionSelect.SelectedIndexChanged += new System.EventHandler(this.saveExtentionSelect_SelectedIndexChanged);
            // 
            // autoClear
            // 
            this.autoClear.AutoSize = true;
            this.autoClear.Location = new System.Drawing.Point(412, 182);
            this.autoClear.Name = "autoClear";
            this.autoClear.Size = new System.Drawing.Size(270, 28);
            this.autoClear.TabIndex = 9;
            this.autoClear.Text = "autoclear bat files";
            this.autoClear.UseVisualStyleBackColor = true;
            this.autoClear.CheckedChanged += new System.EventHandler(this.autoClear_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 1081);
            this.Controls.Add(this.autoClear);
            this.Controls.Add(this.saveExtentionSelect);
            this.Controls.Add(this.cmdPopCheck);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.ComboModel);
            this.Controls.Add(this.ComboLan);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clearQueue);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearQueue;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboLan;
        private System.Windows.Forms.ComboBox ComboModel;
        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.CheckBox cmdPopCheck;
        private System.Windows.Forms.CheckedListBox saveExtentionSelect;
        private System.Windows.Forms.CheckBox autoClear;
    }
}

