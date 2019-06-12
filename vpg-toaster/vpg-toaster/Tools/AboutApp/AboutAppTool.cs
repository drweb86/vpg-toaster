using System.Windows.Forms;
using HDE.Platform.AspectOrientedFramework.WinForms;
using HDE.Platform.Collections;
using HDE.Platform.Logging;
using vpg_toaster.Tools.AboutApp.Controller;
using vpg_toaster.Tools.AboutApp.Views;

namespace vpg_toaster.Tools.AboutApp
{
    public class AboutAppTool : ToolBase
    {
        #region Fields

        private AboutAppController _controller;
        private TabPage _tabPage;
        private AboutAppMainView _mainView;

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
                _controller = new AboutAppController(Log);
                // _controller.LoadSettings(); !
                _tabPage = new TabPage(ToolName);
                _mainView = new AboutAppMainView { Dock = DockStyle.Fill };
                _mainView.Init(_controller);
                _tabPage.Controls.Add(_mainView);
                TabControl.TabPages.Add(_tabPage);
                TabControl.SelectTab(_tabPage);
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
