using System;
using System.Collections.Generic;

namespace Packard.Story
{
    public class StoryElement
    {
        public StoryElement(List<string> snippets) : this(snippets, new ElementEvaluator((StoryVariables _) => 0))
        {
        }

        public StoryElement(List<string> snippets, ElementEvaluator evaluator)
        {
            Snippets = snippets;
            Evaluator = evaluator;
        }

        public List<string> Snippets { get; set; }

        public ElementEvaluator Evaluator { get; set; }

        public string Resolve(StoryVariables storyVariables)
        {
            int index = Evaluator.Evaluate(storyVariables);
            return Snippets[index];
        }
    }
}
