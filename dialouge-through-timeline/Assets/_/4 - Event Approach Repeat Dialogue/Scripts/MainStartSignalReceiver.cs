namespace GiantCroissant.DialogueThroughTimeline.EventApproachRepeatDialogue
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Playables;

    public class MainStartSignalReceiver : MonoBehaviour, INotificationReceiver
    {
        public CutSceneManager cutSceneManager;

        private PlayableDirector _playableDirector;

        private void Start()
        {
            cutSceneManager.StartCutScene += CutSceneManagerOnStartCutScene;
            _playableDirector = GetComponent<PlayableDirector>();
        }

        private void OnDestroy()
        {
            cutSceneManager.StartCutScene -= CutSceneManagerOnStartCutScene;
        }

        private void CutSceneManagerOnStartCutScene(object sender, System.EventArgs e)
        {
            _playableDirector?.Play();
        }

        public void OnNotify(Playable origin, INotification notification, object context)
        {
            //
            Debug.Log($"Notified that the timeline - Main Start is completed");
            cutSceneManager.CutSceneStartCompleted();
        }
    }
}
