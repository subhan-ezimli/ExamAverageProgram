public class Program
{
    static void Main(string[] args)
    {
        Student namiq = new Student();
        namiq.AddExamResult(60);
        namiq.AddExamResult(80);
        namiq.AddExamResult(70);

        namiq.ExamAverage();
    }

    public class Student
    {
        public string Name { get; set; }
        private int[] _examResults;

        public Student()
        {
            _examResults = new int[0];
        }

        public void AddExamResult(int examResult)
        {
            Array.Resize(ref _examResults, _examResults.Length + 1);
            _examResults[^1] = examResult;
        }


        public void ExamAverage()
        {
            int totalExamResult = 0;

            for (int i = 0; i < _examResults.Length; i++)
            {
                totalExamResult = totalExamResult + _examResults[i];
            }

            double averageExamResult = totalExamResult / _examResults.Length;
            Console.WriteLine(averageExamResult);
        }
    }
}


