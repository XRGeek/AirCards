using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonsEvents : MonoBehaviour
{



    public void OpenURL(string URL)
    {
        Application.OpenURL(URL);
    }

    public void OpenMessage()
    {
        string mobile_num = "+12068175179";
        string message = "Hello Ricky! \n";

        #if UNITY_ANDROID
                string URL = string.Format("sms:{0}?body={1}", mobile_num, message);
        #endif

        #if UNITY_IOS
                    string URL = string.Format("sms:{0}?&body={1}",mobile_num,WWW.EscapeURL(message));
        #endif

        //Execute Text Message
        Application.OpenURL(URL);
    }



}
