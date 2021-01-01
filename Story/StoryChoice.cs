using System.Collections.ObjectModel;

namespace Packard.Story
{
    public class StoryChoice
    {
        public StoryChoice(Collection<StoryElement> choiceElements, StoryPage linkedPage)
        {
            ChoiceElements = choiceElements;
            LinkedPage = linkedPage;
        }

        public Collection<StoryElement> ChoiceElements { get; set; }

        public StoryPage LinkedPage { get; set; }
    }
}