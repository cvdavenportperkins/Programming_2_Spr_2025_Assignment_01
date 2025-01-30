using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI;
    public float timer = 5;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public OnTimerElapse;

    private bool isElasped = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >0)
        {
            timer -= Time.DeltaTime;
            timerText.text = timer.ToString("F2")
                if timer(timer <= 0 && !isElapsed)
                {
                    isElasped=true;
                    OnTimerElapse.Invoke();
                }
        }
    }
}
