﻿using System;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;
using vpg_toaster.Tools.Toaster.Controller;

namespace vpg_toaster.Tools.Toaster.Views
{
    public partial class ToasterMainView : UserControl
    {
        public ToasterMainView()
        {
            InitializeComponent();
        }

        private ToasterController _controller;
        private SynchronizationContext _context;
        internal void Init(ToasterController controller)
        {
            _controller = controller;
            _context = SynchronizationContext.Current;
        }

        internal void TearDown()
        {

        }

        internal void ApplyChange(string subject, object[] body)
        {
            switch (subject)
            {
                case ToasterAspects.Loaded:
                    UpdateItems();
                    break;
                case ToasterAspects.ShowNotification:
                    ShowNotification((string)body[0]);
                    break;
            }
        }

        private void ShowNotification(string title)
        {
            _context.Post(o =>
                {
                    MessageBox.Show(title, "Нотификация - vpg-toaster", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }, null);
        }

        private void UpdateItems()
        {
            _notificationsCheckedListBox.BeginUpdate();

            _notificationsCheckedListBox.Items.Clear();
            _notificationsCheckedListBox.ItemCheck -= OnItemCheck;
            foreach (var toaster in _controller.Model.Toasters)
            {
                _notificationsCheckedListBox.Items.Add(toaster.Name, (toaster.EnabledByUser ?? toaster.EnabledByDefault) == true);
            }
            _notificationsCheckedListBox.ItemCheck += OnItemCheck;
            _notificationsCheckedListBox.EndUpdate();
        }

        private void OnItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Indeterminate)
            {
                return;
            }

            _controller.ToastEnabled((string)_notificationsCheckedListBox.Items[e.Index], e.NewValue == CheckState.Checked);
        }
    }
}
