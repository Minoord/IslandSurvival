using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputParse : MonoBehaviour
{
    private FPControl _control;
    private FPControl.PlayerControlsActions _inputControls;
    [SerializeField] private Movement _sMovement;
    [SerializeField] private interaction _sinteraction;

    // Start is called before the first frame update
    void Start()
    {
        _control = new FPControl();
        _inputControls = _control.PlayerControls;
        _inputControls.Jump.performed += _sMovement.Jump;
        _inputControls.AttackBreak.performed += _sinteraction.AttackBreak;
        _inputControls.Crafting.performed += _sinteraction.Crafting; 

        _inputControls.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        _sMovement.Walking(_inputControls.Walking.ReadValue<Vector2>());
        _sinteraction.Looking(_inputControls.Walking.ReadValue<Vector2>());
       
    }
}
