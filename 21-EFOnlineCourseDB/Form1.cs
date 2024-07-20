using _21_EFOnlineCourseDB.Context;
using _21_EFOnlineCourseDB.Entities;
using _21_EFOnlineCourseDB.Repositories;

namespace _21_EFOnlineCourseDB
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context= new ApplicationDbContext();
        }

        CourseRepository cRep;
        CourseManager cman;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                cRep = new CourseRepository(_context);
                cman = new CourseManager(cRep);

                Lesson l = new Lesson()
                {
                    Name = "Fluent Validation Giriþ",
                    CreatedDate = DateTime.Now
                };

                Course c = new Course()
                {
                    Name = ".Net Core MVC Kursu",
                    StartDate = new DateOnly(2024, 06, 09),
                    EndDate = new DateOnly(2024, 04, 09),
                    Instructor = new Instructor()
                    {
                        Name = "Ahmet",
                        Surname = "Aksakal"
                    }
                };

                c.Lessons.Add(l);

                cman.Create(c);
                MessageBox.Show("Kayýt Baþarýlý.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
