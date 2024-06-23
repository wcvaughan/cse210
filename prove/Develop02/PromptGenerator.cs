public class PromptGenerator
{

    private List<string> _prompts = new List<string>
    {
        "What was my happy space today?",
        "What work/chore/checklist item did I accomplish today that helped me feel better?",
        "Was there something I wished I had done today that I didn't do?",
        "Was there a time today where I felt gratitude for someone or something?",
        "How did I start my day today?"
    };

    public string GetRandomPrompt()
    {

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}