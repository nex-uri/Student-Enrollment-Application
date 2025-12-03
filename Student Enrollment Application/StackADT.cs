namespace Student_Enrollment_Application
{
    internal class StackADT
    {
        //ADT STACK FUNCTION

        //========================================================
        private object[] arr;
        public int top;

        public StackADT()
        {
            arr = Array.Empty<object>();
            top = -1;
        }
        public void IncreaseSize()
        {
            object[] new_size_arr = new object[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                new_size_arr[i] = arr[i];
            }
            arr = new_size_arr;
        }
        public void DecreaseSize()
        {
            object[] new_size_arr = new object[arr.Length - 1];
            for (int i = 0; i < new_size_arr.Length; i++)
            {
                new_size_arr[i] = arr[i];
            }
            arr = new_size_arr;
        }
        public object AddCourse(object course)
        {
            if (top < arr.Length)
            {
                top++;

                IncreaseSize();

                arr[top] = course;

                return course;
            }
            else
            {
                throw new Exception($">>System Error! The array variable named '{nameof(arr)}' is out of bounds.");
            }
        }
        public object DeleteCourse()
        {
            if (-1 < top && top < arr.Length)
            {
                object delete_course = arr[top];
                top--;

                DecreaseSize();

                return delete_course;
            }
            else
            {
                throw new Exception($">>System Error! The array variable named '{nameof(arr)}' is out of bounds.");
            }
        }
        public object[] GetCourses()
        {
            object[] arr_display = new object[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr_display[i] = arr[i];
            }
            return arr_display;
        }
        //========================================================
    }
}
