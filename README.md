# MvvmCross FeatureRegistry Plugin
![GitHub](https://img.shields.io/github/license/SByteDev/Net.MvvmCross.Plugins.FeatureRegistry.svg)
![Nuget](https://img.shields.io/nuget/v/SByteDev.MvvmCross.Plugins.FeatureRegistry.svg)

[![Build Status](https://travis-ci.org/SByteDev/Net.MvvmCross.Plugins.FeatureRegistry.svg?branch=master)](https://travis-ci.org/SByteDev/Net.MvvmCross.Plugins.FeatureRegistry)
[![codecov](https://codecov.io/gh/SByteDev/Net.MvvmCross.Plugins.FeatureRegistry/branch/master/graph/badge.svg)](https://codecov.io/gh/SByteDev/Net.MvvmCross.Plugins.FeatureRegistry)
[![CodeFactor](https://www.codefactor.io/repository/github/sbytedev/net.mvvmcross.plugins.featureregistry/badge)](https://www.codefactor.io/repository/github/sbytedev/net.mvvmcross.plugins.featureregistry)

Provides a singleton to store the information about enabled or disabled application features. Features can be represented by a `string`, `Type` or `Enum`.

## Installation

Use [NuGet](https://www.nuget.org) package manager to install this library.

```bash
Install-Package SByteDev.MvvmCross.Plugins.FeatureRegistry
```

## Usage
```cs
using SByteDev.MvvmCross.Plugins.FeatureRegistry;

var featureRegistry = Mvx.IoCProvider.Resolve<IMvxFeatureRegistry>();

featureRegistry["Feature"] = true;
var isEnabled = featureRegistry["Feature"];

featureRegistry[Features.Feature] = true;
var isEnabled = featureRegistry[Features.Feature];

featureRegistry[typeof(Feature)] = true;
var isEnabled = featureRegistry.Instance[typeof(Feature)];
```

## Implementation
Based on [FeatureRegistry Plugin](https://github.com/SByteDev/Net.Plugins.FeatureRegistry).

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update the tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
