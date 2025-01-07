using Exam_2__modul.DataAccess.Entity;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Exam_2__modul.Repository;

public class MusicRepository : IMusicRepository
{
    private readonly string _path;
    private List<Music> _music;
    public MusicRepository()
    {
        _path = "../../../DataAccess/Data/student.json";
        if(!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }
        _music = GetAllMusic();
    }

    public void DeleteMusic(Guid id)
    { 
        var deleteStudent = GetMusicById(id);
        _music.Remove(deleteStudent);
        SaveData();
    }

    public List<Music> GetAllMusic()
    {
        var musicJson = File.ReadAllText(_path);
        var music = JsonSerializer.Deserialize<List<Music>>(musicJson);
        return music;
    }

    public Music GetMusicById(Guid id)
    {
       foreach (var music in _music)
        {
            if (music.Id == id)
            {
                return music;
            }
        }
        throw new Exception("Erorr");
    }

    public void UpdateMusic(Music music)
    {
        var updateMusic = GetMusicById(music.Id);
        var index = _music.IndexOf(updateMusic);
        _music[index] = music;
        SaveData();
    }

    public Guid WriteMusic(Music music)
    {
        _music.Add(music);
        SaveData() ;
        return music.Id;
    }
    private void SaveData()
    {
        var musicJson = JsonSerializer.Serialize(_music);
        File.WriteAllText(musicJson, _path);
       


    }
}
