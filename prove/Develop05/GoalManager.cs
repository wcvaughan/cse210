using System.Text.Json;
public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    public int _score;
    public GoalManager(int score)
    {
        _goals = new List<Goal>();
        _score = score;
    }
    public void Start()
    {

    }
    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {
        
    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the name for your save?");
        string userSaveFile = Console.ReadLine();
        string jsonString = JsonSerializer.Serialize();
        File.WriteAllText(userSaveFile, jsonString);
        Console.WriteLine($"File saved as {userSaveFile}.");

    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file you want to load?");
        string userLoadFile = Console.ReadLine(); 
        if (File.Exists(userLoadFile))
        {
            string jsonString = File.ReadAllText(userLoadFile);
            var readVariable = JsonSerializer.Deserialize</*DATA MODEL*/>(jsonString);
        }
    }
}