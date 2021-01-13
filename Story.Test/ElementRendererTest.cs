using System.Collections.Generic;
using System.Collections.ObjectModel;
using Packard.Story;
using Xunit;

namespace Story.Test
{
    public class ElementRendererTest
    {
        [Fact]
        public void RenderElements_OneElementOneSnippetDefaultEvaluator_RendersText()
        {
            var storyElements = new Collection<StoryElement>();
            storyElements.Add(new StoryElement(new List<string>() {"test"}));

            var storyVariables = new StoryVariables();

            var sut = ElementRenderer.RenderElements(storyElements, storyVariables);

            Assert.Equal("test", sut);
        }

        [Fact]
        public void RenderElements_OneElementMultipleSnippetsDefaultEvaluator_RendersText()
        {
            var storyElements = new Collection<StoryElement>();
            storyElements.Add(new StoryElement(new List<string>() {"test", "wrong", "answer"}));

            var storyVariables = new StoryVariables();

            var sut = ElementRenderer.RenderElements(storyElements, storyVariables);

            Assert.Equal("test", sut);
        }

        [Fact]
        public void RenderElements_OneElementMultipleSnippetsEvaluator2_RendersText()
        {
            var storyElements = new Collection<StoryElement>();
            storyElements.Add(new StoryElement(new List<string>() {"nope", "nuh-uh", "test", "wrong", "answer"}, (StoryVariables) => 2));

            var storyVariables = new StoryVariables();

            var sut = ElementRenderer.RenderElements(storyElements, storyVariables);

            Assert.Equal("test", sut);
        }

        [Fact]
        public void RenderElements_OneElementMultipleSnippetsEvaluatorLast_RendersText()
        {
            var storyElements = new Collection<StoryElement>();
            storyElements.Add(new StoryElement(new List<string>() {"nope", "nuh-uh", "wrong", "answer", "test"}, (StoryVariables) => 4));

            var storyVariables = new StoryVariables();

            var sut = ElementRenderer.RenderElements(storyElements, storyVariables);

            Assert.Equal("test", sut);
        }

        [Fact]
        public void RenderElements_TwoElementsMultipleSnippets_RendersText()
        {
            var storyElements = new Collection<StoryElement>();
            storyElements.Add(new StoryElement(new List<string>() {"nope", "nuh-uh", "test", "wrong", "answer"}, (StoryVariables) => 2));
            storyElements.Add(new StoryElement(new List<string>() {"nope", "nuh-uh", "wrong", "answer", "test"}, (StoryVariables) => 4));

            var storyVariables = new StoryVariables();

            var sut = ElementRenderer.RenderElements(storyElements, storyVariables);

            Assert.Equal("testtest", sut);
        }

        [Fact]
        public void RenderElements_MultipleElementsMultipleSnippets_RendersText()
        {
            var storyElements = new Collection<StoryElement>();
            storyElements.Add(new StoryElement(new List<string>() {"nope", "nuh-uh", "test ", "wrong", "answer"}, (StoryVariables) => 2));
            storyElements.Add(new StoryElement(new List<string>() {"nope", "nuh-uh", "wrong", "answer", "test "}, (StoryVariables) => 4));
            storyElements.Add(new StoryElement(new List<string>() {"answer", "test "}, (StoryVariables) => 1));
            storyElements.Add(new StoryElement(new List<string>() {"test. ", "nope", "nuh-uh", "wrong", "answer", "test2"}));

            var storyVariables = new StoryVariables();

            var sut = ElementRenderer.RenderElements(storyElements, storyVariables);

            Assert.Equal("test test test test. ", sut);
        }
    }
}