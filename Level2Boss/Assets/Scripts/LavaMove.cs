using UnityEngine;
using System.Collections;

public class LavaMove : MonoBehaviour {

    public float scrollSpeed = 0.5F;
    public Renderer rend1;
    public Renderer rend2;
    public Renderer rend3;
    void Start()
    {
        rend1 = GetComponent<Renderer>();
        rend2= GetComponent<Renderer>();
        rend3 = GetComponent<Renderer>();
    }
    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend1.material.SetTextureOffset("_MainTex", new Vector2(offset, 100));
        rend2.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        rend3.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
