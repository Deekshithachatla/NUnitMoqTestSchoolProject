using SchoolLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitMoqTests
{
    public class StudentTest
    {
      
            [Test]
            public void TestStudentName()
            {
                // Arrange
                Student student = new Student();
                student.Name = "sana";

                // Act
                string studentName = student.Name;

                // Assert
                Assert.AreEqual("sana", studentName);
            }

            [Test]
            public void TestStudentAddress()
            {
                // Arrange
                Student student = new Student();
                student.Address = "Gandhi St";

                // Act
                string studentAddress = student.Address;

                // Assert
                Assert.AreEqual("Gandhi St", studentAddress);
            }
        }
    }

