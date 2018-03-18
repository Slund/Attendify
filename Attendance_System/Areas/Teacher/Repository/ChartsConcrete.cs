﻿using Attendance_System.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Data;



namespace Attendance_System.Areas.Teacher.Repository
{
    public class ChartsConcrete : ICharts
    {
        public void TeacherChart(out string StudentList, out string LectureList)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var studentdata = db.Course.ToList();
                

                var CourseList = (from temp in db.Course
                                         select temp.CourseId).ToList();

                var StudentCount = (from temp in db.Enrollment
                                    group temp.ApplicationUserId by temp.CourseId into tempg
                                    select tempg.Count()).ToList();

                StudentList = string.Join(",", CourseList);

                LectureList = string.Join(",", StudentCount);
            }
        }


    }
}