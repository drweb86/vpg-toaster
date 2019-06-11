namespace vpg_toaster
{
    partial class MainWindow
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
            this._appInfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this._infoLabel = new System.Windows.Forms.Label();
            this._motherlandPictureBox = new System.Windows.Forms.PictureBox();
            this._notificationsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this._selectNotificationTypesLabel = new System.Windows.Forms.Label();
            this._mainUiTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._uiFirstRowTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._goButton = new System.Windows.Forms.Button();
            this._shellTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._shellMenuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this._motherlandPictureBox)).BeginInit();
            this._mainUiTableLayoutPanel.SuspendLayout();
            this._uiFirstRowTableLayoutPanel.SuspendLayout();
            this._shellTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // _appInfoLinkLabel
            // 
            this._appInfoLinkLabel.AutoSize = true;
            this._appInfoLinkLabel.Location = new System.Drawing.Point(3, 0);
            this._appInfoLinkLabel.Name = "_appInfoLinkLabel";
            this._appInfoLinkLabel.Size = new System.Drawing.Size(199, 13);
            this._appInfoLinkLabel.TabIndex = 0;
            this._appInfoLinkLabel.TabStop = true;
            this._appInfoLinkLabel.Text = "https://github.com/drweb86/vpg-toaster";
            // 
            // _infoLabel
            // 
            this._infoLabel.AutoSize = true;
            this._infoLabel.Location = new System.Drawing.Point(219, 0);
            this._infoLabel.Name = "_infoLabel";
            this._infoLabel.Size = new System.Drawing.Size(322, 78);
            this._infoLabel.TabIndex = 1;
            this._infoLabel.Text = "Приложение для отображения toast нотификаций на рабочем столе, \r\nсвязанных с курс" +
    "ом \"Возрождение природного голоса\" Плешакова Качалина\r\nАвтор: Кучук Сергей\r\nЛице" +
    "нзия: Microsoft Public License";
            // 
            // _motherlandPictureBox
            // 
            this._motherlandPictureBox.Image = global::vpg_toaster.Properties.Resources.Belorus_Flag;
            this._motherlandPictureBox.Location = new System.Drawing.Point(576, 3);
            this._motherlandPictureBox.Name = "_motherlandPictureBox";
            this._motherlandPictureBox.Size = new System.Drawing.Size(116, 52);
            this._motherlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._motherlandPictureBox.TabIndex = 2;
            this._motherlandPictureBox.TabStop = false;
            // 
            // _notificationsCheckedListBox
            // 
            this._notificationsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._notificationsCheckedListBox.FormattingEnabled = true;
            this._notificationsCheckedListBox.Location = new System.Drawing.Point(18, 115);
            this._notificationsCheckedListBox.Name = "_notificationsCheckedListBox";
            this._notificationsCheckedListBox.Size = new System.Drawing.Size(698, 154);
            this._notificationsCheckedListBox.TabIndex = 3;
            // 
            // _selectNotificationTypesLabel
            // 
            this._selectNotificationTypesLabel.AutoSize = true;
            this._selectNotificationTypesLabel.Location = new System.Drawing.Point(18, 99);
            this._selectNotificationTypesLabel.Name = "_selectNotificationTypesLabel";
            this._selectNotificationTypesLabel.Size = new System.Drawing.Size(318, 13);
            this._selectNotificationTypesLabel.TabIndex = 4;
            this._selectNotificationTypesLabel.Text = "Выберите уведомления, о которых показывать нотификации";
            // 
            // _mainUiTableLayoutPanel
            // 
            this._mainUiTableLayoutPanel.ColumnCount = 1;
            this._mainUiTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainUiTableLayoutPanel.Controls.Add(this._notificationsCheckedListBox, 0, 2);
            this._mainUiTableLayoutPanel.Controls.Add(this._selectNotificationTypesLabel, 0, 1);
            this._mainUiTableLayoutPanel.Controls.Add(this._uiFirstRowTableLayoutPanel, 0, 0);
            this._mainUiTableLayoutPanel.Controls.Add(this._goButton, 0, 3);
            this._mainUiTableLayoutPanel.Location = new System.Drawing.Point(49, 148);
            this._mainUiTableLayoutPanel.Name = "_mainUiTableLayoutPanel";
            this._mainUiTableLayoutPanel.Padding = new System.Windows.Forms.Padding(15);
            this._mainUiTableLayoutPanel.RowCount = 4;
            this._mainUiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainUiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainUiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainUiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainUiTableLayoutPanel.Size = new System.Drawing.Size(734, 353);
            this._mainUiTableLayoutPanel.TabIndex = 5;
            // 
            // _uiFirstRowTableLayoutPanel
            // 
            this._uiFirstRowTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._uiFirstRowTableLayoutPanel.AutoSize = true;
            this._uiFirstRowTableLayoutPanel.ColumnCount = 3;
            this._uiFirstRowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.77038F));
            this._uiFirstRowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.22962F));
            this._uiFirstRowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this._uiFirstRowTableLayoutPanel.Controls.Add(this._appInfoLinkLabel, 0, 0);
            this._uiFirstRowTableLayoutPanel.Controls.Add(this._motherlandPictureBox, 2, 0);
            this._uiFirstRowTableLayoutPanel.Controls.Add(this._infoLabel, 1, 0);
            this._uiFirstRowTableLayoutPanel.Location = new System.Drawing.Point(18, 18);
            this._uiFirstRowTableLayoutPanel.Name = "_uiFirstRowTableLayoutPanel";
            this._uiFirstRowTableLayoutPanel.RowCount = 1;
            this._uiFirstRowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._uiFirstRowTableLayoutPanel.Size = new System.Drawing.Size(698, 78);
            this._uiFirstRowTableLayoutPanel.TabIndex = 5;
            // 
            // _goButton
            // 
            this._goButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._goButton.Location = new System.Drawing.Point(544, 289);
            this._goButton.Name = "_goButton";
            this._goButton.Size = new System.Drawing.Size(172, 46);
            this._goButton.TabIndex = 6;
            this._goButton.Text = "Начать планирование уведомлений";
            this._goButton.UseVisualStyleBackColor = true;
            // 
            // _shellTabControl
            // 
            this._shellTabControl.Controls.Add(this.tabPage1);
            this._shellTabControl.Controls.Add(this.tabPage2);
            this._shellTabControl.Location = new System.Drawing.Point(12, 28);
            this._shellTabControl.Name = "_shellTabControl";
            this._shellTabControl.SelectedIndex = 0;
            this._shellTabControl.Size = new System.Drawing.Size(771, 114);
            this._shellTabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 88);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 88);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _shellMenuStrip
            // 
            this._shellMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._shellMenuStrip.Name = "_shellMenuStrip";
            this._shellMenuStrip.Size = new System.Drawing.Size(806, 24);
            this._shellMenuStrip.TabIndex = 8;
            this._shellMenuStrip.Text = "menuStrip1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 513);
            this.Controls.Add(this._shellTabControl);
            this.Controls.Add(this._mainUiTableLayoutPanel);
            this.Controls.Add(this._shellMenuStrip);
            this.MainMenuStrip = this._shellMenuStrip;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPG - Toaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this._motherlandPictureBox)).EndInit();
            this._mainUiTableLayoutPanel.ResumeLayout(false);
            this._mainUiTableLayoutPanel.PerformLayout();
            this._uiFirstRowTableLayoutPanel.ResumeLayout(false);
            this._uiFirstRowTableLayoutPanel.PerformLayout();
            this._shellTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel _appInfoLinkLabel;
        private System.Windows.Forms.Label _infoLabel;
        private System.Windows.Forms.PictureBox _motherlandPictureBox;
        private System.Windows.Forms.CheckedListBox _notificationsCheckedListBox;
        private System.Windows.Forms.Label _selectNotificationTypesLabel;
        private System.Windows.Forms.TableLayoutPanel _mainUiTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _uiFirstRowTableLayoutPanel;
        private System.Windows.Forms.Button _goButton;
        private System.Windows.Forms.TabControl _shellTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip _shellMenuStrip;
    }
}

