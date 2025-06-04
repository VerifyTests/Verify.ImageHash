using CoenM.ImageHash.HashAlgorithms;

[TestFixture]
public class Samples
{
    #region CompareImage

    [Test]
    public Task CompareImage() =>
        VerifyFile("sample.jpg");

    #endregion

    #region CompareImageThreshold

    [Test]
    public Task CompareImageThreshold() =>
        VerifyFile("sample.jpg")
            .UseImageHash(threshold: 85);

    #endregion

    #region CompareImageAlgorithm

    [Test]
    public Task CompareImageAlgorithm() =>
        VerifyFile("sample.jpg")
            .UseImageHash(algorithm: new PerceptualHash());

    #endregion
}