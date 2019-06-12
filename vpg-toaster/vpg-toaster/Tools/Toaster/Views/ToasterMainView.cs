using System;
using System.Windows.Forms;
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
        internal void Init(ToasterController controller)
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
