using System;

namespace Packard.Story
{
    public class ElementEvaluator
    {
        public ElementEvaluator(Func<StoryVariables, int> evaluator)
        {
            Evaluator = evaluator;
        }

        public Func<StoryVariables, int> Evaluator { get; set; }

        public int Evaluate(StoryVariables storyVariables)
        {
            return Evaluator(storyVariables);
        }
    }
}