[TestFixture]
public class Samples
{
    #region CompareImage

    [Test]
    public Task CompareImage()
    {
        return VerifyFile("sample.jpg");
    }

    #endregion
}