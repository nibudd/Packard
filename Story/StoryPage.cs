using System.Collections.ObjectModel;

namespace Packard.Story
{
    public class StoryPage
    {
        public StoryPage(Collection<StoryElement> titleElements, Collection<StoryElement> bodyElements, Collection<StoryChoice> storyChoices)
        {
            TitleElements = titleElements;
            BodyElements = bodyElements;
            StoryChoices = storyChoices;
        }

        public Collection<StoryElement> TitleElements { get; set; }

        public Collection<StoryElement> BodyElements { get; set; }

        public Collection<StoryChoice> StoryChoices { get; set; }
    }
}