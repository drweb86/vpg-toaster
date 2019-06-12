using System;
using System.Windows.Forms;
using vpg_toaster.Tools.AboutApp.Controller;

namespace vpg_toaster.Tools.AboutApp.Views
{
    public partial class AboutAppMainView : UserControl
    {
        public AboutAppMainView()
        {
            InitializeComponent();
        }

        private AboutAppController _controller;
        internal void Init(AboutAppController controller)
        {
            _controller = controller;
        }

        internal void TearDown()
        {

        }

        internal void ApplyChange(string subject, object[] body)
        {
        }
    }
}
