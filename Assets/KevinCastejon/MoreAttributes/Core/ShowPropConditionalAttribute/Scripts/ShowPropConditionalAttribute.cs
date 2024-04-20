using UnityEngine;

namespace KevinCastejon.MoreAttributes
{
    public class ShowPropConditionalAttribute : PropertyAttribute
    {
        public readonly string boolMethodName;

        /// <summary>
        /// Shows or hides a property based on a bool method.
        /// </summary>
        public ShowPropConditionalAttribute(string boolMethodName)
        {
            this.boolMethodName = boolMethodName;
        }
    }
}