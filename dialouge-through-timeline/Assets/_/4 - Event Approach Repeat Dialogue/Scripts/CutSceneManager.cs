namespace GiantCroissant.DialogueThroughTimeline.EventApproachRepeatDialogue
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Playables;

    public class CutSceneManager : MonoBehaviour
    {
        //
        public GameObject mainUI;
        public GameObject dialogueUI;
        public GameObject mainOverUI;
        
        //
        public event System.EventHandler StartCutScene;
        public event System.EventHandler<string> StartDialogue;
        public event System.EventHandler FinishCutScene;
        
        //
        private int _dialogueIndex = 0;
        private readonly List<string> _dialogueSentences = new List<string>();

        private void Start()
        {
            //
            InitializeSentences();

            StartCoroutine(DelayPlayCutScene());
        }

        private void InitializeSentences()
        {
            _dialogueSentences.Add($"市業東兒一過，意說展節它人後出拉道關縣，會主非，最是是的球風我過年人物響家白單打見舉作的那！想古他會卻有自跑的法媽原作，學公個都工千快，公八消我味界選，創區口情驗開認亮法上……是健治有開是面樣等覺健象賽它");
            _dialogueSentences.Add($"聲於不你的，心去幾車己回了制立問統頭教，突一內內我不飛！一其為人人究親決不分起可後專果筆藝在技室中口心劇一運都話了起設上個大香以大一出牛裡極不選預從一人技告知，部正家特弟易兩以力的然電");
            _dialogueSentences.Add($"其動而政指減下，且道式維是看重吃著球告模。老好招興質關論至放在然他愛萬非大今得引連片，影雖東調加美巴調如味帶我的提；回不經你：選候看資合反葉……未題們園那。");
            _dialogueSentences.Add($"會做需如，一醫府面結日教；人線和通文，修不大難是色陽高相說電乎產，雄風導或最，當年差傳個大食根、財庭快多成然便時笑黑心於到後的，話高相東，家自國友倒：過將要往就童黃！二來道友科他稱旅……你南去信情好話在規它在後音？");
        }
        
        IEnumerator DelayPlayCutScene()
        {
            yield return new WaitForSeconds(3.0f);
            StartCutScene?.Invoke(this, System.EventArgs.Empty);
        }
        
        //
        public void CutSceneStartCompleted()
        {
            //
            PrepareDialgoue();
        }

        public void DialogueCompleted()
        {
            ++_dialogueIndex;
            PrepareDialgoue();
        }

        public void CutSceneFinishCompleted()
        {
            Debug.Log($"CutSceneFinishCompleted");
            
            mainUI?.SetActive(false);
            dialogueUI?.SetActive(false);
            mainOverUI?.SetActive(false);
        }

        private void PrepareDialgoue()
        {
            if (_dialogueIndex < _dialogueSentences.Count)
            {
                StartDialogue?.Invoke(this, _dialogueSentences[_dialogueIndex]);
            }
            else
            {
                FinishCutScene?.Invoke(this, System.EventArgs.Empty);
            }
        }
    }
}
