using Exam_2__modul.DataAccess.Entity;

namespace Exam_2__modul.Repository;

public interface IMusicRepository
{
    void DeleteMusic (Guid id);
    void UpdateMusic (Music music);
    List<Music> GetAllMusic ();
    Music GetMusicById (Guid id);
    Guid  WriteMusic (Music music);
}