using UnityEngine;
using System.Collections;

public class Hertz : MonoBehaviour
{
    public float timeForVolumeCalcInSeconds = 0.3F;
    private AudioClip audioclip;
    private AudioSource audioSource;
    private float timeLastVolumeWasTaken = 0;
    private float lastVolume = 0;

    // Use this for initialization
    IEnumerator Start()
    {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam | UserAuthorization.Microphone);

        if (Application.HasUserAuthorization(UserAuthorization.Microphone))
        {
            foreach (string device in Microphone.devices)
            {
                Debug.Log("Microphone name: " + device);
            }
            if (Microphone.devices.Length == 0)
            {
                Debug.LogError("No Microphones available!");
            }
            else
            {
                audioSource = gameObject.AddComponent<AudioSource>() as AudioSource;
                if (audioSource == null)
                {
                    Debug.LogError("audioSource is null!!!!");
                }
            }
        }
        else
        {
            Debug.LogError("User gave no access to his microphones!");
        }
    }

    // Update is called once per time unit (normally 0.2 seconds)
    void FixedUpdate()
    {
        if (audioSource != null)
        {
            if (!Microphone.IsRecording(null))
            {
                audioSource.clip = Microphone.Start(null, false, 1, 44100);
            }
            else
            {
                if (Time.fixedTime - timeLastVolumeWasTaken > timeForVolumeCalcInSeconds)
                {
                    timeLastVolumeWasTaken = Time.fixedTime;
                    float[] samples = new float[audioSource.clip.samples * audioSource.clip.channels];
                    audioSource.clip.GetData(samples, 0);
                    lastVolume = Mathf.Round(calculateAverageVolume(samples) * 10000F) / 100F;
                    Debug.Log("Time: " + Time.fixedTime + " / average volume * 100F = " + lastVolume);
                    Microphone.End(null);
                }
            }
        }
    }

    /// <summary>
    /// Calculates the average volume of the given samples
    /// </summary>
    /// <returns>The average volume.</returns>
    /// <param name="samples">Samples.</param>
    private float calculateAverageVolume(float[] samples)
    {
        float sum = 0;
        for (int i = 0; i < samples.Length; i++)
        {
            sum += samples[i] * samples[i];    // sum squared samples
        }
        return Mathf.Sqrt(sum / samples.Length); // rms = square root of average }
    }

    /// <summary>
    /// Gets the last calculated volume taken from the microphone (ranges roughly between 0 and 1)
    /// </summary>
    /// <returns>The last volume.</returns>
    public float getLastVolume()
    {
        return lastVolume;
    }

}