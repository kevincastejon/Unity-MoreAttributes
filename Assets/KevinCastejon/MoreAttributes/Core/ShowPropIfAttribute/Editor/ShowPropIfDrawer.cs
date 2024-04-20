using UnityEngine;
using UnityEditor;

namespace KevinCastejon.MoreAttributes
{
    [CustomPropertyDrawer(typeof(ShowPropIfAttribute))]
    public class ShowPropIfDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            ShowPropIfAttribute att = (ShowPropIfAttribute)attribute;
            if (property.serializedObject.FindProperty(att.boolSerializedPropertyName).boolValue == att.isTrue)
            {
                return base.GetPropertyHeight(property, label);
            }
            else return 0f;
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ShowPropIfAttribute att = (ShowPropIfAttribute)attribute;
            if (property.serializedObject.FindProperty(att.boolSerializedPropertyName).boolValue == att.isTrue)
            {
                EditorGUI.PropertyField(position, property, label);
            }
        }
    }
}