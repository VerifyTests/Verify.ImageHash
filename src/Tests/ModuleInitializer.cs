public static class ModuleInitializer
{
    #region enable

    [ModuleInitializer]
    public static void Init()
    {
        VerifyImageHash.Initialize();

        #endregion

        VerifyDiffPlex.Initialize();
    }
}