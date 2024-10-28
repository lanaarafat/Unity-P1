using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scriptable ObjectTest", menuName = "My Scriptable/Object/Custom", order = 150)]
public class ScriptableObjectTest : ScriptableObject
{
    public string itemName;
    public Texture itemIcon;
}
