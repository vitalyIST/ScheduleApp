using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Timers;

namespace ScheduleApp
{
    public partial class MainForm : Form
    {
        private List<Event> events;
        private System.Timers.Timer eventTimer;

        public MainForm()
        {
            InitializeComponent();
            events = new List<Event>();
            InitializeWeekGrid();
            InitializeEventTimer();
        }

        private void InitializeWeekGrid()
        {
            var russianDaysOfWeek = new List<string> { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

            for (int i = 0; i < 7; i++)
            {
                weekGrid.Rows.Add(russianDaysOfWeek[i]);
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            AddEventForm addEventForm = new AddEventForm();
            if (addEventForm.ShowDialog() == DialogResult.OK)
            {
                Event newEvent = addEventForm.GetEvent();
                events.Add(newEvent);
                UpdateWeekGrid();
            }
        }

        private void UpdateWeekGrid()
        {
            foreach (var row in weekGrid.Rows.Cast<DataGridViewRow>())
            {
                row.Cells[1].Value = string.Empty;
            }

            foreach (var ev in events)
            {
                int rowIndex = (int)ev.Date.DayOfWeek;
                weekGrid.Rows[rowIndex].Cells[1].Value += $"{ev.Time.ToShortTimeString()} - {ev.Name}\n";
            }
        }

        private void InitializeEventTimer()
        {
            eventTimer = new System.Timers.Timer(60000); // Проверка каждую минуту
            eventTimer.Elapsed += CheckEvents;
            eventTimer.AutoReset = true;
            eventTimer.Enabled = true;
        }

        private void CheckEvents(object sender, ElapsedEventArgs e)
        {
            var now = DateTime.Now;
            foreach (var ev in events)
            {
                if (ev.Date.Date == now.Date && ev.Time.Hour == now.Hour && ev.Time.Minute == now.Minute)
                {
                    ShowNotification(ev);
                }
            }
        }

        private void ShowNotification(Event ev)
        {
            Invoke(new Action(() => {
                MessageBox.Show($"Событие: {ev.Name} начинается сейчас!", "Уведомление о событии", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }
    }

    public class Event
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Name { get; set; }
    }
}
