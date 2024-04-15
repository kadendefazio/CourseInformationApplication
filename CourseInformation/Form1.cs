namespace CourseInformation
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> courseRoom = new Dictionary<string, string>()
        {
            { "CS101", "3004" },  { "CS102", "4501" },  { "CS103", "6755" },
             { "NT110", "1244" },  { "CM241", "1411" }
        };
        Dictionary<string, string> courseInstructor = new Dictionary<string, string>()
        {
            { "CS101", "Haynes" },  { "CS102", "Alvarado" },  { "CS103", "Rich" },
             { "NT110", "Burke" },  { "CM241", "Lee" }
        };
        Dictionary<string, string> courseTimes = new Dictionary<string, string>()
        {
            { "CS101", "8:00 A.M." },  { "CS102", "9:00 A.M." },  { "CS103", "10:00 A.M." },
             { "NT110", "11:00 A.M." },  { "CM241", "1:00 P.M." }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getCourseInfo_Click(object sender, EventArgs e)
        {
            string courseNumber = courseNumberListBox.SelectedItem.ToString();

            // Display room number
            if (courseRoom.ContainsKey(courseNumber))
            {
                roomNumberLabel.Text = courseRoom[courseNumber];
            }

            // Display instructor
            if (courseInstructor.ContainsKey(courseNumber))
            {
                instructorLabel.Text = courseInstructor[courseNumber];
            }

            // Display meeting time
            if (courseTimes.ContainsKey(courseNumber))
            {
                meetingTimeLabel.Text = courseTimes[courseNumber];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //populates the course number list box
            foreach ( var element in courseRoom)
            {
                courseNumberListBox.Items.Add(element.Key);
            }
        }

    }
}
