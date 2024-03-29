﻿using HDE.Platform.AspectOrientedFramework.WinForms;
using System;
using System.Windows.Forms;
using vpg_toaster.Shell.Controller;

namespace vpg_toaster
{
    public partial class MainWindow : Form, IMainFormView
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

        private void OnLoad(object sender, EventArgs e)
        {
            //_appController.LoadNotifications();
            //_appController.LoadUserEnabledNotifications();

            // TODO: get checked model.
//            _notificationsCheckedListBox.ite

        }

        public void SetController(object controller)
        {
            _context = (ShellController)controller;
        }
    }
}
