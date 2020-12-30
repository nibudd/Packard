using System;

namespace Packard.Story
{
    public class StoryVariableValue
    {
        public StoryVariableValue(StoryVariableValueType type, string value)
        {
            Type = type;
            Value = value;
        }
        
        public StoryVariableValueType Type { get; set; }

        public string Value { get; set; }
    }
}