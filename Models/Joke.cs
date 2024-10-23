namespace LearningJokesWebApp.Models;

public class Joke
{ 
    public int Id { get; set; }
    public string? JokeQuestions { get; set; }
    public string? JokeAnswers { get; set; }
    //public string CreatedBy { get; set; } // Store username
    //public string CreatedById { get; set; } // Store user ID


    public Joke()
    {

    }
}


