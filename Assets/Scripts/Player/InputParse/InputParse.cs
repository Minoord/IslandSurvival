using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputParse : MonoBehaviour
{
    private FPControl _control;
    private FPControl.PlayerControlsActions _inputControls;
    [SerializeField] private PlayerMovement pPlayerMovement;
    [SerializeField] private InventoryMenu pInventoryMenu;

    // Start is called before the first frame update
    void Start()
    {
        pPlayerMovement = GetComponent<PlayerMovement>();
        pInventoryMenu = GetComponent<InventoryMenu>();
        _control = new FPControl();
        
        _inputControls = _control.PlayerControls;
        _inputControls.Jump.performed += pPlayerMovement.Jump;
        _inputControls.Crafting.performed += pInventoryMenu.UseInventory; 

        _inputControls.Enable();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pPlayerMovement.Walking(_inputControls.Walking.ReadValue<Vector2>());
    }
}
