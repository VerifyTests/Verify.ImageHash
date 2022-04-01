using CoenM.ImageHash;
using CoenM.ImageHash.HashAlgorithms;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace VerifyTests;

public static class VerifyImageHash
{
    /// <summary>
    /// Helper method that calls <see cref="RegisterComparers"/>(threshold = 95, new DifferenceHash()) for png, bmp, and jpg.
    /// </summary>
    public static void Initialize() =>
        RegisterComparers();

    public static void RegisterComparers(double threshold = 95, IImageHash? algorithm = null)
    {
        RegisterComparer(threshold, algorithm, "png");
        RegisterComparer(threshold, algorithm, "bmp");
        RegisterComparer(threshold, algorithm, "jpg");
    }

    public static void UseImageHash(this VerifySettings settings, double threshold = 95, IImageHash? algorithm = null) =>
        settings.UseStreamComparer(
            (received, verified, _) => Compare(threshold, algorithm, received, verified));

    public static SettingsTask UseImageHash(this SettingsTask settings, double threshold = 95, IImageHash? algorithm = null) =>
        settings.UseStreamComparer(
            (received, verified, _) => Compare(threshold, algorithm, received, verified));

    public static void RegisterComparer(double threshold, IImageHash? algorithm, string extension) =>
        VerifierSettings.RegisterStreamComparer(
            extension,
            (received, verified, _) => Compare(threshold, algorithm, received, verified));

    static Task<CompareResult> Compare(double threshold, IImageHash? algorithm, Stream received, Stream verified)
    {
        using var receivedImage = Image.Load<Rgba32>(received);
        using var verifiedImage = Image.Load<Rgba32>(verified);
        algorithm ??= new DifferenceHash();
        var receivedHash = algorithm.Hash(receivedImage);
        var verifiedHash = algorithm.Hash(verifiedImage);
        var similarity = CompareHash.Similarity(receivedHash, verifiedHash);
        var compare = similarity >= threshold;
        if (compare)
        {
            return Task.FromResult(CompareResult.Equal);
        }

        return Task.FromResult(CompareResult.NotEqual($@"similarity({similarity}) < threshold({threshold}).
If this difference is acceptable, use:

 * Globally: VerifyImageHash.RegisterComparers({similarity});
 * For one test: Verifier.VerifyFile(""file.jpg"").UseImageHash({similarity});"));
    }
}