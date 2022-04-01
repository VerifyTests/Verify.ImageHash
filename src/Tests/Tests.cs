[TestFixture]
public class Tests
{
    [Test]
    public Task FailingCompare() =>
        ThrowsTask(async () =>
            {
                await VerifyFile("sample.jpg")
                    .DisableDiff()
                    .UseMethodName("FailingCompareInner")
                    .UseImageHash(85);
            })
            .IgnoreStackTrack()
            .ScrubLinesContaining("clipboard", "DiffEngineTray");
}