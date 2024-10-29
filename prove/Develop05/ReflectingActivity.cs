public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on positive experiences.", 50)
    {
        _prompts = new List<string> { 
            "Think of a time you felt accomplished.", 
            "Think of a memorable moment with friends or family." };
            
        _questions = new List<string> { 
            "Why was this moment special?", 
            "How did it make you feel?", 
            "What did you learn from it?" };
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Reflect on the following:");
        Console.WriteLine(GetRandomPrompt());
    }

    private void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        DisplayPrompt();
        ShowSpinner(3);

        DisplayQuestions();

        DisplayEndingMessage();
    }
}