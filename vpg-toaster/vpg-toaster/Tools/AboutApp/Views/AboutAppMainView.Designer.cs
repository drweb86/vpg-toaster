namespace vpg_toaster.Tools.AboutApp.Views
{
    partial class AboutAppMainView
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
            this._uiFirstRowTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._appInfoLinkLabel = new System.Windows.Forms.LinkLabel();
            this._motherlandPictureBox = new System.Windows.Forms.PictureBox();
            this._infoLabel = new System.Windows.Forms.Label();
            this._uiFirstRowTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._motherlandPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _uiFirstRowTableLayoutPanel
            // 
            this._uiFirstRowTableLayoutPanel.AutoSize = true;
            this._uiFirstRowTableLayoutPanel.ColumnCount = 3;
            this._uiFirstRowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.48411F));
            this._uiFirstRowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.51589F));
            this._uiFirstRowTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this._uiFirstRowTableLayoutPanel.Controls.Add(this._appInfoLinkLabel, 0, 0);
            this._uiFirstRowTableLayoutPanel.Controls.Add(this._motherlandPictureBox, 2, 0);
            this._uiFirstRowTableLayoutPanel.Controls.Add(this._infoLabel, 1, 0);
            this._uiFirstRowTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._uiFirstRowTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._uiFirstRowTableLayoutPanel.Name = "_uiFirstRowTableLayoutPanel";
            this._uiFirstRowTableLayoutPanel.RowCount = 1;
            this._uiFirstRowTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._uiFirstRowTableLayoutPanel.Size = new System.Drawing.Size(948, 451);
            this._uiFirstRowTableLayoutPanel.TabIndex = 5;
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
            // _motherlandPictureBox
            // 
            this._motherlandPictureBox.Image = global::vpg_toaster.Properties.Resources.Belorus_Flag;
            this._motherlandPictureBox.Location = new System.Drawing.Point(821, 3);
            this._motherlandPictureBox.Name = "_motherlandPictureBox";
            this._motherlandPictureBox.Size = new System.Drawing.Size(116, 52);
            this._motherlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._motherlandPictureBox.TabIndex = 2;
            this._motherlandPictureBox.TabStop = false;
            // 
            // _infoLabel
            // 
            this._infoLabel.AutoSize = true;
            this._infoLabel.Location = new System.Drawing.Point(236, 0);
            this._infoLabel.Name = "_infoLabel";
            this._infoLabel.Size = new System.Drawing.Size(405, 52);
            this._infoLabel.TabIndex = 1;
            this._infoLabel.Text = "Приложение для отображения toast нотификаций на рабочем столе, \r\nсвязанных с курс" +
    "ом \"Возрождение природного голоса\" Плешакова Качалина\r\nАвтор: Кучук Сергей\r\nЛице" +
    "нзия: Microsoft Public License";
            // 
            // AboutAppMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._uiFirstRowTableLayoutPanel);
            this.Name = "AboutAppMainView";
            this.Size = new System.Drawing.Size(948, 451);
            this._uiFirstRowTableLayoutPanel.ResumeLayout(false);
            this._uiFirstRowTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._motherlandPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel _uiFirstRowTableLayoutPanel;
        private System.Windows.Forms.LinkLabel _appInfoLinkLabel;
        private System.Windows.Forms.PictureBox _motherlandPictureBox;
        private System.Windows.Forms.Label _infoLabel;
    }
}
