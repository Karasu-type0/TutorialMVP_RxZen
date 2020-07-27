using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "ZenjectScriptableSample", menuName = "Installers/ZenjectScriptableSample")]
public class ZenjectScriptableSample : ScriptableObjectInstaller<ZenjectScriptableSample>
{
    [SerializeField]
    private int _judgScore;
    public int JudgScore { get { return _judgScore; } }

    public override void InstallBindings()
    {
        Container.Bind<ZenjectScriptableSample>().FromInstance(this).AsCached();
    }
}