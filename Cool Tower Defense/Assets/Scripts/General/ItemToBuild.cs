using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item",menuName = "Items")]
public class ItemToBuild : ScriptableObject {

    public new string name;
    public Sprite itemInShop;
    public string description;
    public float price;

}
