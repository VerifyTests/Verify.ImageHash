[TestFixture]
public class Samples
{
    #region CompareImage

    [Test]
    public Task CompareImage() =>
        VerifyFile("sample.jpg");

    #endregion
}