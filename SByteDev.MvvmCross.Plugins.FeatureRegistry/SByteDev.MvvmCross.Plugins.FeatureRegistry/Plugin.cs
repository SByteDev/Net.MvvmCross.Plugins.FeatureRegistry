using MvvmCross;
using MvvmCross.Plugin;

namespace SByteDev.MvvmCross.Plugins.FeatureRegistry
{
    [MvxPlugin]
    [Preserve(AllMembers = true)]
    public sealed class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.IoCProvider.RegisterSingleton<IMvxFeatureRegistry>(new MvxFeatureRegistry());
        }
    }
}