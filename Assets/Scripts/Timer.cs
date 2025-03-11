using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    public float timerDuration = 5;
    private float remainingTime;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public UnityEvent OnTimerElapse;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        remainingTime = timerDuration;
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime;
        timerText.text = remainingTime.ToString("F2");
        if (remainingTime <= 0) 
        {
            OnTimerElapse.Invoke();
            remainingTime = timerDuration;
            audioSource.PlayOneShot(audioClip);
        }
    }
}
