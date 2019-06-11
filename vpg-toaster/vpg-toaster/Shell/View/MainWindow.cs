using HDE.Platform.AspectOrientedFramework;
using HDE.Platform.AspectOrientedFramework.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vpg_toaster.Controller;
using vpg_toaster.Shell.Controller;

namespace vpg_toaster
{
    public partial class MainWindow : Form, IMainFormView, IBaseView<ShellController>
    {
        //private readonly AppController _appController = new AppController();

        public MainWindow()
        {
            InitializeComponent();
        }

        public TabControl TabControl => _shellTabControl;

        public MenuStrip MainMenu => _shellMenuStrip;

        public bool Process()
        {
            ShowDialog();
            return true;
        }

        private ShellController _context;
        public void SetContext(ShellController context)
        {
            _context = context;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            //_appController.LoadNotifications();
            //_appController.LoadUserEnabledNotifications();

            // TODO: get checked model.
//            _notificationsCheckedListBox.ite

        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _context.TearDown();
        }
    }
}
