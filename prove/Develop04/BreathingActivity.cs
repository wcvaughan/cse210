public class BreathingActivity : Activity
{
    public BreathingActivity()
     : base("Breathing", "A breathing exercise. Follow the animation and prompts for breathing in and out.", 50)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();

        Thread.Sleep(3000);

        ShowCountDown();
        
        string[] frames = {
            "Breathe In *", 
            "Breathe In **",
            "Breathe In ***",
            "Breathe In ****",
            "Breathe In *****",
            "Breathe In ******",
            "Breathe In *******",
            "Breathe In ********",
            "Breathe In *********",
            "Breathe In **********",
            "Breathe In ***********",
            "Breathe Out ************",
            "Breathe Out ***********",
            "Breathe Out **********",
            "Breathe Out *********",
            "Breathe Out ********",
            "Breathe Out *******",
            "Breathe Out ******",
            "Breathe Out *****",
            "Breathe Out ****",
            "Breathe Out ***",
            "Breathe Out **",
            "Breathe Out *"
        };
        BreathInAnimation(frames);
        DisplayEndingMessage();        
    }
    public void BreathInAnimation(string[] frames)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(ActivityDuration);
        while (DateTime.Now < endTime)
        {
            foreach (string frame in frames)
            {
                Console.Clear();
                Console.WriteLine(frame);
                Thread.Sleep(500);
            }
        }
    }
    }