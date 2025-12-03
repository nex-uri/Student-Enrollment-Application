namespace Student_Enrollment_Application
{
    internal class QueueADT<T>
    {
        private T[] array;
        private int front, rear, count;

        public QueueADT()
        {
            array = new T[6];
            front = 0;
            rear = -1;
            count = 0;
        }

        private void increaseSize()
        {
            T[] newArray = new T[array.Length + 6];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[(front + i) % array.Length];
            }

            array = newArray;
            front = 0;
            rear = count - 1;
        }

        public void Enqueue(T item)
        {
            if (count >= array.Length)
            {
                increaseSize();
            }

            rear = (rear + 1) % array.Length;
            array[rear] = item;
            count++;
        }

        public T Dequeue()
        {
            if (count <= 0)
            {
                throw new Exception("Queue is Empty!");
            }
            else
            {
                T item = array[front];
                front = (front + 1) % array.Length;
                count--;
                return item;
            }
        }

        public T Peek()
        {
            if (count <= 0)
            {
                throw new Exception("Queue is Empty!");
            }
            else
            {
                T item = array[front];
                return item;
            }
        }

        public T[] GetQueueArray()
        {
            T[] tempArray = new T[count];

            for (int i = 0; i < count; i++)
            {
                tempArray[i] = array[(front + i) % array.Length];
            }

            return tempArray;
        }
    }
}
