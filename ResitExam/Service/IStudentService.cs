using ResitExam.DtoObj;

namespace ResitExam.Service;

public interface IStudentService
{
    bool MakeUpExamRequest(MakeUpExamRequestDto dto);
}