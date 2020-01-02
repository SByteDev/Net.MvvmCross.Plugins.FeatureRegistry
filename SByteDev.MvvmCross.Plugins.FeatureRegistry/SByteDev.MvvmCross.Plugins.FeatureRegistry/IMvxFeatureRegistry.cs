using System;

namespace SByteDev.MvvmCross.Plugins.FeatureRegistry
{
    public interface IMvxFeatureRegistry
    {
        bool this[Enum feature] { get; set; }

        bool this[Type feature] { get; set; }

        bool this[string feature] { get; set; }
    }
}