using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("角色A")]
    public Transform presonA;
    [Header("角色B")]
    public Transform presonB;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度"), Range(0.1f, 15f)]
    public float turn = 1.5f;
    [Header("縮放大小"), Range(0.1f, 3f)]
    public float size = 1.5f;
    [Header("角色A動畫元件")]
    public Animator aniPresonA;
    [Header("角色B動畫元件")]
    public Animator aniPresonB;

    private void Start()
    {
        print("開始事件");
    }

    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        presonA.Rotate(0, joystick.Horizontal * turn, 0);
        presonB.Rotate(0, joystick.Horizontal * turn, 0);

        presonA.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        presonA.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(presonA.localScale.x, 0.3f, 1.2f);
        presonB.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        presonB.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(presonB.localScale.x, 0.3f, 1.2f);
    }

    public void PlayAnimation(string aniName)
    {
        print(aniName);
        aniPresonA.SetTrigger(aniName);
        aniPresonB.SetTrigger(aniName);
    }
}
