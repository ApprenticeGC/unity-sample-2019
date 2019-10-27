namespace GiantCroissant.ExtractBoltVariableInfo.Hud.Status
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using UnityEngine;

#if ODIN_INSPECTOR
    using Sirenix.OdinInspector;
#endif
    
    [System.Serializable]
    public class VariableContext
    {
        public string name;
        public string typeName;
    }

    public class View : MonoBehaviour
    {
#if ODIN_INSPECTOR
        [TableList]
#endif
        public List<VariableContext> variableContexts;

        void Start()
        {
            var variablesComps = GetComponents<Bolt.Variables>();
            if (variablesComps.Any())
            {
                var allVcs =
                    variablesComps.SelectMany(vc =>
                    {
                        var vcs =
                            vc.declarations.Select(d => new VariableContext
                            {
                                name = d.name,
                                typeName = d.value.GetType().ToString()
                            });

                        return vcs;
                    });
                
                variableContexts.AddRange(allVcs);
            }
        }
    }
}
