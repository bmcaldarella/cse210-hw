public class MindfulnessActivity
{
    protected string _activityName;
    protected string _description;

    public MindfulnessActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public virtual void StartActivity(int duration)
    {
        Console.WriteLine($"Starting {_activityName} activity:");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); 
    }

    public virtual void EndActivity()
    {
        Console.WriteLine($"Good job! You have completed the {_activityName} activity.");
        Thread.Sleep(2000); 
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\b/"); Thread.Sleep(250);
            Console.Write("\b-"); Thread.Sleep(250);
            Console.Write("\b\\"); Thread.Sleep(250);
            Console.Write("\b|"); Thread.Sleep(250);
        }
        Console.WriteLine();
    }
}

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {
    }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);
        Console.WriteLine("Focus on your breathing:");
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(1);
            Console.WriteLine("Breathe out...");
            ShowSpinner(1);
        }
        base.EndActivity();
    }
}

public class ReflectionActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
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

    public ReflectionActivity(string activityName, string description) : base(activityName, description)
    {
    }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);
        Console.WriteLine("Reflect on the following prompt:");
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Length);
        Console.WriteLine(_prompts[index]);
        Thread.Sleep(2000);

        Console.WriteLine("Now, consider the following questions:");
        for (int i = 0; i < duration; i++)
        {
            index = rnd.Next(_questions.Length);
            Console.WriteLine(_questions[index]);
            ShowSpinner(1);
        }
        base.EndActivity();
    }
}

public class ListingActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string activityName, string description) : base(activityName, description)
    {
    }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);
        Console.WriteLine("Reflect on the following prompt:");
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Length);
        Console.WriteLine(_prompts[index]);
        Thread.Sleep(2000);

        Console.WriteLine("Now, start listing items:");
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine($"Item {i + 1}");
            ShowSpinner(1);
        }
        Console.WriteLine($"Total items listed: {duration}");
        base.EndActivity();
    }
}