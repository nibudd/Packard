using System;
using System.Collections.Generic;

namespace Packard.Story
{
    public class StoryElement
    {
        public StoryElement(List<string> snippets, Func<StoryVariables, int>? evaluator)
        {
            Snippets = snippets;
            
            if (evaluator == null)
            {
                Evaluator = (StoryVariables _) => 0;
            }
            else
            {
                Evaluator = evaluator;
            }
        }

        public List<string> Snippets { get; set; }

        public Func<StoryVariables, int> Evaluator { get; set; }

        public string Resolve(StoryVariables storyVariables)
        {
            int index = Evaluator(storyVariables);
            return Snippets[index];
        }
    }
}
