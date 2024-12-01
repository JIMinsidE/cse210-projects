using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the best part of your day?",
        "Write about an experience where you felt the spirit with you today:",
        "Who was the most interesting person you interacted with today?",
        "Write about something that happened for which you are grateful today:",
        "If you had one thing you could do over today, what would it be?",
        "What was the strongest emotion you felt today?",
        "Write about an act of service you either witnessed or performed today:>",
        "Write about something you learned today:",
        "Write about a tender mercy you noticed today:",
        "Write about a positive interaction you had with someone else today:",
        "Write about something you noticed that reminded you of Jesus Christ today:",
        "Write about something you learned about someone in your life today:",
        "Write about an experience you had that allowed you to teach someone else today:"
    };

    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
