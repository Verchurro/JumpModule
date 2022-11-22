using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] JumpMod jump;
    void Start()
    {
        jump = GetComponent<JumpMod>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            jump.Jump();
        }
    }
}
