using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);                        
        }


        //メソッドの概要：CSVファイルデータを、「,」で区切り配列に追加
        private static IEnumerable<Student> ReadScore(string filePath) {
            //
            List<Student> students = new List<Student>();
            string[] Lines = File.ReadAllLines(filePath);
            foreach(string line in Lines) {
                string[] items = line.Split(',');
                Student student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(student);
            }
            return students;
        }

        //メソッドの概要： 科目ごとの合計を集計
        public IDictionary<string, int> GetPerStudentScore() {
            IDictionary<string, int> dict = new Dictionary<string, int>();
            foreach(Student student in _score) {
                if (dict.ContainsKey(student.Subject)) {
                    dict[student.Subject] += student.Score;
                }else {
                    dict[student.Subject] = student.Score;
                }
            }
            return dict;
        }
    }
}
