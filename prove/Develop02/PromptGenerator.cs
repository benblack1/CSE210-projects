using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>() {"What was best about today?","What could've been better about today?",
    "How did you see the Lord's hand in your life today?","What made you smile today?","Who did you serve today?","Who served you today?"
    ,"What was one new thing you learned today?"};

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    

}
