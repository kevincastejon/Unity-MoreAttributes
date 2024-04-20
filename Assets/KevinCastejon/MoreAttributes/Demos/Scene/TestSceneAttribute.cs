using KevinCastejon.MoreAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KevinCastejon.MoreAttributes.Examples
{
    public class TestSceneAttribute : MonoBehaviour
    {
        [Scene][SerializeField] private string _scene;
    }
}
