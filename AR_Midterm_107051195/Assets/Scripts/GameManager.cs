using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("角色A")]
    public Transform presonA;
    [Header("角色A")]
    public Transform presonB;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;

    private void Start()
    {
        print("開始事件");
    }

    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);
    }
}
