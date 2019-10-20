namespace GiantCroissant.DialogueThroughTimeline.EventApproach
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Playables;

    public class DialogueSignalReceiver : MonoBehaviour, INotificationReceiver
    {
        public GameObject mainOverGO;
        
        public void OnNotify(Playable origin, INotification notification, object context)
        {
            //
            Debug.Log($"Notified that the timeline - Dialogue is completed");
            var pd = mainOverGO?.GetComponent<PlayableDirector>();
            pd?.Play();
        }
    }
}
