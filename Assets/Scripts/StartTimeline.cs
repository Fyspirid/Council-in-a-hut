using UnityEngine;
using UnityEngine.Playables;

public class StartTimeline : MonoBehaviour
{
    private PlayableDirector timeline;
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timeline.Play();
        }
    }
}
