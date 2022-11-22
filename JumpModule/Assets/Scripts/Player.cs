using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] JumpMod jump;
    void Start()
    {
        jump = GetComponent<JumpMod>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump.Jump();
        }
    }
}
