# <img src="/src/icon.png" height="30px"> Verify.ImageHash

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/48pfe99118r80g72?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-ImageHash)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.ImageHash.svg)](https://www.nuget.org/packages/Verify.ImageHash/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow comparison of images via [ImageHash](https://github.com/coenm/ImageHash).

**See [Milestones](../../milestones?state=closed) for release notes.**

Contains [comparers](https://github.com/VerifyTests/Verify/blob/master/docs/comparer.md) for png, jpg, and bmp.


## NuGet

 * https://nuget.org/packages/Verify.ImageHash


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
<a id='snippet-CompareImage'></a>
```cs
[Test]
public Task CompareImage() =>
    VerifyFile("sample.jpg");
```
<sup><a href='/src/Tests/Samples.cs#L6-L12' title='Snippet source file'>snippet source</a> | <a href='#snippet-CompareImage' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Register all comparers

All comparers can be registered:

```
VerifyImageHash.RegisterComparers();
```


### Use specific threshold

<!-- snippet: CompareImageThreshold -->
<a id='snippet-CompareImageThreshold'></a>
```cs
[Test]
public Task CompareImageThreshold() =>
    VerifyFile("sample.jpg")
        .UseImageHash(threshold: 85);
```
<sup><a href='/src/Tests/Samples.cs#L14-L21' title='Snippet source file'>snippet source</a> | <a href='#snippet-CompareImageThreshold' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Use specific algorithm

<!-- snippet: CompareImageAlgorithm -->
<a id='snippet-CompareImageAlgorithm'></a>
```cs
[Test]
public Task CompareImageAlgorithm() =>
    VerifyFile("sample.jpg")
        .UseImageHash(algorithm: new PerceptualHash());
```
<sup><a href='/src/Tests/Samples.cs#L23-L30' title='Snippet source file'>snippet source</a> | <a href='#snippet-CompareImageAlgorithm' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Icon

[Swirl](https://thenounproject.com/term/wizard/2744075/) designed by [Philipp Petzka](https://thenounproject.com/masteroficon) from [The Noun Project](https://thenounproject.com/).
