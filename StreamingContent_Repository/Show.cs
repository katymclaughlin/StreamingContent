public class Show : StreamingContent {
    public double AverageRunTime { get; set; }
    public List<Episode> Episodes { get; set; } = new List<Episode>();
}

public class Episode {
    public string Name { get; set; }
    public double RunTime { get; set; }
}

