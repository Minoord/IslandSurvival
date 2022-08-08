using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageDatabase : MonoBehaviour
{
    private List<Item> storageContent;
    [SerializeField] private List<GameObject> storageBoxColliders;
    
    [SerializeField] private float currentStorageWeight;
    [SerializeField] private float maximumStorageWeight;
    [SerializeField] private int storageLength;
    [SerializeField] private int storageWidth;

    [SerializeField] private Vector2 boxColliderStartPlacement;
    [SerializeField] private Vector2 boxColliderLengthWidth;

    private void Start()
    {
        var boxCollidersCount = storageLength * storageWidth;
        if (storageBoxColliders.Count != boxCollidersCount || storageBoxColliders == null)
        {
            DeleteStorageColliders();
            AddStorageColliders(boxCollidersCount);
        }
    }


    private void AddStorageColliders(int boxCollidersCount)
    {
        var colliderPlacement = boxColliderStartPlacement;
        var maxiumXPlacement = storageWidth * boxColliderLengthWidth.x + boxColliderStartPlacement.x + boxColliderLengthWidth.x ;
        
        for (int i = 0; i < boxCollidersCount; i++)
        {
            var newCollider = Instantiate(gameObject, colliderPlacement, new Quaternion(0, 0, 0, 0));
            newCollider.transform.localScale = boxColliderLengthWidth;
            newCollider.AddComponent<BoxCollider2D>();
            storageBoxColliders.Add(newCollider);
            
            colliderPlacement.x += boxColliderLengthWidth.x;
            
            if (colliderPlacement.x == maxiumXPlacement)
            {
                var newYplacement = boxColliderStartPlacement.y + boxColliderLengthWidth.y;
                colliderPlacement = new Vector2(boxColliderStartPlacement.x, newYplacement);
            }
        }
    }

    private void DeleteStorageColliders()
    {
        if(storageBoxColliders == null) return;
        foreach (var colliders in storageBoxColliders)
        {
            storageBoxColliders.Remove(colliders);
            Destroy(colliders);
        }
    }

    /*public void AddStorage(Item addedItem)
    {
        if(currentStorageWeight >= maximumStorageWeight) return;
        
        storageContent.Add(addedItem);
        currentStorageWeight += addedItem.weight;
    }

    public void DeleteStorage(Item deletedItem)
    {
        storageContent.Remove(deletedItem);
        currentStorageWeight -= deletedItem.weight;
    }*/
}
