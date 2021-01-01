using System.Collections.ObjectModel;

namespace Packard.Story
{
    public class StoryChoice
    {
        public StoryChoice(Collection<StoryElement> choiceElements, ElementEvaluator<bool> choiceEvaluator, StoryPage linkedPage)
        {
            ChoiceElements = choiceElements;
            ChoiceEvaluator = choiceEvaluator;
            LinkedPage = linkedPage;
        }

        public Collection<StoryElement> ChoiceElements { get; set; }

        public ElementEvaluator<bool> ChoiceEvaluator { get; set; }

        public StoryPage LinkedPage { get; set; }
    }
}