using System;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;
using vpg_toaster.Tools.Toaster.Controller;
using vpg_toaster.Tools.Toaster.Utils;

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
                    FlashWindow.Flash(this.ParentForm);
                    SpeakIt(title);
                    MessageBox.Show(this.ParentForm, title, "Нотификация - vpg-toaster", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }, null);
        }

        private void SpeakIt(string title)
        {
            using (var synth = new SpeechSynthesizer())
            {
                synth.SetOutputToDefaultAudioDevice();

                // Create a prompt from a string.  
                var color = new Prompt(title);

                // Speak the contents of the prompt synchronously.  
                synth.Speak(color);
            }
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
