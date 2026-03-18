/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Mikal Johnson
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Represents a Mad Libs story template with prompts and story text.
- */

namespace MadLibs;

public class StoryTemplate
{
    public StoryTemplate(string title, string[] prompts, string templateText)
    {
        Title = title;
        Prompts = prompts;
        TemplateText = templateText;
    }

    public string Title { get; }

    public string[] Prompts { get; }

    public string TemplateText { get; }

    public string GenerateStory(string[] words)
    {
        if (words.Length != Prompts.Length)
        {
            throw new ArgumentException("The number of words must match the number of prompts.");
        }

        return FormatStory(words);
    }

    private string FormatStory(string[] words)
    {
        object[] formatArgs = new object[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            formatArgs[i] = words[i];
        }

        return string.Format(TemplateText, formatArgs);
    }
}
