namespace WindowsFormsxmlprojeevren
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamaHakkımdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.yeniToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.duzeltToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.silToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kopyalaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.yapistirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yardimToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.clbYapilacaklarListesi = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstTamamlananlarListesi = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.todoToolStripMenuItem,
            this.hakkımdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // todoToolStripMenuItem
            // 
            this.todoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.düzeltToolStripMenuItem,
            this.silToolStripMenuItem});
            this.todoToolStripMenuItem.Name = "todoToolStripMenuItem";
            this.todoToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.todoToolStripMenuItem.Text = "Todo";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Image = global::WindowsFormsxmlprojeevren.Properties.Resources.plus_24_16;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // düzeltToolStripMenuItem
            // 
            this.düzeltToolStripMenuItem.Image = global::WindowsFormsxmlprojeevren.Properties.Resources.new_24_16;
            this.düzeltToolStripMenuItem.Name = "düzeltToolStripMenuItem";
            this.düzeltToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.düzeltToolStripMenuItem.Text = "Düzelt";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::WindowsFormsxmlprojeevren.Properties.Resources.cross_24_16;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // hakkımdaToolStripMenuItem
            // 
            this.hakkımdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamaHakkımdaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.hakkımdaToolStripMenuItem.Name = "hakkımdaToolStripMenuItem";
            this.hakkımdaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hakkımdaToolStripMenuItem.Text = "Hakkımda";
            // 
            // uygulamaHakkımdaToolStripMenuItem
            // 
            this.uygulamaHakkımdaToolStripMenuItem.Name = "uygulamaHakkımdaToolStripMenuItem";
            this.uygulamaHakkımdaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.uygulamaHakkımdaToolStripMenuItem.Text = "Uygulama Hakkımda";
            this.uygulamaHakkımdaToolStripMenuItem.Click += new System.EventHandler(this.uygulamaHakkımdaToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripButton,
            this.duzeltToolStripButton,
            this.silToolStripButton,
            this.toolStripSeparator,
            this.kesToolStripButton,
            this.kopyalaToolStripButton,
            this.yapistirToolStripButton,
            this.toolStripSeparator1,
            this.yardimToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // yeniToolStripButton
            // 
            this.yeniToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yeniToolStripButton.Image = global::WindowsFormsxmlprojeevren.Properties.Resources.plus_24_16;
            this.yeniToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yeniToolStripButton.Name = "yeniToolStripButton";
            this.yeniToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.yeniToolStripButton.Text = "yeni";
            this.yeniToolStripButton.Click += new System.EventHandler(this.yeniToolStripButton_Click);
            // 
            // duzeltToolStripButton
            // 
            this.duzeltToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.duzeltToolStripButton.Image = global::WindowsFormsxmlprojeevren.Properties.Resources.new_24_16;
            this.duzeltToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.duzeltToolStripButton.Name = "duzeltToolStripButton";
            this.duzeltToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.duzeltToolStripButton.Text = "duzelt";
            this.duzeltToolStripButton.Click += new System.EventHandler(this.duzeltToolStripButton_Click);
            // 
            // silToolStripButton
            // 
            this.silToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.silToolStripButton.Image = global::WindowsFormsxmlprojeevren.Properties.Resources.cross_24_16;
            this.silToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.silToolStripButton.Name = "silToolStripButton";
            this.silToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.silToolStripButton.Text = "sil";
            this.silToolStripButton.Click += new System.EventHandler(this.silToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // kesToolStripButton
            // 
            this.kesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kesToolStripButton.Image")));
            this.kesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kesToolStripButton.Name = "kesToolStripButton";
            this.kesToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.kesToolStripButton.Text = "kes";
            this.kesToolStripButton.Click += new System.EventHandler(this.kesToolStripButton_Click);
            // 
            // kopyalaToolStripButton
            // 
            this.kopyalaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kopyalaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kopyalaToolStripButton.Image")));
            this.kopyalaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopyalaToolStripButton.Name = "kopyalaToolStripButton";
            this.kopyalaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.kopyalaToolStripButton.Text = "kopyala";
            this.kopyalaToolStripButton.Click += new System.EventHandler(this.kopyalaToolStripButton_Click);
            // 
            // yapistirToolStripButton
            // 
            this.yapistirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yapistirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("yapistirToolStripButton.Image")));
            this.yapistirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yapistirToolStripButton.Name = "yapistirToolStripButton";
            this.yapistirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.yapistirToolStripButton.Text = "yapistir";
            this.yapistirToolStripButton.Click += new System.EventHandler(this.yapistirToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // yardimToolStripButton
            // 
            this.yardimToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yardimToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("yardimToolStripButton.Image")));
            this.yardimToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yardimToolStripButton.Name = "yardimToolStripButton";
            this.yardimToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.yardimToolStripButton.Text = "yardim";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.clbYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 401);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yapılacaklar Listesi";
            // 
            // clbYapilacaklarListesi
            // 
            this.clbYapilacaklarListesi.FormattingEnabled = true;
            this.clbYapilacaklarListesi.Location = new System.Drawing.Point(3, 155);
            this.clbYapilacaklarListesi.Name = "clbYapilacaklarListesi";
            this.clbYapilacaklarListesi.Size = new System.Drawing.Size(242, 244);
            this.clbYapilacaklarListesi.TabIndex = 3;
            this.clbYapilacaklarListesi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbYapilacaklarListesi_ItemCheck);
            this.clbYapilacaklarListesi.SelectedIndexChanged += new System.EventHandler(this.clbYapilacaklarListesi_SelectedIndexChanged);
            this.clbYapilacaklarListesi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clbYapilacaklarListesi_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupYeniGorev";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 65);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstTamamlananlarListesi);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 386);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamamlananlar Listesi";
            // 
            // lstTamamlananlarListesi
            // 
            this.lstTamamlananlarListesi.FormattingEnabled = true;
            this.lstTamamlananlarListesi.Location = new System.Drawing.Point(6, 19);
            this.lstTamamlananlarListesi.Name = "lstTamamlananlarListesi";
            this.lstTamamlananlarListesi.Size = new System.Drawing.Size(527, 368);
            this.lstTamamlananlarListesi.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Bilgilendirme";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Yapılacaklar Listesi";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Yapılacaklar Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamaHakkımdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton yeniToolStripButton;
        private System.Windows.Forms.ToolStripButton duzeltToolStripButton;
        private System.Windows.Forms.ToolStripButton silToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton kesToolStripButton;
        private System.Windows.Forms.ToolStripButton kopyalaToolStripButton;
        private System.Windows.Forms.ToolStripButton yapistirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton yardimToolStripButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox clbYapilacaklarListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstTamamlananlarListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

