using System;
using System.Collections.ObjectModel;

namespace Packard.Story
{
    public class StoryChoice
    {
        public StoryChoice(Collection<StoryElement> choiceElements, Func<StoryVariables, bool> choiceEvaluator, StoryPage linkedPage)
        {
            ChoiceElements = choiceElements;
            ChoiceEvaluator = choiceEvaluator;
            LinkedPage = linkedPage;
        }

        public Collection<StoryElement> ChoiceElements { get; set; }

        public Func<StoryVariables, bool> ChoiceEvaluator { get; set; }

        public StoryPage LinkedPage { get; set; }
    }
}