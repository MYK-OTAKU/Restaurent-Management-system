using MyMessageBox;
using Restaurant_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MyMessageBox
{
    public partial class MessageBoxNotify : Form
    {
        public MessageBoxNotify()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return this.titleLbl.Text;
            }

            set
            {
                this.titleLbl.Text = value;
            }
        }

        public string Message
        {
            get
            {
                return this.messageLbl.Text;
            }

            set
            {
                this.messageLbl.Text = value;
            }
        }

        public MessageBoxType Type
        {
            set
            {
                switch (value)
                {
                    case MessageBoxType.INFO:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.info;
                        break;
                    case MessageBoxType.WARNING:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.warning;
                        break;
                    case MessageBoxType.ERROR:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.error;
                        break;
                    case MessageBoxType.OK:
                        this.typePicBox.Image = global::Restaurant_Management_System.Properties.Resources.icons8_danger_96;
                        break;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void closeMe()
        {
            this.Close();
        }

        private void MessageBoxNotify_Load(object sender, EventArgs e)
        {

        }


        class NoteLocation
        {
            internal int X;
            internal int Y;

            internal Point initialLocation;
            internal bool mouseIsDown = false;

            public NoteLocation(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }


        static List<MessageBoxNotify> notifications = new List<MessageBoxNotify>();
        public AutoResetEvent timerResetEvent = null;
        public int timeout_ms = 2000;
        private short ID = 0;
        private Form inApp = null;
        NoteLocation noteLocation;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="insideMe"></param>
        private MessageBoxNotify(Form insideMe = null)
        {
            this.inApp = insideMe;

            InitializeComponent();

            foreach (var nt in notifications)
                if (nt.ID > ID)
                    ID = nt.ID;
            ID++;

            if (insideMe != null && !inAppNoteExists())
            {
                insideMe.LocationChanged += inApp_LocationChanged;
                insideMe.SizeChanged += inApp_LocationChanged;
            }
        }


        public static short Show(string message, string title, MessageBoxType type = MessageBoxType.INFO)
        {
            short updated_notify_id = 0;

            MessageBoxNotify notify = new MessageBoxNotify(null);

            notify.Title = title;
            notify.Message = message;
            notify.Type = type;

            notify.Show();

            if (notify.timeout_ms >= 500)
            {
                notify.timerResetEvent = new AutoResetEvent(false);

                BackgroundWorker timer = new BackgroundWorker();
                timer.DoWork += timer_DoWork;
                timer.RunWorkerCompleted += timer_RunWorkerCompleted;
                timer.RunWorkerAsync(notify);
            }

            notifications.Add(notify);
            updated_notify_id = notify.ID;

            return updated_notify_id;
        }

        /// <summary>
        /// timer_DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void timer_DoWork(object sender, DoWorkEventArgs e)
        {
            MessageBoxNotify not = (MessageBoxNotify)e.Argument;

            bool timedOut = false;

            while (!timedOut)
            {
                if (!not.timerResetEvent.WaitOne(not.timeout_ms))
                    timedOut = true;
            }

            e.Result = e.Argument;
        }

        /// <summary>
        /// timer_RunWorkerCompleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void timer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBoxNotify not = (MessageBoxNotify)e.Result;
            not.closeMe();
        }

        /// <summary>
        /// inAppNoteExists
        /// </summary>
        /// <returns></returns>
        private bool inAppNoteExists()
        {
            foreach (var notify in notifications)
            {
                if (notify.inApp != null)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// inApp_LocationChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void inApp_LocationChanged(object sender, EventArgs e)
        {
            foreach (var note in notifications)
            {
                if (note.inApp != null)
                {
                    NoteLocation ln = adjustLocation(note);
                    note.Left = ln.X;
                    note.Top = ln.Y;
                }
            }
        }

        /// <summary>
        /// Adjust Location
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        private NoteLocation adjustLocation(MessageBoxNotify note)
        {
            Rectangle notesArea;
            int nMaxRows = 0,
                nColumn = 0,
                nMaxColumns = 0,
                xShift = 25;

            bool add = false;

            if (inApp != null && inApp.WindowState == FormWindowState.Normal)
            {
                notesArea = new Rectangle(inApp.Location.X,
                                          inApp.Location.Y,
                                          inApp.Size.Width,
                                          inApp.Size.Height);
            }
            else
            {
                notesArea = new Rectangle(Screen.GetWorkingArea(note).Left,
                                          Screen.GetWorkingArea(note).Top,
                                          Screen.GetWorkingArea(note).Width,
                                          Screen.GetWorkingArea(note).Height);
            }

            nMaxRows = notesArea.Height / Height;
            nMaxColumns = notesArea.Width / xShift;

            noteLocation = new NoteLocation(notesArea.Width +
                                            notesArea.Left -
                                            Width,
                                            notesArea.Height +
                                            notesArea.Top -
                                            Height);

            while (nMaxRows > 0 && !add)
            {
                for (int nRow = 1; nRow <= nMaxRows; nRow++)
                {
                    noteLocation.Y = notesArea.Height +
                                        notesArea.Top -
                                        Height * nRow;

                    if (!isLocationAlreadyUsed(noteLocation, note))
                    {
                        add = true; break;
                    }

                    if (nRow == nMaxRows)
                    {
                        nColumn++;
                        nRow = 0;

                        noteLocation.X = notesArea.Width +
                                          notesArea.Left -
                                          Width - xShift * nColumn;
                    }

                    if (nColumn >= nMaxColumns)
                    {
                        add = true; break;
                    }
                }
            }

            noteLocation.initialLocation = new Point(noteLocation.X,
                                                     noteLocation.Y);
            return noteLocation;
        }

        /// <summary>
        /// isLocationAlreadyUsed
        /// </summary>
        /// <param name="location"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        private bool isLocationAlreadyUsed(NoteLocation location, MessageBoxNotify note)
        {
            foreach (var p in notifications)
                if (p.Left == location.X &&
                    p.Top == location.Y)
                {
                    if (note.inApp != null &&
                        p.ID == note.ID)
                        return false;
                    return true;
                }
            return false;
        }

        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void messageLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
