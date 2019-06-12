﻿namespace vpg_toaster.Tools.Toaster.Views
{
    partial class ToasterMainView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._mainUiTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._notificationsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this._selectNotificationTypesLabel = new System.Windows.Forms.Label();
            this._goButton = new System.Windows.Forms.Button();
            this._mainUiTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainUiTableLayoutPanel
            // 
            this._mainUiTableLayoutPanel.ColumnCount = 1;
            this._mainUiTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainUiTableLayoutPanel.Controls.Add(this._notificationsCheckedListBox, 0, 1);
            this._mainUiTableLayoutPanel.Controls.Add(this._selectNotificationTypesLabel, 0, 0);
            this._mainUiTableLayoutPanel.Controls.Add(this._goButton, 0, 2);
            this._mainUiTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainUiTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._mainUiTableLayoutPanel.Name = "_mainUiTableLayoutPanel";
            this._mainUiTableLayoutPanel.Padding = new System.Windows.Forms.Padding(15);
            this._mainUiTableLayoutPanel.RowCount = 3;
            this._mainUiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainUiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mainUiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._mainUiTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._mainUiTableLayoutPanel.Size = new System.Drawing.Size(948, 451);
            this._mainUiTableLayoutPanel.TabIndex = 6;
            // 
            // _notificationsCheckedListBox
            // 
            this._notificationsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._notificationsCheckedListBox.FormattingEnabled = true;
            this._notificationsCheckedListBox.Location = new System.Drawing.Point(18, 31);
            this._notificationsCheckedListBox.Name = "_notificationsCheckedListBox";
            this._notificationsCheckedListBox.Size = new System.Drawing.Size(912, 349);
            this._notificationsCheckedListBox.TabIndex = 3;
            // 
            // _selectNotificationTypesLabel
            // 
            this._selectNotificationTypesLabel.AutoSize = true;
            this._selectNotificationTypesLabel.Location = new System.Drawing.Point(18, 15);
            this._selectNotificationTypesLabel.Name = "_selectNotificationTypesLabel";
            this._selectNotificationTypesLabel.Size = new System.Drawing.Size(318, 13);
            this._selectNotificationTypesLabel.TabIndex = 4;
            this._selectNotificationTypesLabel.Text = "Выберите уведомления, о которых показывать нотификации";
            // 
            // _goButton
            // 
            this._goButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._goButton.Location = new System.Drawing.Point(758, 387);
            this._goButton.Name = "_goButton";
            this._goButton.Size = new System.Drawing.Size(172, 46);
            this._goButton.TabIndex = 6;
            this._goButton.Text = "Начать планирование уведомлений";
            this._goButton.UseVisualStyleBackColor = true;
            // 
            // ToasterMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._mainUiTableLayoutPanel);
            this.Name = "ToasterMainView";
            this.Size = new System.Drawing.Size(948, 451);
            this._mainUiTableLayoutPanel.ResumeLayout(false);
            this._mainUiTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _mainUiTableLayoutPanel;
        private System.Windows.Forms.CheckedListBox _notificationsCheckedListBox;
        private System.Windows.Forms.Label _selectNotificationTypesLabel;
        private System.Windows.Forms.Button _goButton;
    }
}
