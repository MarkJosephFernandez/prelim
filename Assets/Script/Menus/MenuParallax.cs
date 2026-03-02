using UnityEngine;

public class MenuParallax : MonoBehaviour
{
    [SerializeField] private float movespeed;
    float backgroundImageWidth;
    void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        backgroundImageWidth = sprite.texture.width / sprite.pixelsPerUnit;
        Debug.Log(backgroundImageWidth);
    }

    void Update()
    {
        float moveX = movespeed  * Time.deltaTime;
        transform.position += new Vector3(moveX, 0);
        if (Mathf.Abs(transform.position.x) - backgroundImageWidth > 0)
        {
            transform.position = new Vector3(0f, transform.position.y);
        }
    }
}
