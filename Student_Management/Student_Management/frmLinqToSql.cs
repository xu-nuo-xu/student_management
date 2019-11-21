using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace Student_Management
{
    public partial class frmLinqToSql : MetroForm
    {
        public frmLinqToSql()
        {
            InitializeComponent();
        }
        
        private void frmLinqToSql_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void txtStuName_Click(object sender, EventArgs e)
        {

        }
        private void getStudents1()
        {
            metroTextBox1.ResetText();
            var db = new dc_student_managementDataContext();
            
                var results = from c in db.Student
                              where c.StuName.Contains(metroTextBox2.Text)
                              select c;
        
            if (results.Count() == 0)
                metroTextBox1.Text = "查询结果为空，请重新输入姓名";

            foreach (var r in results)
            {
                metroTextBox1.Text = "姓名：" + r.StuName + "  学号：" + r.ClassNo + "  班级" + r.ClassNo + "  性别：" + r.Sex + "  生日" + r.BirthDay + "\r\n";
            }
        }
        private void getStudents2()
        {
            metroTextBox1.ResetText();
            var db = new dc_student_managementDataContext();

            var results = from c in db.Student
                          where c.StuNo.Equals(metroTextBox2.Text)
                          select c;

            if (results.Count() == 0)
                metroTextBox1.Text = "查询结果为空，请重新输入学号";
            
            foreach (var r in results)
            {
                metroTextBox1.Text = "姓名：" + r.StuName + "  学号：" + r.ClassNo + "  班级" + r.ClassNo + "  性别：" + r.Sex + "  生日" + r.BirthDay + "\r\n";
            }
        }
        private void getStudents3()
        {
            metroTextBox1.ResetText();
            var db = new dc_student_managementDataContext();

            var results = from c in db.StuCou
                          join s in db.Course
                          on c.CouNo equals s.CouNo
                          where c.StuNo.Equals(metroTextBox2.Text)
                          select new { c.CouNo, s.CouName, c.Grade };

            if (results.Count() == 0)
                metroTextBox1.Text = "查询结果为空，请重新输入学号";

            /*if (frmLogin.ID != metroTextBox2.Text)
            {
                metroTextBox1.Text += frmLogin.ID;
                metroTextBox1.Text += "\r\n";
                metroTextBox1.Text += metroTextBox2.Text;
                metroTextBox1.Text += "你不能查询其他学生的成绩，请输入你自己的学号";
            }*/     //想实现一个学生只能查询自己的成绩


            float? avg=0;
            int count = 0;
            foreach (var r in results)
            {
                count++;
                avg += r.Grade;
                metroTextBox1.Text += "课程号："  + r.CouNo +"  课程名：" + r.CouName + "  成绩：" + r.Grade +"\r\n";
            }
            avg /= count;
            metroTextBox1.Text += "平均成绩：" + avg.ToString();


        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(metroComboBox1.Text=="按姓名查询学生学籍信息")
            {
                getStudents1();
            }
            if (metroComboBox1.Text == "按学号查询学生学籍信息")
            {
                getStudents2();
            }
            if (metroComboBox1.Text == "按学号查询学生成绩信息")
            {
                getStudents3();
            }

        }
    }
}
