using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Image filling;
    float timeAmt = 90;
    public float time;
    public Text timeText;
    public Text timeText2;
    // Start is called before the first frame update
    void Start()
    {
        filling = this.GetComponent<Image>();
        time = timeAmt;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            filling.fillAmount = time / timeAmt;
            timeText.text = "Time Left: ";
            timeText2.text = time.ToString("F");
        }
        if (time < 0)
        {
            FindObjectOfType<AudioManager>().Play("Lose");
        }
    }
}
