using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.MoreAttributes;
namespace KevinCastejon.MoreAttributes.Examples
{
    public class TestShowPropIfAttribute : MonoBehaviour
    {
        [SerializeField] private bool _canBeKilled;
        [SerializeField][ShowPropIf("_canBeKilled")] private int _healthPoints;
        [SerializeField] private bool _hasInfiniteAmmo;
        [SerializeField][ShowPropIf("_hasInfiniteAmmo", false)] private int _ammoCount;
    }
}
