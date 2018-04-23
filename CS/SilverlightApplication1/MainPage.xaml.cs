using System;
using System.Windows.Controls;
using DevExpress.Xpf.Scheduler;
using DevExpress.XtraScheduler;

namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();

            SchedulerStorage schedulerStorage = schedulerControl1.Storage;
            Appointment apt = schedulerStorage.CreateAppointment(AppointmentType.Normal);
            DateTime baseTime = DateTime.Today;

            apt.Start = baseTime.AddHours(1);
            apt.End = baseTime.AddHours(3.5);
            apt.Subject = "Appointment Subject";
            apt.Location = "Appointment Location";
            apt.Description = "Appointment description";

            schedulerStorage.AppointmentStorage.Add(apt);

            schedulerControl1.Start = apt.Start.Date;
            schedulerControl1.ActiveView.SelectAppointment(apt);

        }
    }
}