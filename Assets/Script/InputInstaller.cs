using UnityEngine;
using Zenject;

public class InputInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
		Container
		.Bind<IInputProvider>()    // IInputProvider������Ƃ�
		.To<NormalInputProvider>() // InputProvider�𒍓�����
		.AsCached();               // �����ς݂Ȃ�g����
	}
}