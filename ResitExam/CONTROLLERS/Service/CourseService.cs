﻿using ResitExam.AltSınıflar;
using ResitExam.CONTROLLERS.Service.IService;
using ResitExam.DATABASE.ClassRepos;
using ResitExam.DATABASE.InterfaceRepos;
using ResitExam.MODEL;

namespace ResitExam.CONTROLLERS.Service
{
    public class CourseService(ICourseRepository courseRepository, IInstructorRepository instructorRepository) : ICourseService
    {
        private readonly ICourseRepository _courseRepository = courseRepository;
        private readonly IInstructorRepository _instructorRepository = instructorRepository;

        /// <summary>
        /// Ders Ekleme işlemi
        /// </summary>
        /// <param name="name"></param>
        /// <param name="code"></param>
        /// <param name="instructorId"></param>
        /// <param name="hasResitExam"></param>
        /// <returns></returns>
        public bool AddCourse(string name, string code, int instructorId,Grade finalGrade, bool hasResitExam)
        {
            var instructor = _instructorRepository
                .GetInstructorById(instructorId);

            var course = new Course
            {
                Name = name,
                CourseCode = code,
                Instructor = instructor,
                FinalGrade = finalGrade,
                HasResitExamButton = hasResitExam
            };

            _courseRepository.Add(course);
            return true;
        }

        /// <summary>
        /// Derse duyuru ekleme işlemi.
        /// </summary>
        /// <param name="announcement"></param>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public bool AddAnnouncementToCourseByCourseID(string announcement, int courseId)
        {
            var course = _courseRepository
                .GetById(courseId);
            course.Announcements.Add(announcement);
            _courseRepository.Update(courseId);
            return true;
        }
      
        /// Kurs ID'sine göre öğrenci listesini döndürür.
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public List<Student> GetStudentListByCourseId(int courseId)
        {
            return _courseRepository
                .GetById(courseId).Students.ToList();
        }
    }    
}
