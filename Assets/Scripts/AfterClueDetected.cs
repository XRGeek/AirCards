using UnityEngine;
using System.Collections;
using UnityEngine.Video;
using Vuforia;
public class AfterClueDetected : MonoBehaviour,ITrackableEventHandler {
		
        private TrackableBehaviour mTrackableBehaviour;
        public VideoPlayer mediaPlayer;
		public GameObject Enviroment;
        public GameObject element1, element2, element3, element4, element5,donut;
        public ButtonsEvents web;    

	void Start () {
			
			Enviroment.SetActive (false);
    		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
    		if (mTrackableBehaviour)
    		{
    			mTrackableBehaviour.RegisterTrackableEventHandler(this);
    		}
	}
	



	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
				Enviroment.SetActive (true);
                StartCoroutine(PlayVideo());
        }
		else
		{
                StopAllCoroutines();
                mediaPlayer.Stop();
                Enviroment.SetActive(false);
                element1.SetActive(false);
                element2.SetActive(false);
                element2.transform.localPosition = new Vector3(0,0,0);
                element3.SetActive(false);
                element3.transform.localPosition = new Vector3(0, 0, 0);
                element4.SetActive(false);
                element5.SetActive(false);
                donut.SetActive(false);

        }
	}

    IEnumerator PlayVideo()
    {
        yield return new WaitForSecondsRealtime(2);
        mediaPlayer.Play();
        StartCoroutine(ShowDonutModel());
    }
    IEnumerator ShowDonutModel()
    {
        yield return new WaitForSecondsRealtime(11);
        donut.SetActive(true);
        donut.GetComponent<Animator>().SetTrigger("Open");
        StartCoroutine(CloseAnimation());
    }
   
    IEnumerator CloseAnimation()
    {
        yield return new WaitForSecondsRealtime(8);
        donut.GetComponent<Animator>().SetTrigger("Close");
        donut.GetComponent<DonutController>().SetObjectState(false);
    }


   

}
