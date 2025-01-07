using Exam_2__modul.Services.DTOs;

namespace Exam_2__modul.Services;

public interface IMusicServices
{
    void RemoveMsuic (Guid msuicId);
    void UpdateMusic (CreatMusicDto updateMusicDto);
    Guid AddMusic (CreatMusicDto creatMusic);
    List<MusicDto> GetAllMusicList ();
    MusicDto GetMusicById (Guid id);
   
}