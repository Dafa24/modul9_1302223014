using Microsoft.VisualBasic;

namespace modul9_1302223014
{
    public class Mahasiswa
    {
        public String Name;
        public String NIM;
        public List<String> Course;
        public int Year;

        public Mahasiswa(string name, string NIM, List<string> course, int year)
        {
            Name = name;
            NIM = NIM;
            Course = course;
            Year = year;
        }
    }
}
