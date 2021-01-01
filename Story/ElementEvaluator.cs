using System;

namespace Packard.Story
{
    public class ElementEvaluator<T>
    {
        public ElementEvaluator(Func<StoryVariables, T> evaluator)
        {
            Evaluator = evaluator;
        }

        public Func<StoryVariables, T> Evaluator { get; set; }

        public T Evaluate(StoryVariables storyVariables)
        {
            return Evaluator(storyVariables);
        }
    }
}