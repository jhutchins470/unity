using UnityEngine;
using System.Collections;
using TMPro;

public class ChangeName: MonoBehaviour
{
    void Update()
   {
       if (Input.GetKeyDown("space"))
     {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText("Hello World from Julia");
       
     }
    }

}