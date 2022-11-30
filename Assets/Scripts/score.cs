using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public static int skor = 0;
    // Start is called before the first frame update
    private void Start()
    {
        skor = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = skor.ToString();
    }
}
