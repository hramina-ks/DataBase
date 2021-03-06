﻿namespace DataBase
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.failToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labDatSource = new System.Windows.Forms.Label();
            this.tbDatSource = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.labSQLReq = new System.Windows.Forms.Label();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.datGridSQLResult = new System.Windows.Forms.DataGridView();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dbDataSet = new DataBase.dbDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btClear = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).BeginInit();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // failToolStripMenuItem
            // 
            this.failToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.failToolStripMenuItem.Name = "failToolStripMenuItem";
            this.failToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.failToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::DataBase.Properties.Resources.human_brain_psychiatrist_icon_131296;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = global::DataBase.Properties.Resources.lightning_weather_icon_131720;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // labDatSource
            // 
            this.labDatSource.AutoSize = true;
            this.labDatSource.Location = new System.Drawing.Point(13, 61);
            this.labDatSource.Name = "labDatSource";
            this.labDatSource.Size = new System.Drawing.Size(71, 13);
            this.labDatSource.TabIndex = 1;
            this.labDatSource.Text = "Data Source:";
            // 
            // tbDatSource
            // 
            this.tbDatSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatSource.BackColor = System.Drawing.SystemColors.Info;
            this.tbDatSource.ForeColor = System.Drawing.Color.Green;
            this.tbDatSource.Location = new System.Drawing.Point(85, 58);
            this.tbDatSource.Name = "tbDatSource";
            this.tbDatSource.Size = new System.Drawing.Size(354, 22);
            this.tbDatSource.TabIndex = 2;
            this.tbDatSource.Text = "db.mdb";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(445, 57);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect to DB";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // labSQLReq
            // 
            this.labSQLReq.AutoSize = true;
            this.labSQLReq.Location = new System.Drawing.Point(13, 103);
            this.labSQLReq.Name = "labSQLReq";
            this.labSQLReq.Size = new System.Drawing.Size(73, 13);
            this.labSQLReq.TabIndex = 5;
            this.labSQLReq.Text = "SQL Request:";
            // 
            // tbRequest
            // 
            this.tbRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRequest.BackColor = System.Drawing.SystemColors.Info;
            this.tbRequest.Enabled = false;
            this.tbRequest.ForeColor = System.Drawing.Color.Blue;
            this.tbRequest.Location = new System.Drawing.Point(85, 100);
            this.tbRequest.Multiline = true;
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(492, 22);
            this.tbRequest.TabIndex = 6;
            this.tbRequest.TabStop = false;
            // 
            // btnRequest
            // 
            this.btnRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequest.Enabled = false;
            this.btnRequest.Location = new System.Drawing.Point(680, 98);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(92, 24);
            this.btnRequest.TabIndex = 7;
            this.btnRequest.Text = "Send Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // datGridSQLResult
            // 
            this.datGridSQLResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datGridSQLResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.datGridSQLResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datGridSQLResult.Location = new System.Drawing.Point(16, 140);
            this.datGridSQLResult.Name = "datGridSQLResult";
            this.datGridSQLResult.ReadOnly = true;
            this.datGridSQLResult.RowTemplate.Height = 24;
            this.datGridSQLResult.Size = new System.Drawing.Size(756, 241);
            this.datGridSQLResult.TabIndex = 8;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(784, 25);
            this.toolStripMain.TabIndex = 9;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::DataBase.Properties.Resources.human_brain_psychiatrist_icon_131296;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "About";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::DataBase.Properties.Resources.lightning_weather_icon_131720;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Quit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(543, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.EnabledChanged += new System.EventHandler(this.comboBox1_EnabledChanged);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(583, 98);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(91, 23);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 393);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.datGridSQLResult);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.labSQLReq);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbDatSource);
            this.Controls.Add(this.labDatSource);
            this.Controls.Add(this.menuStripMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::DataBase.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::DataBase.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(400, 355);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет заказов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datGridSQLResult)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem failToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label labDatSource;
        private System.Windows.Forms.TextBox tbDatSource;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labSQLReq;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DataGridView datGridSQLResult;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btClear;
    }
}

