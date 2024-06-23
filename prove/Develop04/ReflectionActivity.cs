public class ReflectionActivity : Activity
{
    List<string> _prompts { get; set; } = new List<string> {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
        };
    List<string> _questions { get; set; } = new List<string> {
        "Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
        };
    public ReflectionActivity()
         : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", 50)
    {        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Thread.Sleep(3000);
        ShowCountDown();
        Console.Clear();
        DisplayPrompt();
        Thread.Sleep(3000);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_activityDuration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            Thread.Sleep(6000);
        }
        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int ranNum = random.Next(0, _prompts.Count());
        string randomPrompt = _prompts[ranNum];
        return randomPrompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int ranNum = random.Next(0, _questions.Count());
        string randomPrompt = _questions[ranNum];
        return randomPrompt;
    }
    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }
    public void DisplayQuestions()
    {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);
    }
}