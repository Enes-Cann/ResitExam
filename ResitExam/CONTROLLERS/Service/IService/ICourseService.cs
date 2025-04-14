﻿using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service.IService
{
    public interface ICourseService
    {
        bool AddAnnouncementToCourseByCourseID(string announcement,int courseId);
        bool AddCourse(string name, string code, int instructorId, bool hasResitExam);
    }
}
