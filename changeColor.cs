
using UnityEngine;

public class changeColor : MonoBehaviour
{
    // For meshRenderer use meshRenderer instead of sprite rendered...
    SpriteRenderer sr;
    [SerializeField] [Range(0f, 1f)] float lerpTime;
    [SerializeField] Color[] myColors;

    int colorIndex=0;
    float t = 0f;
    int len;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        len = myColors.Length;
    }

    // Update is called once per frame
    void Update()
    {
        sr.color = Color.Lerp(sr.color, myColors[colorIndex], lerpTime * Time.deltaTime);
        Debug.Log(sr.color);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if(t>.9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len) ? 0 : colorIndex;
        }
    }
}
