namespace WinFormsBsp_Net
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_KlickMich = new System.Windows.Forms.Button();
            this.Cbx_HakMichAb = new System.Windows.Forms.CheckBox();
            this.Cbb_Items = new System.Windows.Forms.ComboBox();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.Lbx_Collection = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uswToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffenenAlsDateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wasAnderesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_KlickMich
            // 
            this.Btn_KlickMich.BackColor = System.Drawing.Color.Lime;
            this.Btn_KlickMich.Location = new System.Drawing.Point(0, 354);
            this.Btn_KlickMich.Name = "Btn_KlickMich";
            this.Btn_KlickMich.Size = new System.Drawing.Size(113, 58);
            this.Btn_KlickMich.TabIndex = 0;
            this.Btn_KlickMich.Text = "Klick Mich";
            this.Btn_KlickMich.UseVisualStyleBackColor = false;
            this.Btn_KlickMich.Click += new System.EventHandler(this.Btn_KlickMich_Click);
            // 
            // Cbx_HakMichAb
            // 
            this.Cbx_HakMichAb.AutoSize = true;
            this.Cbx_HakMichAb.Checked = true;
            this.Cbx_HakMichAb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cbx_HakMichAb.Location = new System.Drawing.Point(158, 391);
            this.Cbx_HakMichAb.Name = "Cbx_HakMichAb";
            this.Cbx_HakMichAb.Size = new System.Drawing.Size(109, 21);
            this.Cbx_HakMichAb.TabIndex = 1;
            this.Cbx_HakMichAb.Text = "Hak Mich Ab";
            this.Cbx_HakMichAb.UseVisualStyleBackColor = true;
            // 
            // Cbb_Items
            // 
            this.Cbb_Items.FormattingEnabled = true;
            this.Cbb_Items.Items.AddRange(new object[] {
            "Eintrag 1",
            "Auswahl 2",
            "Item 3"});
            this.Cbb_Items.Location = new System.Drawing.Point(12, 86);
            this.Cbb_Items.Name = "Cbb_Items";
            this.Cbb_Items.Size = new System.Drawing.Size(184, 24);
            this.Cbb_Items.TabIndex = 2;
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.AutoSize = true;
            this.Lbl_Output.Location = new System.Drawing.Point(37, 148);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(118, 17);
            this.Lbl_Output.TabIndex = 3;
            this.Lbl_Output.Text = "Dies ist ein String";
            // 
            // Lbx_Collection
            // 
            this.Lbx_Collection.FormattingEnabled = true;
            this.Lbx_Collection.ItemHeight = 16;
            this.Lbx_Collection.Items.AddRange(new object[] {
            "Eintrag 1",
            "Item 2"});
            this.Lbx_Collection.Location = new System.Drawing.Point(35, 187);
            this.Lbx_Collection.Name = "Lbx_Collection";
            this.Lbx_Collection.Size = new System.Drawing.Size(120, 84);
            this.Lbx_Collection.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(330, 199);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(330, 238);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(26, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(26, 59);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 21);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(522, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RadioGroup";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.uswToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // uswToolStripMenuItem
            // 
            this.uswToolStripMenuItem.Name = "uswToolStripMenuItem";
            this.uswToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.uswToolStripMenuItem.Text = "usw";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.neuToolStripMenuItem.Text = "Neu";
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffenenAlsDateiToolStripMenuItem,
            this.wasAnderesToolStripMenuItem});
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.speichernToolStripMenuItem.Text = "Speichern";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // öffenenAlsDateiToolStripMenuItem
            // 
            this.öffenenAlsDateiToolStripMenuItem.Name = "öffenenAlsDateiToolStripMenuItem";
            this.öffenenAlsDateiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.öffenenAlsDateiToolStripMenuItem.Text = "Öffenen als Datei";
            // 
            // wasAnderesToolStripMenuItem
            // 
            this.wasAnderesToolStripMenuItem.Name = "wasAnderesToolStripMenuItem";
            this.wasAnderesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.wasAnderesToolStripMenuItem.Text = "was anderes";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Lbx_Collection);
            this.Controls.Add(this.Lbl_Output);
            this.Controls.Add(this.Cbb_Items);
            this.Controls.Add(this.Cbx_HakMichAb);
            this.Controls.Add(this.Btn_KlickMich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_KlickMich;
        private System.Windows.Forms.CheckBox Cbx_HakMichAb;
        private System.Windows.Forms.ComboBox Cbb_Items;
        private System.Windows.Forms.Label Lbl_Output;
        private System.Windows.Forms.ListBox Lbx_Collection;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffenenAlsDateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wasAnderesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uswToolStripMenuItem;
    }
}

