﻿using phase4procticeproj1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class TeacherTest
    {
        [Test]
        public void TestTeacherId()
        {
            var teacher = new Teacher();
            teacher.TeacherId = 101;
            Assert.AreEqual(101, teacher.TeacherId);
        }
        [Test]
        public void TestTeacherName()
        {
            var teacher = new Teacher();
            teacher.TeacherName = "Mr. Krishna";
            Assert.AreEqual("Mr. Krishna", teacher.TeacherName);
        }
    }
}
