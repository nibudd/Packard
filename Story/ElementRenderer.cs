using System.Text;
using System.Collections.Generic;
using Packard.Story;

namespace Story
{
    public static class ElementRenderer
    {
        public static string RenderElements(ICollection<StoryElement> storyElements, StoryVariables storyVariables)
        {
            var renderedElements = new StringBuilder();
            foreach (var storyElement in storyElements)
            {
                renderedElements.Append(RenderElement(storyElement, storyVariables));
            }
            return renderedElements.ToString();
        }

        private static string RenderElement(StoryElement storyElement, StoryVariables storyVariables)
        {
            int index = storyElement.Evaluator(storyVariables);
            return storyElement.Snippets[index];
        }
    }
}