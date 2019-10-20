namespace GiantCroissant.DialogueThroughTimeline.EventApproach
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Playables;

    public class MainSignalReceiver : MonoBehaviour, INotificationReceiver
    {
        public GameObject dialogueGO;
        
        public void OnNotify(Playable origin, INotification notification, object context)
        {
            //
            Debug.Log($"Notified that the timeline - Main Start is completed");
            var pd = dialogueGO?.GetComponent<PlayableDirector>();
            pd?.Play();
        }
    }
}
