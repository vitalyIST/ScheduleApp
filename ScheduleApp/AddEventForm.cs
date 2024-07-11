using System;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class AddEventForm : Form
    {
        private Event newEvent;

        public AddEventForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            newEvent = new Event
            {
                Date = dateTimePicker.Value.Date,
                Time = dateTimePicker.Value,
                Name = txtEventName.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Event GetEvent()
        {
            return newEvent;
        }
    }
}
