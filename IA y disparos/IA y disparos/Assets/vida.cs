using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class vida : MonoBehaviour
{
    public float vida_ = 100;
    public TextMeshProUGUI textMeshPro_;

    // Update is called once per frame
    private void Update()
    {
        textMeshPro_.text=vida_.ToString();
        if (vida_ < 0)
        {
            if (gameObject.CompareTag("Player"))
            {
                Debug.Log("Game over");
            }
            else if (gameObject.CompareTag("Bot"))
            {
                Destroy(gameObject);
            }
        }
    }
}
