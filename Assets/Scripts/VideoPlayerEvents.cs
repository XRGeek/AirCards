using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VideoPlayer>().prepareCompleted += VideoLoaded;
    }

    void VideoLoaded(VideoPlayer vp)
    {
        GetComponent<Animator>().enabled = true;
    }
}
