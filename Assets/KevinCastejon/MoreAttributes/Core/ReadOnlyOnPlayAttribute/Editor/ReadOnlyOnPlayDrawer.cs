using UnityEngine;
using UnityEditor;

namespace KevinCastejon.MoreAttributes
{
    [CustomPropertyDrawer(typeof(ReadOnlyOnPlayAttribute))]
    public class ReadOnlyOnPlayDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ReadOnlyOnPlayAttribute att = (ReadOnlyOnPlayAttribute)attribute;
            bool rdOnly = att.invert ? !Application.isPlaying : Application.isPlaying;
            if (rdOnly)
            {
                EditorGUI.BeginDisabledGroup(true);
            }

            EditorGUI.PropertyField(position, property, label);

            if (rdOnly)
            {
                EditorGUI.EndDisabledGroup();
            }
        }
    }
}