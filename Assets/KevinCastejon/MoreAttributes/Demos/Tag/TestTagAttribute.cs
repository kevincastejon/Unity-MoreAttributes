using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.MoreAttributes;
namespace KevinCastejon.MoreAttributes.Examples
{
    public class TestTagAttribute : MonoBehaviour
    {
        [Tag]
        [SerializeField] private string _targetTag;
    }
}
