using System;
using MvvmCross;
using SByteDev.Plugins.FeatureRegistry;

namespace SByteDev.MvvmCross.Plugins.FeatureRegistry
{
    [Preserve(AllMembers = true)]
    internal sealed class MvxFeatureRegistry : IMvxFeatureRegistry
    {
        public bool this[Enum feature]
        {
            get => FeatureRegistryPlugin.Instance[feature];
            set => FeatureRegistryPlugin.Instance[feature] = value;
        }

        public bool this[Type feature]
        {
            get => FeatureRegistryPlugin.Instance[feature];
            set => FeatureRegistryPlugin.Instance[feature] = value;
        }

        public bool this[string feature]
        {
            get => FeatureRegistryPlugin.Instance[feature];
            set => FeatureRegistryPlugin.Instance[feature] = value;
        }
    }
}