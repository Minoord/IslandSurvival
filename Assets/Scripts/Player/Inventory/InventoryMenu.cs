using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InventoryMenu : MonoBehaviour
{

    [SerializeField] private GameObject inventoryCanvas;

    public void UseInventory(InputAction.CallbackContext context)
    {
        inventoryCanvas.SetActive(!inventoryCanvas.activeSelf);
    }
    
}
