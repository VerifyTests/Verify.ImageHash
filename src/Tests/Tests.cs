namespace VerifyImageHashTests;

public class Tests
{
    [Test]
    public Task FailingCompare() =>
        ThrowsTask(async () =>
            {
                await VerifyFile(ProjectFiles.sample_jpg.Path)
                    .DisableDiff()
                    .UseMethodName("FailingCompareInner")
                    .UseImageHash(85);
            })
            .IgnoreStackTrace()
            .ScrubLinesContaining("clipboard", "DiffEngineTray");
}