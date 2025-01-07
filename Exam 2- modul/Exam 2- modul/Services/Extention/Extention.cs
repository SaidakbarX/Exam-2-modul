using Exam_2__modul.Services.DTOs;

namespace Exam_2__modul.Services.Extention;

public class Extention
{
    List<MusicDto> GetAllMusicByAuthorName(string authorName)
    {
      var musics = new List<MusicDto>();
        foreach (var music in musics )
        {
            if (music.AuthorName == authorName)
            {
                musics.Add(music);
            }
        }
        return musics;

    }
    MusicDto GetMostLikedMusic()
    {
        var list = new MusicDto();
        
       
        
      
    }

    MusicDto GetMusicByName(string name)
    {
        var musicName = new MusicDto(); 
        if (musicName.Name == name)
        {
            return musicName;
        }
        throw new Exception("bunday nomli musiqa yoq");
    }
    List<MusicDto> GetAllMusicAboveSize(double minSize)
    {
        var list = new MusicDto();
        var maxMusic = list.MB;
       
    }
    List<MusicDto> GetTopMostLikedMusic(int count);
    List<MusicDto> GetMusicByDescriptionKeyword(string keyword)
    {
        var musics = new List<MusicDto>();
        foreach (var music in musics)
        {
            if (music.Description == keyword)
            {
                musics.Add(music);
            }
        }
        return musics;

    }
    List<MusicDto> GetMusicWithLikeslnRange(int minLikes, int maxLikes);
    List<MusicDto> GetAllUniqueAuthors();
    double GetTotalMusicSizeByAuthor(string authorName)
    {
        var musics = new List<MusicDto>();
        foreach (var music in musics)
        {
            if (music.MB == authorName)
            {
                musics += musicMb;
            }
        }
        return musics;

    }
}
