namespace GiantCroissant.InputSystemFirstLook
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    
    using UniRx;

    public class PlayerControlReactive : MonoBehaviour
    {
        public float moveSpeed;
        public GameObject laserPrefab;

        public Transform leftPoint;
        public Transform rightPoint;

        public GameObject pauseHud;
        
        private GameControls _gameControls;

        private bool _fromLeftPoint;

        private bool _pausing;
        
        private readonly CompositeDisposable _compositeDisposable = new CompositeDisposable();

        void Awake()
        {
            _gameControls = new GameControls();
        }

        void Start()
        {
            Observable.FromEvent<
                    System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>,
                    UnityEngine.InputSystem.InputAction.CallbackContext>(
                    h => (c) => h.Invoke(c),
                    h => _gameControls.Battle.Fire.performed += h,
                    h => _gameControls.Battle.Fire.performed -= h)
                .Subscribe(x =>
                {
                    if (!_pausing)
                    {
                        var createdInstance = GameObject.Instantiate(laserPrefab);
                        if (_fromLeftPoint)
                        {
                            createdInstance.transform.SetParent(leftPoint);
                            createdInstance.transform.localPosition = Vector3.zero;
                            createdInstance.transform.SetParent(null);
                        }
                        else
                        {
                            createdInstance.transform.SetParent(rightPoint);
                            createdInstance.transform.localPosition = Vector3.zero;
                            createdInstance.transform.SetParent(null);
                        }

                        _fromLeftPoint = !_fromLeftPoint;
                    }
                })
                .AddTo(_compositeDisposable);
            
            Observable.FromEvent<
                    System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>,
                    UnityEngine.InputSystem.InputAction.CallbackContext>(
                    h => (c) => h.Invoke(c),
                    h => _gameControls.Battle.OpenHud.performed += h,
                    h => _gameControls.Battle.OpenHud.performed -= h)
                .Subscribe(x =>
                {
                    if (!_pausing)
                    {
                        _pausing = true;
                        pauseHud.SetActive(true);
                    }

                })
                .AddTo(_compositeDisposable);

            Observable.EveryUpdate()
                .Subscribe(_ =>
                {
                    if (!_pausing)
                    {
                        var moveValue = _gameControls.Battle.Move.ReadValue<Vector2>();
                        Move((moveValue));
                    }
                })
                .AddTo(_compositeDisposable);
        }

        private void OnEnable()
        {
            _gameControls.Enable();
        }

        private void OnDisable()
        {
            _gameControls.Disable();
        }

        void Move(Vector2 direction)
        {
            if (direction.sqrMagnitude < 0.01)
            {
                return;
            }

            var adjustedDirection = direction * moveSpeed * Time.deltaTime;
            transform.position += new Vector3(adjustedDirection.x, adjustedDirection.y, 0);
        }

        public void ResumeFromPausing()
        {
            _pausing = false;
        }
    }
}
