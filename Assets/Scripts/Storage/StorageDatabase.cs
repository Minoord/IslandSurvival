using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageDatabase : MonoBehaviour
{
    private List<Item> storageList;
    private float currentStorageWeight;
    private float maximumStorageWeight;

    public void AddStorage(Item addedItem)
    {
        if(currentStorageWeight >= maximumStorageWeight) return;
        
        storageList.Add(addedItem);
        currentStorageWeight += addedItem.weight;
    }

    public void DeleteStorage(Item deletedItem)
    {
        storageList.Remove(deletedItem);
        currentStorageWeight -= deletedItem.weight;
    }
}
