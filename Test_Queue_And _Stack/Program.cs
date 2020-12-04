using System;
using System.Collections;
using System.Collections.Generic;

namespace Test_Queue_And__Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            #region test queue in C#
            ///Phương thức enqueue -> đưa phần từ vào cuối danh sách
            ///Count -> thuộc tính lấy tổng số phần tử của hàng đợi
            ///Dequeue -> đọc và loại ngay phần tử ở đầu hàng đợi (lỗi sẽ xảy ra nếu không có phần tử nào trong hàng đợi)
            ///Peek -> đọc phần tử đầu hàng đợi
            Console.WriteLine("Test queue C#, principle FIFO (First In First Out)");
            Queue<string> person_queue = new Queue<string>();
            person_queue.Enqueue("person 1");
            person_queue.Enqueue("person 2");
            person_queue.Enqueue("person 3");
            person_queue.Enqueue("person 4");
            person_queue.Enqueue("person 5");

            //Kiểm từng người và xóa khỏi danh sách cho đến khi kết thúc
            while (person_queue.Count > 0)
            {
                var x = person_queue.Dequeue();
                Console.WriteLine($"Checked person:{x}, Amount of rest of amount in queue: {person_queue.Count}");
            }
            #endregion

            #region test stack in C#
            ///Count -> phương thức lấy số lượng phần tử trong hàng
            ///Push -> phương thức đẩy thêm 1 phần tử vào đỉnh stack
            ///Pop -> đọc -> xóa phần tử đỉnh của stack
            ///Peek -> đọc phần tử đỉnh của stack
            ///Contains -> kiểm tra phần tử có tồn tại trong stack
            ///
            Console.WriteLine("Test stack C#, principle LIFO (Last In Fisrt Out)");
            Stack<string> person_stack = new Stack<string>();
            person_stack.Push("person 1s");
            person_stack.Push("person 2s");
            person_stack.Push("person 3s");
            person_stack.Push("person 4s");
            person_stack.Push("person 5s");
            //Check person and delete with principle LIFO
            while (person_stack.Count > 0)
            {
                var x = person_stack.Pop();
                Console.WriteLine($"Checked person s: {x}, Amount of rest of people in stack: {person_stack.Count}");
            }
            #endregion
        }
    }
}
