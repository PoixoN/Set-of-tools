namespace Set_of_tools
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPassLength = new System.Windows.Forms.NumericUpDown();
            this.clbPassword = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbNotebook = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbRand = new System.Windows.Forms.CheckBox();
            this.btnRandCopy = new System.Windows.Forms.Button();
            this.btnRandClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblRand = new System.Windows.Forms.Label();
            this.btnRand = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.btnClearPassword = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.btnConvector = new System.Windows.Forms.Button();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.cbMetrics = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.notebookToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(328, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(93, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // notebookToolStripMenuItem
            // 
            this.notebookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiInsertTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.notebookToolStripMenuItem.Name = "notebookToolStripMenuItem";
            this.notebookToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.notebookToolStripMenuItem.Text = "Notebook";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiInsertDate.Size = new System.Drawing.Size(203, 22);
            this.tsmiInsertDate.Text = "Insert date";
            this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
            // 
            // tsmiInsertTime
            // 
            this.tsmiInsertTime.Name = "tsmiInsertTime";
            this.tsmiInsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiInsertTime.Size = new System.Drawing.Size(203, 22);
            this.tsmiInsertTime.Text = "Insert time";
            this.tsmiInsertTime.Click += new System.EventHandler(this.pasteTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(203, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.tsmiLoad.Size = new System.Drawing.Size(203, 22);
            this.tsmiLoad.Text = "Load";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(156, 22);
            this.tsmiAbout.Text = "About My tools";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(328, 288);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnClearPassword);
            this.tabPage4.Controls.Add(this.btnCopyPassword);
            this.tabPage4.Controls.Add(this.tbPassword);
            this.tabPage4.Controls.Add(this.btnCreatePassword);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.nudPassLength);
            this.tabPage4.Controls.Add(this.clbPassword);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(320, 262);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Passwords";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(8, 164);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(304, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.Location = new System.Drawing.Point(192, 76);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(120, 23);
            this.btnCreatePassword.TabIndex = 3;
            this.btnCreatePassword.Text = "Create password";
            this.btnCreatePassword.UseVisualStyleBackColor = true;
            this.btnCreatePassword.Click += new System.EventHandler(this.bCreatePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "length";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nudPassLength
            // 
            this.nudPassLength.Location = new System.Drawing.Point(261, 35);
            this.nudPassLength.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudPassLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPassLength.Name = "nudPassLength";
            this.nudPassLength.Size = new System.Drawing.Size(51, 20);
            this.nudPassLength.TabIndex = 1;
            this.nudPassLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudPassLength.ValueChanged += new System.EventHandler(this.nudPassLength_ValueChanged);
            // 
            // clbPassword
            // 
            this.clbPassword.CheckOnClick = true;
            this.clbPassword.FormattingEnabled = true;
            this.clbPassword.Items.AddRange(new object[] {
            "Digits",
            "Uppercase letters",
            "Lowcase letters",
            "Special symbols: %, *, ), ?, #..."});
            this.clbPassword.Location = new System.Drawing.Point(8, 35);
            this.clbPassword.Name = "clbPassword";
            this.clbPassword.Size = new System.Drawing.Size(174, 64);
            this.clbPassword.TabIndex = 0;
            this.clbPassword.SelectedIndexChanged += new System.EventHandler(this.clbPassword_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbNotebook);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(320, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notebook";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbNotebook
            // 
            this.rtbNotebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotebook.Location = new System.Drawing.Point(0, 0);
            this.rtbNotebook.Name = "rtbNotebook";
            this.rtbNotebook.Size = new System.Drawing.Size(320, 262);
            this.rtbNotebook.TabIndex = 0;
            this.rtbNotebook.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbRand);
            this.tabPage2.Controls.Add(this.btnRandCopy);
            this.tabPage2.Controls.Add(this.btnRandClear);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbRand);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.lblRand);
            this.tabPage2.Controls.Add(this.btnRand);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(320, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generator";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cbRand
            // 
            this.cbRand.AutoSize = true;
            this.cbRand.Location = new System.Drawing.Point(12, 93);
            this.cbRand.Name = "cbRand";
            this.cbRand.Size = new System.Drawing.Size(111, 17);
            this.cbRand.TabIndex = 10;
            this.cbRand.Text = "without repetitions";
            this.cbRand.UseVisualStyleBackColor = true;
            // 
            // btnRandCopy
            // 
            this.btnRandCopy.Location = new System.Drawing.Point(184, 113);
            this.btnRandCopy.Name = "btnRandCopy";
            this.btnRandCopy.Size = new System.Drawing.Size(75, 23);
            this.btnRandCopy.TabIndex = 9;
            this.btnRandCopy.Text = "Copy";
            this.btnRandCopy.UseVisualStyleBackColor = true;
            this.btnRandCopy.Click += new System.EventHandler(this.btnRandCopy_Click);
            // 
            // btnRandClear
            // 
            this.btnRandClear.Location = new System.Drawing.Point(265, 113);
            this.btnRandClear.Name = "btnRandClear";
            this.btnRandClear.Size = new System.Drawing.Size(47, 23);
            this.btnRandClear.TabIndex = 8;
            this.btnRandClear.Text = "Clear";
            this.btnRandClear.UseVisualStyleBackColor = true;
            this.btnRandClear.Click += new System.EventHandler(this.btnRandClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your random numbers";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbRand
            // 
            this.tbRand.Location = new System.Drawing.Point(6, 142);
            this.tbRand.Multiline = true;
            this.tbRand.Name = "tbRand";
            this.tbRand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRand.Size = new System.Drawing.Size(306, 112);
            this.tbRand.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "from";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(80, 52);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(80, 11);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRand
            // 
            this.lblRand.AutoSize = true;
            this.lblRand.Location = new System.Drawing.Point(179, 54);
            this.lblRand.Name = "lblRand";
            this.lblRand.Size = new System.Drawing.Size(85, 13);
            this.lblRand.TabIndex = 1;
            this.lblRand.Text = "Random number";
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(182, 8);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(75, 23);
            this.btnRand.TabIndex = 0;
            this.btnRand.Text = "Make";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnMinus);
            this.tabPage1.Controls.Add(this.btnPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(320, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Counter";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(103, 110);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            this.lblCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(198, 95);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 40);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(62, 164);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(102, 40);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(62, 36);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(102, 40);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Location = new System.Drawing.Point(8, 135);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(75, 23);
            this.btnCopyPassword.TabIndex = 5;
            this.btnCopyPassword.Text = "Copy";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearPassword
            // 
            this.btnClearPassword.Location = new System.Drawing.Point(99, 135);
            this.btnClearPassword.Name = "btnClearPassword";
            this.btnClearPassword.Size = new System.Drawing.Size(75, 23);
            this.btnClearPassword.TabIndex = 6;
            this.btnClearPassword.Text = "Clear";
            this.btnClearPassword.UseVisualStyleBackColor = true;
            this.btnClearPassword.Click += new System.EventHandler(this.btnClearPassword_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbMetrics);
            this.tabPage5.Controls.Add(this.btnSwap);
            this.tabPage5.Controls.Add(this.tbTo);
            this.tabPage5.Controls.Add(this.tbFrom);
            this.tabPage5.Controls.Add(this.btnConvector);
            this.tabPage5.Controls.Add(this.cbTo);
            this.tabPage5.Controls.Add(this.cbFrom);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(320, 262);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Convertor";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbFrom.Location = new System.Drawing.Point(36, 126);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(83, 21);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "mm";
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbTo.Location = new System.Drawing.Point(206, 126);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(83, 21);
            this.cbTo.TabIndex = 1;
            this.cbTo.Text = "mm";
            this.cbTo.SelectedIndexChanged += new System.EventHandler(this.cbTo_SelectedIndexChanged);
            // 
            // btnConvector
            // 
            this.btnConvector.Location = new System.Drawing.Point(102, 84);
            this.btnConvector.Name = "btnConvector";
            this.btnConvector.Size = new System.Drawing.Size(121, 36);
            this.btnConvector.TabIndex = 2;
            this.btnConvector.Text = "Convert";
            this.btnConvector.UseVisualStyleBackColor = true;
            this.btnConvector.Click += new System.EventHandler(this.btnConvector_Click);
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(36, 163);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(83, 20);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "0";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(206, 163);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(83, 20);
            this.tbTo.TabIndex = 4;
            this.tbTo.Text = "0";
            this.tbTo.TextChanged += new System.EventHandler(this.tbTo_TextChanged);
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(125, 143);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.Text = "<->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // cbMetrics
            // 
            this.cbMetrics.FormattingEnabled = true;
            this.cbMetrics.Items.AddRange(new object[] {
            "Length",
            "Mass"});
            this.cbMetrics.Location = new System.Drawing.Point(102, 57);
            this.cbMetrics.Name = "cbMetrics";
            this.cbMetrics.Size = new System.Drawing.Size(121, 21);
            this.cbMetrics.TabIndex = 6;
            this.cbMetrics.Text = "Length";
            this.cbMetrics.SelectedIndexChanged += new System.EventHandler(this.cbMetrics_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 312);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "My tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblRand;
        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRand;
        private System.Windows.Forms.Button btnRandClear;
        private System.Windows.Forms.Button btnRandCopy;
        private System.Windows.Forms.CheckBox cbRand;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbNotebook;
        private System.Windows.Forms.ToolStripMenuItem notebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertTime;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox clbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPassLength;
        private System.Windows.Forms.Button btnCreatePassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnCopyPassword;
        private System.Windows.Forms.Button btnClearPassword;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button btnConvector;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.ComboBox cbMetrics;
    }
}

