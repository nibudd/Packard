using System;
using System.Collections.Generic;

namespace Packard.Story
{
    public class StoryElement
    {
        public StoryElement(List<string> snippets, Func<StoryVariables, int> evaluator = null!)
        {
            Snippets = snippets;

            if (evaluator == null)
            {
                evaluator = (StoryVariables) => 0;
            }
            Evaluator = evaluator;
        }

        public List<string> Snippets { get; set; }

        public Func<StoryVariables, int> Evaluator { get; set; }
    }
}
