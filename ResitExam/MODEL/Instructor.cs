﻿using System.ComponentModel.DataAnnotations;

namespace ResitExam.MODEL;

public class Instructor
{
    
    public int Id               { get; set; }
    public string Name          { get; set; }
    public string Email         { get; set; }
    public List<Course> Courses { get; set; }
}