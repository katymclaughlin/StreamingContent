
public enum GenreType
{
    Horror = 1,
    RomCom,
    SciFi,
    Documentary,
    Bromance,
    Drama,
    Action,
    Fantasy
}
public enum MaturityRating
{
    G,
    PG,
    PG_13,
    R,
    NC_17,
    TV_Y,
    TV_G,
    TV_PG,
    TV_14,
    TV_MA
}
public class StreamingContent
{
    public StreamingContent() {}
    
    public StreamingContent(string title, string description, MaturityRating maturityRating, double stars, GenreType genre)
    {
        Title = title;
        Description = description;
        MaturityRating = maturityRating;
        StarRating = stars;
        TypeOfGenre = genre;
    
    } 
    public string Title {get; set;}
    public string Description {get; set;}
    public double StarRating {get; set;}
    public MaturityRating MaturityRating {get; set;}
    
    public GenreType TypeOfGenre {get; set;}

public bool IsFamilyFriendly
    {
        get
        {
            switch(MaturityRating)
            {
                case MaturityRating.G:
                case MaturityRating.PG:
                case MaturityRating.TV_Y:
                case MaturityRating.TV_G:
                case MaturityRating.TV_PG:
                    return true;
                default:
                    return false;
            }
        }
    }
}