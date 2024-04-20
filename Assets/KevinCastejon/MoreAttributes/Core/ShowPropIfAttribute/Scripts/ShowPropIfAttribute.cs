using UnityEngine;

namespace KevinCastejon.MoreAttributes
{
    public class ShowPropIfAttribute : PropertyAttribute
    {
        public readonly string boolSerializedPropertyName;
        public readonly bool isTrue;

        /// <summary>
        /// Shows or hides a property on the inspector based on another serialized bool property value.
        /// </summary>
        public ShowPropIfAttribute(string boolSerializedPropertyName, bool isTrue = true)
        {
            this.boolSerializedPropertyName = boolSerializedPropertyName;
            this.isTrue = isTrue;
        }
    } 
}