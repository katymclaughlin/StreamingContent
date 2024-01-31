namespace StreamingContent_Tests;

[TestClass]
public class StreamingContentTests
{
    [TestMethod]
    public void SetTitle_ShouldSetCorrectString()
    {
        StreamingContent content = new StreamingContent();
        content.Title = "Toy Story";
        string expected = "Toy Story";
        string actual = content.Title;
        Assert.AreEqual(expected,actual);
     }    

    [DataTestMethod]
    [DataRow(MaturityRating.G,true)]
    [DataRow(MaturityRating.TV_PG,true)]
    [DataRow(MaturityRating.R,false)]
    [DataRow(MaturityRating.TV_MA,false)]
    public void SetMaturityRating_ShouldGetCorrectFamilyFriendliness(MaturityRating Rating, bool expectedFamilyFriendly)
    {
        // Triple A Paradigm, a short hand for setting up tests
        
        // Arrange => Setting the stage
        StreamingContent content = new StreamingContent("Content Title","Some description", Rating, 4.2, GenreType.SciFi);
        
        // Act => We're executing any code that we need to run
        // If there were methods to call or properties to set, we'd do that here
        bool actual = content.IsFamilyFriendly;
        bool expected = expectedFamilyFriendly;
        
        // Assert => We're calling our asssertions finally
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
public void MovieTest() {
    StreamingContentRepository _repo = new StreamingContentRepository();
    
    Movie movie = new Movie();
    movie.Title = "Double Down";
    movie.Description = "A brilliant computer loner seizes Las Vegas and its terrorist attack, while fighting against his fits of clinical depression and obsession for romance and death.";
    movie.Director = "Neil Breen";
    movie.RunTime = 93;
    
    _repo.AddContentToDirectory(movie);
}
[TestMethod]
public void ShowTest() {
    StreamingContentRepository _repo = new StreamingContentRepository();
    
    Show show = new Show();
    show.Title = "";
    show.Description = "";
    
    // Add a few Episodes as well:
    
    Episode episode1 = new Episode();
    episode1.Name = "Top Banana";
    episode1.RunTime = 22;
    
    Episode episode2 = new Episode();
    episode2.Name = "Bringing Up Buster";
    episode2.RunTime = 22;
    
    Episode episode3 = new Episode();
    episode3.Name = "Key Decisions";
    episode3.RunTime = 22;
    
    show.Episodes.Add(episode1);
    show.Episodes.Add(episode2);
    show.Episodes.Add(episode3);
    
    _repo.AddContentToDirectory(show);
}
}
