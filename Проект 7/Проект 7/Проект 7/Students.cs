using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_7
{
    class Students
    {
        private Student[] stud;
        public Students(Student[] stud)
        {
            this.stud = stud;
        }
        public Student this[int k]
        {
            set { stud[k] = value; }
            get { return stud[k]; }
        }
        public Student this[string s]
        {
            get
            {
                foreach (Student st in stud)
                {
                    if (st.Name == s)
                        return st;
                }
                throw new Exception("Нет такого студента!");
            }
        }
    }
}
