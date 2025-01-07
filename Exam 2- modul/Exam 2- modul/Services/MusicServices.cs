using Exam_2__modul.DataAccess.Entity;
using Exam_2__modul.Repository;
using Exam_2__modul.Services.DTOs;

namespace Exam_2__modul.Services;

public class MusicServices : IMusicServices
{
    private IMusicRepository _musicRepository;
    public MusicServices()
    {
        _musicRepository = new MusicRepository();
    }
    public Guid AddMusic(CreatMusicDto creatMusic)
    {
        var musicCreate = ConvertToEntity(creatMusic);
        var music = _musicRepository.WriteMusic(musicCreate);
        return music;

    }

    public List<MusicDto> GetAllMusicList()
    {
        var music = _musicRepository.GetAllMusic();
        var list = new List<MusicDto>();
        foreach(var musics in music )
        {
            list.Add(GetMusicById(musics.Id));
        }
        return list;
        
       
    }

    public MusicDto GetMusicById(Guid id)
    {
     var music = GetMusicById(id);
        return music;
      
    }

    public void RemoveMsuic(Guid msuicId)
    {
        _musicRepository.DeleteMusic(msuicId);
    }

    public void UpdateMusic(CreatMusicDto updateMusicDto)
    {
        var music = ConvertToEntity(updateMusicDto);
         _musicRepository.UpdateMusic(music);
      
    }
    private Music ConvertToEntity(CreatMusicDto entity)
    {
        return new Music
        {
            AuthorName = entity.AuthorName,
            Description = entity.Description,
            Id = Guid.NewGuid(),
            Name = entity.Name,
            QuentityLikes = entity.QuentityLikes,
            MB = entity.MB,
        };
    }
    private Music ConvertToEntity(MusicDto entitiy)
    {
        return new Music
        {
            MB = entitiy.MB,
            AuthorName = entitiy.AuthorName,
            QuentityLikes = entitiy.QuentityLikes,
            Name = entitiy.Name,
            Description = entitiy.Description,
            Id = entitiy.Id,
        };
    }
}
