using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    [SerializeField] InputActionMap inputActions;

    void OnEnable()
    {
        inputActions.Enable();
    }
    void OnDisable()
    {
        inputActions.Disable();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
