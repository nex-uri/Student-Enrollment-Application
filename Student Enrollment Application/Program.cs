namespace Student_Enrollment_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A CONCEPT OF STACK FUNCTION OF ADDING AND DELETING COURSES

            //==========================================================
            StackADT stack = new StackADT();

            stack.AddCourse("consec3");
            stack.AddCourse("consec2");
            stack.AddCourse("dstalgo");

            stack.DeleteCourse();

            foreach (var course in stack.GetCourses())
            {
                Console.WriteLine(course);
            }
            //==========================================================
        }
    }
}
