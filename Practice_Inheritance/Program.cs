using Practice_Inheritance;

Teacher teacher = new Teacher()
{
    FirstName = "Till",
    LastName = "Lindemann",
    TeacherSalary = 4444
};

Student student = new Student()
{
    FirstName = "Austin",
    LastName = "Post",
    StudentNumber = "1E2ST48"
};

teacher.Introduce();
student.Introduce();
