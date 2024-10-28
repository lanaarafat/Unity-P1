using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;



public class Generate : MonoBehaviour
{
    [SerializeField] private ScriptableObjectTest items;
    [SerializeField] private TMP_Text displayText;
    [SerializeField] private RawImage displayImage;

    public void GenerateNewItem()
    {
        displayText.text = items.itemName;
        displayImage.texture = items.itemIcon;
    }

}
