namespace Кукина
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeBut = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewLineBut = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьВыбраннуюСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраннуюСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortBut = new System.Windows.Forms.ToolStripMenuItem();
            this.SortRayon = new System.Windows.Forms.ToolStripMenuItem();
            this.SortVidUch = new System.Windows.Forms.ToolStripMenuItem();
            this.SortDist = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltersBut = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterFormOfIncorpBut = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterVidUchrBut = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateT = new System.Windows.Forms.ToolStripButton();
            this.OpenT = new System.Windows.Forms.ToolStripButton();
            this.SaveT = new System.Windows.Forms.ToolStripButton();
            this.SaveAsT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.AddT = new System.Windows.Forms.ToolStripButton();
            this.ChangeT = new System.Windows.Forms.ToolStripButton();
            this.DeleteT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Append = new System.Windows.Forms.ToolStripMenuItem();
            this.AppendT = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ChangeBut,
            this.SortBut,
            this.FiltersBut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNew,
            this.OpenFile,
            this.Save,
            this.SaveAs,
            this.Append});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // CreateNew
            // 
            this.CreateNew.Name = "CreateNew";
            this.CreateNew.Size = new System.Drawing.Size(216, 26);
            this.CreateNew.Text = "Создать";
            this.CreateNew.Click += new System.EventHandler(this.CreateNew_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(216, 26);
            this.OpenFile.Text = "Открыть";
            this.OpenFile.Click += new System.EventHandler(this.Open_File);
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(216, 26);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.SaveFile_Clicked);
            // 
            // SaveAs
            // 
            this.SaveAs.Enabled = false;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(216, 26);
            this.SaveAs.Text = "Сохранить как...";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // ChangeBut
            // 
            this.ChangeBut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewLineBut,
            this.изменитьВыбраннуюСтрокуToolStripMenuItem,
            this.удалитьВыбраннуюСтрокуToolStripMenuItem});
            this.ChangeBut.Enabled = false;
            this.ChangeBut.Name = "ChangeBut";
            this.ChangeBut.Size = new System.Drawing.Size(90, 24);
            this.ChangeBut.Text = "Изменить";
            // 
            // AddNewLineBut
            // 
            this.AddNewLineBut.Name = "AddNewLineBut";
            this.AddNewLineBut.Size = new System.Drawing.Size(288, 26);
            this.AddNewLineBut.Text = "Добавить новую строку";
            this.AddNewLineBut.Click += new System.EventHandler(this.AddNewLine);
            // 
            // изменитьВыбраннуюСтрокуToolStripMenuItem
            // 
            this.изменитьВыбраннуюСтрокуToolStripMenuItem.Name = "изменитьВыбраннуюСтрокуToolStripMenuItem";
            this.изменитьВыбраннуюСтрокуToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.изменитьВыбраннуюСтрокуToolStripMenuItem.Text = "Изменить выбранную строку";
            this.изменитьВыбраннуюСтрокуToolStripMenuItem.Click += new System.EventHandler(this.ChangingTheLine);
            // 
            // удалитьВыбраннуюСтрокуToolStripMenuItem
            // 
            this.удалитьВыбраннуюСтрокуToolStripMenuItem.Name = "удалитьВыбраннуюСтрокуToolStripMenuItem";
            this.удалитьВыбраннуюСтрокуToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.удалитьВыбраннуюСтрокуToolStripMenuItem.Text = "Удалить выбранную строку";
            this.удалитьВыбраннуюСтрокуToolStripMenuItem.Click += new System.EventHandler(this.DeleteLine_Click);
            // 
            // SortBut
            // 
            this.SortBut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortRayon,
            this.SortVidUch,
            this.SortDist});
            this.SortBut.Enabled = false;
            this.SortBut.Name = "SortBut";
            this.SortBut.Size = new System.Drawing.Size(111, 24);
            this.SortBut.Text = "Сортировать";
            // 
            // SortRayon
            // 
            this.SortRayon.Name = "SortRayon";
            this.SortRayon.Size = new System.Drawing.Size(226, 26);
            this.SortRayon.Text = "По rayon";
            this.SortRayon.Click += new System.EventHandler(this.SortRayon_Click);
            // 
            // SortVidUch
            // 
            this.SortVidUch.Name = "SortVidUch";
            this.SortVidUch.Size = new System.Drawing.Size(226, 26);
            this.SortVidUch.Text = "По vid_uchrezhdenia ";
            this.SortVidUch.Click += new System.EventHandler(this.SortVidUch_Click);
            // 
            // SortDist
            // 
            this.SortDist.Name = "SortDist";
            this.SortDist.Size = new System.Drawing.Size(226, 26);
            this.SortDist.Text = "По удаленности";
            this.SortDist.Click += new System.EventHandler(this.SortDist_Click);
            // 
            // FiltersBut
            // 
            this.FiltersBut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьФильтрToolStripMenuItem,
            this.CancelFilters});
            this.FiltersBut.Enabled = false;
            this.FiltersBut.Name = "FiltersBut";
            this.FiltersBut.Size = new System.Drawing.Size(83, 24);
            this.FiltersBut.Text = "Фильтры";
            // 
            // добавитьФильтрToolStripMenuItem
            // 
            this.добавитьФильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterFormOfIncorpBut,
            this.FilterVidUchrBut});
            this.добавитьФильтрToolStripMenuItem.Name = "добавитьФильтрToolStripMenuItem";
            this.добавитьФильтрToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.добавитьФильтрToolStripMenuItem.Text = "Добавить фильтр";
            // 
            // FilterFormOfIncorpBut
            // 
            this.FilterFormOfIncorpBut.Name = "FilterFormOfIncorpBut";
            this.FilterFormOfIncorpBut.Size = new System.Drawing.Size(254, 26);
            this.FilterFormOfIncorpBut.Text = "по form_of_incorporation";
            this.FilterFormOfIncorpBut.Click += new System.EventHandler(this.FilterFormOfIncorpBut_Click);
            // 
            // FilterVidUchrBut
            // 
            this.FilterVidUchrBut.Name = "FilterVidUchrBut";
            this.FilterVidUchrBut.Size = new System.Drawing.Size(254, 26);
            this.FilterVidUchrBut.Text = "по vid_uchrezhdeniya";
            this.FilterVidUchrBut.Click += new System.EventHandler(this.FilterVidUchrBut_Click);
            // 
            // CancelFilters
            // 
            this.CancelFilters.Enabled = false;
            this.CancelFilters.Name = "CancelFilters";
            this.CancelFilters.Size = new System.Drawing.Size(209, 26);
            this.CancelFilters.Text = "Сбросить фильры";
            this.CancelFilters.Click += new System.EventHandler(this.CancelFilters_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateT,
            this.OpenT,
            this.SaveT,
            this.SaveAsT,
            this.AppendT,
            this.toolStripSeparator,
            this.AddT,
            this.ChangeT,
            this.DeleteT,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(743, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CreateT
            // 
            this.CreateT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateT.Image = ((System.Drawing.Image)(resources.GetObject("CreateT.Image")));
            this.CreateT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateT.Name = "CreateT";
            this.CreateT.Size = new System.Drawing.Size(24, 24);
            this.CreateT.Text = "&Создать";
            this.CreateT.Click += new System.EventHandler(this.CreateNew_Click);
            // 
            // OpenT
            // 
            this.OpenT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenT.Image = ((System.Drawing.Image)(resources.GetObject("OpenT.Image")));
            this.OpenT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenT.Name = "OpenT";
            this.OpenT.Size = new System.Drawing.Size(24, 24);
            this.OpenT.Text = "&Открыть";
            this.OpenT.Click += new System.EventHandler(this.Open_File);
            // 
            // SaveT
            // 
            this.SaveT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveT.Enabled = false;
            this.SaveT.Image = ((System.Drawing.Image)(resources.GetObject("SaveT.Image")));
            this.SaveT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveT.Name = "SaveT";
            this.SaveT.Size = new System.Drawing.Size(24, 24);
            this.SaveT.Text = "&Сохранить";
            this.SaveT.Click += new System.EventHandler(this.SaveFile_Clicked);
            // 
            // SaveAsT
            // 
            this.SaveAsT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsT.Enabled = false;
            this.SaveAsT.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsT.Image")));
            this.SaveAsT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsT.Name = "SaveAsT";
            this.SaveAsT.Size = new System.Drawing.Size(24, 24);
            this.SaveAsT.Text = "Сохранить как";
            this.SaveAsT.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // AddT
            // 
            this.AddT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddT.Enabled = false;
            this.AddT.Image = ((System.Drawing.Image)(resources.GetObject("AddT.Image")));
            this.AddT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddT.Name = "AddT";
            this.AddT.Size = new System.Drawing.Size(24, 24);
            this.AddT.Text = "Добавить";
            this.AddT.Click += new System.EventHandler(this.AddNewLine);
            // 
            // ChangeT
            // 
            this.ChangeT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChangeT.Enabled = false;
            this.ChangeT.Image = ((System.Drawing.Image)(resources.GetObject("ChangeT.Image")));
            this.ChangeT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeT.Name = "ChangeT";
            this.ChangeT.Size = new System.Drawing.Size(24, 24);
            this.ChangeT.Text = "Изменить";
            this.ChangeT.Click += new System.EventHandler(this.ChangingTheLine);
            // 
            // DeleteT
            // 
            this.DeleteT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteT.Enabled = false;
            this.DeleteT.Image = ((System.Drawing.Image)(resources.GetObject("DeleteT.Image")));
            this.DeleteT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteT.Name = "DeleteT";
            this.DeleteT.Size = new System.Drawing.Size(24, 24);
            this.DeleteT.Text = "Удалить";
            this.DeleteT.Click += new System.EventHandler(this.DeleteLine_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // Append
            // 
            this.Append.Enabled = false;
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(216, 26);
            this.Append.Text = "Добавить к...";
            this.Append.Click += new System.EventHandler(this.Append_Click);
            // 
            // AppendT
            // 
            this.AppendT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AppendT.Enabled = false;
            this.AppendT.Image = ((System.Drawing.Image)(resources.GetObject("AppendT.Image")));
            this.AppendT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AppendT.Name = "AppendT";
            this.AppendT.Size = new System.Drawing.Size(24, 24);
            this.AppendT.Text = "Сохранить к...";
            this.AppendT.Click += new System.EventHandler(this.Append_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 449);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Кружки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CreateNew;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem SortBut;
        private System.Windows.Forms.ToolStripMenuItem SortRayon;
        private System.Windows.Forms.ToolStripMenuItem SortVidUch;
        private System.Windows.Forms.ToolStripMenuItem SortDist;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ChangeBut;
        private System.Windows.Forms.ToolStripMenuItem AddNewLineBut;
        private System.Windows.Forms.ToolStripMenuItem FiltersBut;
        private System.Windows.Forms.ToolStripMenuItem добавитьФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterFormOfIncorpBut;
        private System.Windows.Forms.ToolStripMenuItem FilterVidUchrBut;
        private System.Windows.Forms.ToolStripMenuItem CancelFilters;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраннуюСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьВыбраннуюСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CreateT;
        private System.Windows.Forms.ToolStripButton OpenT;
        private System.Windows.Forms.ToolStripButton SaveT;
        private System.Windows.Forms.ToolStripButton SaveAsT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton AddT;
        private System.Windows.Forms.ToolStripButton ChangeT;
        private System.Windows.Forms.ToolStripButton DeleteT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Append;
        private System.Windows.Forms.ToolStripButton AppendT;
    }
}

