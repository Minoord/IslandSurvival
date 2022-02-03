using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class interaction : MonoBehaviour
{

    public GameObject _inventoryCanvas;

    public void Crafting(InputAction.CallbackContext context)
    {
       switch (_inventoryCanvas.activeSelf)
        {
            case true:
                _inventoryCanvas.SetActive(false);
                break;
            case false:
                _inventoryCanvas.SetActive(true);
                break;
        }
        Debug.Log("E werkt");
    }

    public void AttackBreak(InputAction.CallbackContext context)
    {
        Debug.Log("Attack/break");
    }

    public void Looking(Vector2 pos)
    {
        Debug.Log("Looking");
    }
}
