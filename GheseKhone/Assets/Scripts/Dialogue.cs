
using RTLTMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private RTLTextMeshPro textComponent;
    [SerializeField] private float autoNextDelay = 3f;

    [TextArea(3, 6)]
    public string[] lines;

    private int index = 0;
    private float timer;

    void Start()
    {
        if (lines == null || lines.Length == 0 || textComponent == null)
        {
            enabled = false;
            return;
        }

        ShowLine();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.touchCount > 0 &&
            Input.GetTouch(0).phase == TouchPhase.Began)
        {
            NextLine();
        }
        else if (timer >= autoNextDelay)
        {
            NextLine();
        }
    }

    void ShowLine()
    {
        PlayerMovement.instance.canMove = false;
        textComponent.text = lines[index];
        timer = 0f;
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            ShowLine();
        }
        else
        {
            gameObject.SetActive(false);
            PlayerMovement.instance.canMove = true;
        }
    }
}
