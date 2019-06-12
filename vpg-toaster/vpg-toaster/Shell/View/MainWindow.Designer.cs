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
            this._shellTabControl = new System.Windows.Forms.TabControl();
            this._shellMenuStrip = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // _shellTabControl
            // 
            this._shellTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._shellTabControl.Location = new System.Drawing.Point(0, 24);
            this._shellTabControl.Name = "_shellTabControl";
            this._shellTabControl.SelectedIndex = 0;
            this._shellTabControl.Size = new System.Drawing.Size(806, 489);
            this._shellTabControl.TabIndex = 7;
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
            this.Controls.Add(this._shellMenuStrip);
            this.MainMenuStrip = this._shellMenuStrip;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPG - Toaster";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl _shellTabControl;
        private System.Windows.Forms.MenuStrip _shellMenuStrip;
    }
}

