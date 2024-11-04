using System;

/*
 C# Auto-Implemented Property
In C#, an auto-implemented property automatically creates a private backing field and does not require
explicit accessor methods. The body of an auto-implemented property will look like { get; set; },
which helps us write more concise code for basic properties.
 */
namespace Encapsulation
{
    public class HotSauce
    {
        // Title is a property with an explicitly defined backing private field, title.
        // Title also has an explicit getter and setter for accessing and modifying the field
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        // Origin is an auto-implemented property. A hidden, private backing field is automatically created
        // during runtime, which the property will use behind the scenes. Explicit getters and setters are
        // not need. This Origin property is functionally equivalent to the preceding Title property
        public string Origin
        { get; set; }
    }
}

