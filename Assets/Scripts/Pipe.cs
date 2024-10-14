using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float speed = 200f;
    RectTransform pipeRect;

    void Start()
    {
        pipeRect = GetComponent<RectTransform>();
    }

    void Update()
    {
        pipeRect.anchoredPosition += new Vector2(-speed * Time.deltaTime, 0);

        Destroy(gameObject, 20f);
    }

}
