# <img src="/src/icon.png" height="30px"> Verify.ImageHash

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/48pfe99118r80g72?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-ImageHash)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.ImageHash.svg)](https://www.nuget.org/packages/Verify.ImageHash/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow comparison of images via [ImageHash](https://github.com/coenm/ImageHash).

**See [Milestones](../../milestones?state=closed) for release notes.**

Contains [comparers](https://github.com/VerifyTests/Verify/blob/master/docs/comparer.md) for png, jpg, and bmp.



## NuGet package

https://nuget.org/packages/Verify.ImageHash/


## Usage

<!-- snippet: enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Init() =>
    VerifyImageHash.Initialize();
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L3-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Image Comparers

The following will use ImageHash to compare the images instead of the default DifferenceHash algorithm.

<!-- snippet: CompareImage -->
<a id='snippet-compareimage'></a>
```cs
[Test]
public Task CompareImage() =>
    VerifyFile("sample.jpg");
```
<sup><a href='/src/Tests/Samples.cs#L4-L10' title='Snippet source file'>snippet source</a> | <a href='#snippet-compareimage' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Register all comparers

All comparers can be registered:

```
VerifyImageHash.RegisterComparers();
```


## Icon

[Swirl](https://thenounproject.com/term/wizard/2744075/) designed by [Philipp Petzka](https://thenounproject.com/masteroficon) from [The Noun Project](https://thenounproject.com/).
