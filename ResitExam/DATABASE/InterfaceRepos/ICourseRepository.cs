﻿using ResitExam.MODEL;

namespace ResitExam.DATABASE.InterfaceRepos
{
    public interface ICourseRepository
    {
        Course GetById(int Id);
        IEnumerable<Course> GetAll();
        void Add(int id);
        void Update(int id);
        void Delete(int id);
    }
}
