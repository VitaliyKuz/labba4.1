using labba2sem4_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student s = new Student();
            string result = labba2sem4_1.Student.StudentRating(s.rating);
            string str = "����� ������� �����!";
            Assert.AreEqual(str, result);
            s.rating = 65;
            result = labba2sem4_1.Student.StudentRating(s.rating);
            string stroka = "����� �i���� ����� ����i���� ��������!";
            Assert.AreEqual(stroka, result);
        }
    }
}