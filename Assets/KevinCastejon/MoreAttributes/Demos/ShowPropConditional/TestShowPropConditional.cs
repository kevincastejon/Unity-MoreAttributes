using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.MoreAttributes;
namespace KevinCastejon.MoreAttributes.Examples
{
    public class TestShowPropConditional : MonoBehaviour
    {
        [SerializeField] private bool _isMagician;
        [SerializeField] private int _currentLevel;
        [SerializeField][ShowPropConditional("ShowUltraSpellProp")] private int _ultraSpellCount;

        private bool ShowUltraSpellProp()
        {
            return _isMagician && _currentLevel > 3;
        }
    }
}
