using System.Windows.Forms;
using HDE.Platform.AspectOrientedFramework.WinForms;
using HDE.Platform.Collections;
using HDE.Platform.Logging;
using vpg_toaster.Tools.Toaster.Controller;
using vpg_toaster.Tools.Toaster.Views;

namespace vpg_toaster.Tools.Toaster
{
    public class ToasterTool : ToolBase
    {
        #region Fields

        private ToasterController _controller;
        private TabPage _tabPage;
        private ToasterMainView _mainView;

        #endregion

        public override void ApplyChange(string subject, params object[] body)
        {
            if (_mainView != null)
            {
                _mainView.ApplyChange(subject, body);
            }
        }

        public override void Activate()
        {
            base.Activate();

            if (_controller == null)
            {
                _mainView = new ToasterMainView { Dock = DockStyle.Fill };
                _tabPage = new TabPage(ToolName);
                _tabPage.Controls.Add(_mainView);
                TabControl.TabPages.Add(_tabPage);
                TabControl.SelectTab(_tabPage);

                _controller = new ToasterController(Log, this);
                _mainView.Init(_controller);

                _controller.LoadSettings();
            }
            else // Select tab page.
            {
                TabControl.SelectTab(_tabPage);
            }
        }

        public override void Dispose()
        {
            if (_controller != null)
            {
                _mainView.TearDown();
                _mainView = null;
                _controller.TearDown();
                _controller.Dispose();
                _controller = null;
                TabControl.TabPages.Remove(_tabPage);
                _tabPage = null;
                base.Dispose();
            }
        }

        protected override void OnMessageProcess(string subject, params object[] body)
        {
            switch (subject)
            {
                case "Activate":
                    if (subject == "Activate" && TabControl.SelectedTab != _tabPage)
                    {
                        Activate();
                    }
                    break;
                default:
                    _controller.ProcessMessage(subject, body);
                    break;
            }
        }
    }
}
