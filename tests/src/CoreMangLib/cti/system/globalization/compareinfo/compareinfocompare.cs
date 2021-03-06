using System;
using System.Globalization;
using TestLibrary;

class CompareInfoCompare
{
    static int Main()
    {
        CompareInfoCompare test = new CompareInfoCompare();

        TestFramework.BeginTestCase("CompareInfo.Compare");

        if (test.RunTests())
        {
            TestFramework.EndTestCase();
            TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestFramework.EndTestCase();
            TestFramework.LogInformation("FAIL");
            return 0;
        }

    }

    public bool RunTests()
    {
        bool ret = true;

        ret &= Test1();
        ret &= Test2();
        ret &= Test3();
        ret &= Test4();
        ret &= Test5();
        ret &= Test6();
        ret &= Test7();
        ret &= Test8();
        ret &= Test9();
        ret &= Test10();

        ret &= Test11();
        ret &= Test12();
        ret &= Test13();
        ret &= Test14();
        ret &= Test15();
        ret &= Test16();
        ret &= Test17();
        ret &= Test18();
        ret &= Test19();
        ret &= Test20();

        ret &= Test21();
        ret &= Test22();
        ret &= Test23();
        ret &= Test24();
        ret &= Test25();
        ret &= Test26();
        ret &= Test27();
        ret &= Test28();
        ret &= Test29();
        ret &= Test30();

        ret &= Test31();
        ret &= Test32();
        ret &= Test33();
        ret &= Test34();
        ret &= Test35();
        ret &= Test36();
        ret &= Test37();
        ret &= Test38();
        ret &= Test39();
        ret &= Test40();

        ret &= Test41();
        ret &= Test42();
        ret &= Test43();
        ret &= Test44();
        ret &= Test45();
        ret &= Test46();
        ret &= Test47();
        ret &= Test48();
        ret &= Test49();
        ret &= Test50();

        ret &= Test51();
        ret &= Test52();
        ret &= Test53();
        ret &= Test54();
        ret &= Test55();
        ret &= Test56();
        ret &= Test57();
        ret &= Test58();
        ret &= Test59();
        ret &= Test60();

        ret &= Test61();
        ret &= Test62();
        if (Utilities.IsWindows) ret &= Test63(); // Fails because of an OSX bug, so this is not interesting on the Mac
        ret &= Test64();
        ret &= Test65();
        ret &= Test66();
        ret &= Test67();
        ret &= Test68();
        ret &= Test69();
        ret &= Test70();

        ret &= Test71();
        ret &= Test72();
        ret &= Test73();
        ret &= Test74();
        ret &= Test75();
        ret &= Test76();
        ret &= Test77();
        ret &= Test78();
        ret &= Test79();
        ret &= Test80();

        ret &= Test81();
        ret &= Test82();
        ret &= Test83();
        ret &= Test84();
        ret &= Test85();
        ret &= Test86();
        ret &= Test87();
        ret &= Test88();
        ret &= Test89();
        ret &= Test90();

        ret &= Test91();
        ret &= Test92();
        ret &= Test93();
        ret &= Test94();
        ret &= Test95();
        ret &= Test96();
        ret &= Test97();
        ret &= Test98();
        ret &= Test99();
        ret &= Test100();

        ret &= Test101();
        ret &= Test102();
        ret &= Test103();
        ret &= Test104();
        ret &= Test105();
        ret &= Test106();
        ret &= Test107();
        ret &= Test108();
        ret &= Test109();
        ret &= Test110();

        ret &= Test111();
        ret &= Test112();
        ret &= Test113();
        ret &= Test114();
        ret &= Test115();
        ret &= Test116();
        ret &= Test117();
        ret &= Test118();
        ret &= Test119();
        ret &= Test120();

        ret &= Test121();
        ret &= Test122();
        ret &= Test123();
        ret &= Test124();
        ret &= Test125();
        ret &= Test126();
        ret &= Test127();
        ret &= Test128();
        ret &= Test129();
        ret &= Test130();

        ret &= Test131();
        ret &= Test132();
        ret &= Test133();
        ret &= Test134();
        ret &= Test135();
        ret &= Test136();
        ret &= Test137();
        ret &= Test138();
        ret &= Test139();
        ret &= Test140();

        ret &= Test141();
        ret &= Test142();
        ret &= Test143();
        ret &= Test144();
        ret &= Test145();
        ret &= Test146();
        ret &= Test147();
        ret &= Test148();
        ret &= Test149();
        ret &= Test150();

        ret &= Test151();
        ret &= Test152();
        ret &= Test153();
        ret &= Test154();
        ret &= Test155();
        ret &= Test156();
        ret &= Test157();

        return ret;
    }

    CultureInfo hungarian = new CultureInfo("hu-HU");
    CultureInfo turkish = new CultureInfo("tr-TR");

    public bool Test1() { return TestOrd(CultureInfo.InvariantCulture, "あ", "ァ", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "001"); }
    public bool Test2() { return TestOrd(CultureInfo.InvariantCulture, "あ", "ア", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "002"); }
    public bool Test3() { return TestOrd(CultureInfo.InvariantCulture, "あ", "ｱ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "003"); }
    public bool Test4() { return TestOrd(CultureInfo.InvariantCulture, "きゃ", "キャ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "004"); }
    public bool Test5() { return TestOrd(CultureInfo.InvariantCulture, "きゃ", "キゃ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "005"); }
    public bool Test6() { return TestOrd(CultureInfo.InvariantCulture, "き ゃ", "キゃ", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "006"); }
    public bool Test7() { return TestOrd(CultureInfo.InvariantCulture, "い", "I", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "007"); }
    public bool Test8() { return TestOrd(CultureInfo.InvariantCulture, "a", "A", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "008"); }
    public bool Test9() { return TestOrd(CultureInfo.InvariantCulture, "a", "ａ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "009"); }
    public bool Test10() { return TestOrd(CultureInfo.InvariantCulture, "ABCDE", "ＡＢＣＤＥ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "010"); }
    public bool Test11() { return TestOrd(CultureInfo.InvariantCulture, "ABCDE", "ＡＢＣDＥ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "011"); }
    public bool Test12() { return TestOrd(CultureInfo.InvariantCulture, "ABCDE", "aＢＣDＥ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "012"); }
    public bool Test13() { return TestOrd(CultureInfo.InvariantCulture, "ABCDE", "ａｂＣDＥ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "013"); }
    public bool Test14() { return TestOrd(CultureInfo.InvariantCulture, "澤", "沢", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "014"); }
    public bool Test15() { return TestOrd(CultureInfo.InvariantCulture, "ばびぶべぼ", "バビブベボ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "015"); }
    public bool Test16() { return TestOrd(CultureInfo.InvariantCulture, "ばびぶべぼ", "バビぶベボ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "016"); }
    public bool Test17() { return TestOrd(CultureInfo.InvariantCulture, "ばびぶべぼ", "バビぶベﾎﾞ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "017"); }
    public bool Test18() { return TestOrd(CultureInfo.InvariantCulture, "ばびﾌﾞﾍﾞぼ", "バビぶベﾎﾞ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "018"); }
    public bool Test19() { return TestOrd(CultureInfo.InvariantCulture, "ばびﾌﾞﾍﾞぼ", "ﾎﾞ", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "019"); }
    public bool Test20() { return TestOrd(CultureInfo.InvariantCulture, "ばボﾌﾞﾍﾞぼ", "ﾎﾞ", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "020"); }
    public bool Test21() { return TestOrd(CultureInfo.InvariantCulture, "ばボﾌﾞﾍﾞぼ", "べﾎﾞ", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "021"); }
    public bool Test22() { return TestOrd(CultureInfo.InvariantCulture, "ばびﾌﾞﾍﾞぼ", "ブ", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "022"); }
    public bool Test23() { return TestOrd(CultureInfo.InvariantCulture, "ぱぴプぺ", "ﾋﾟﾌﾟ", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "023"); }
    public bool Test24() { return TestOrd(CultureInfo.InvariantCulture, "ばボﾌﾞﾍﾞぼ", "ばﾎﾞブ", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "024"); }
    public bool Test25() { return TestOrd(CultureInfo.InvariantCulture, "ばボﾌﾞﾍﾞぼべぼ", "べﾎﾞ", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "025"); }
    public bool Test26() { return TestOrd(CultureInfo.InvariantCulture, "ばﾌﾞﾍﾞぼ", "ブ", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "026"); }
    public bool Test27() { return TestOrd(CultureInfo.InvariantCulture, "ABDDE", "D", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "027"); }
    public bool Test28() { return TestOrd(CultureInfo.InvariantCulture, "ABCDE", "ｃDＥ", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "028"); }
    public bool Test29() { return TestOrd(CultureInfo.InvariantCulture, "ABCDE", "ｃD", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "029"); }
    public bool Test30() { return TestOrd(CultureInfo.InvariantCulture, "ABCDE", "c", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "030"); }
    public bool Test31() { return TestOrd(CultureInfo.InvariantCulture, "だ", "た", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "031"); }
    public bool Test32() { return TestOrd(CultureInfo.InvariantCulture, "だ", "ﾀﾞ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "032"); }
    public bool Test33() { return TestOrd(CultureInfo.InvariantCulture, "だ", "ダ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "033"); }
    public bool Test34() { return TestOrd(CultureInfo.InvariantCulture, "デタベス", "ﾃﾞﾀﾍﾞｽ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "034"); }
    public bool Test35() { return TestOrd(CultureInfo.InvariantCulture, "デ", "ﾃﾞ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "035"); }
    public bool Test36() { return TestOrd(CultureInfo.InvariantCulture, "デタ", "ﾃﾞﾀ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "036"); }
    public bool Test37() { return TestOrd(CultureInfo.InvariantCulture, "デタベ", "ﾃﾞﾀﾍﾞ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "037"); }
    public bool Test38() { return TestOrd(CultureInfo.InvariantCulture, "タ", "ﾀ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "038"); }
    public bool Test39() { return TestOrd(CultureInfo.InvariantCulture, "ﾃﾞｰﾀﾍﾞｰｽ", "でーたべーす", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "039"); }
    public bool Test40() { return TestOrd(CultureInfo.InvariantCulture, "森鴎外", "森鷗外", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "040"); }
    public bool Test41() { return TestOrd(CultureInfo.InvariantCulture, "森鷗外", "森鷗外", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "041"); }
    public bool Test42() { return TestOrd(CultureInfo.InvariantCulture, "’’’’", "''''", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "042"); }
    public bool Test43() { return TestOrd(CultureInfo.InvariantCulture, "’", "'", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "043"); }
    public bool Test44() { return TestOrd(CultureInfo.InvariantCulture, "", "'", -1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "044"); }
    public bool Test45() { return TestOrd(CultureInfo.InvariantCulture, "一", "１", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "045"); }
    public bool Test46() { return TestOrd(CultureInfo.InvariantCulture, "Ⅰ", "１", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "046"); }
    public bool Test47() { return TestOrd(CultureInfo.InvariantCulture, "0", "０", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "047"); }
    public bool Test48() { return TestOrd(CultureInfo.InvariantCulture, "10", "1０", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "048"); }
    public bool Test49() { return TestOrd(CultureInfo.InvariantCulture, "1０", "1０", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "049"); }
    public bool Test50() { return TestOrd(CultureInfo.InvariantCulture, "9999９10", "1０", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "050"); }
    public bool Test51() { return TestOrd(CultureInfo.InvariantCulture, "9999９1010", "1０", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "051"); }
    public bool Test52() { return TestOrd(CultureInfo.InvariantCulture, "'　'", "' '", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "052"); }
    public bool Test53() { return TestOrd(CultureInfo.InvariantCulture, "'　'", "''", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "053"); }
    public bool Test54() { return TestOrd(CultureInfo.InvariantCulture, "；", ";", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "054"); }
    public bool Test55() { return TestOrd(CultureInfo.InvariantCulture, "（", "(", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "055"); }
    public bool Test56() { return TestOrd(CultureInfo.InvariantCulture, "ー", "ｰ", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "056"); }
    public bool Test57() { return TestOrd(CultureInfo.InvariantCulture, "ー", "－", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "057"); }
    public bool Test58() { return TestOrd(CultureInfo.InvariantCulture, "ー", "ー", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "058"); }
    public bool Test59() { return TestOrd(CultureInfo.InvariantCulture, "ー", "―", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "059"); }
    public bool Test60() { return TestOrd(CultureInfo.InvariantCulture, "ー", "‐", 1, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "060"); }
    public bool Test61() { return TestOrd(CultureInfo.InvariantCulture, "/", "／", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "061"); }
    public bool Test62() { return TestOrd(CultureInfo.InvariantCulture, "'", "\uFF07", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "062"); }
    public bool Test63() { return TestOrd(CultureInfo.InvariantCulture, "\"", "\uFF02", 0, CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase, "063"); }
    public bool Test64() { return Test(CultureInfo.InvariantCulture, "あ", "ァ", 1, CompareOptions.None, "001a"); }
    public bool Test65() { return Test(CultureInfo.InvariantCulture, "あ", "ア", 1, CompareOptions.None, "002a"); }
    public bool Test66() { return Test(CultureInfo.InvariantCulture, "あ", "ｱ", 1, CompareOptions.None, "003a"); }
    public bool Test67() { return Test(CultureInfo.InvariantCulture, "きゃ", "キャ", 1, CompareOptions.None, "004a"); }
    public bool Test68() { return Test(CultureInfo.InvariantCulture, "きゃ", "キゃ", 1, CompareOptions.None, "005a"); }
    public bool Test69() { return Test(CultureInfo.InvariantCulture, "き ゃ", "キゃ", -1, CompareOptions.None, "006a"); }
    public bool Test70() { return Test(CultureInfo.InvariantCulture, "い", "I", 1, CompareOptions.None, "007a"); }
    public bool Test71() { return Test(CultureInfo.InvariantCulture, "a", "A", -1, CompareOptions.None, "008a"); }
    public bool Test72() { return Test(CultureInfo.InvariantCulture, "a", "ａ", -1, CompareOptions.None, "009a"); }
    public bool Test73() { return Test(CultureInfo.InvariantCulture, "ABCDE", "ＡＢＣＤＥ", -1, CompareOptions.None, "010a"); }
    public bool Test74() { return Test(CultureInfo.InvariantCulture, "ABCDE", "ＡＢＣDＥ", -1, CompareOptions.None, "011a"); }
    public bool Test75() { return Test(CultureInfo.InvariantCulture, "ABCDE", "aＢＣDＥ", 1, CompareOptions.None, "012a"); }
    public bool Test76() { return Test(CultureInfo.InvariantCulture, "ABCDE", "ａｂＣDＥ", 1, CompareOptions.None, "013a"); }
    public bool Test77() { return Test(CultureInfo.InvariantCulture, "澤", "沢", 1, CompareOptions.None, "014a"); }
    public bool Test78() { return Test(CultureInfo.InvariantCulture, "ばびぶべぼ", "バビブベボ", 1, CompareOptions.None, "015a"); }
    public bool Test79() { return Test(CultureInfo.InvariantCulture, "ばびぶべぼ", "バビぶベボ", 1, CompareOptions.None, "016a"); }
    public bool Test80() { return Test(CultureInfo.InvariantCulture, "ばびぶべぼ", "バビぶベﾎﾞ", 1, CompareOptions.None, "017a"); }
    public bool Test81() { return Test(CultureInfo.InvariantCulture, "ばびﾌﾞﾍﾞぼ", "バビぶベﾎﾞ", 1, CompareOptions.None, "018a"); }
    public bool Test82() { return Test(CultureInfo.InvariantCulture, "ばびﾌﾞﾍﾞぼ", "ﾎﾞ", -1, CompareOptions.None, "019a"); }
    public bool Test83() { return Test(CultureInfo.InvariantCulture, "ばボﾌﾞﾍﾞぼ", "ﾎﾞ", -1, CompareOptions.None, "020a"); }
    public bool Test84() { return Test(CultureInfo.InvariantCulture, "ばボﾌﾞﾍﾞぼ", "べﾎﾞ", -1, CompareOptions.None, "021a"); }
    public bool Test85() { return Test(CultureInfo.InvariantCulture, "ばびﾌﾞﾍﾞぼ", "ブ", -1, CompareOptions.None, "022a"); }
    public bool Test86() { return Test(CultureInfo.InvariantCulture, "ぱぴプぺ", "ﾋﾟﾌﾟ", -1, CompareOptions.None, "023a"); }
    public bool Test87() { return Test(CultureInfo.InvariantCulture, "ばボﾌﾞﾍﾞぼ", "ばﾎﾞブ", 1, CompareOptions.None, "024a"); }
    public bool Test88() { return Test(CultureInfo.InvariantCulture, "ばボﾌﾞﾍﾞぼべぼ", "べﾎﾞ", -1, CompareOptions.None, "025a"); }
    public bool Test89() { return Test(CultureInfo.InvariantCulture, "ばﾌﾞﾍﾞぼ", "ブ", -1, CompareOptions.None, "026a"); }
    public bool Test90() { return Test(CultureInfo.InvariantCulture, "ABDDE", "D", -1, CompareOptions.None, "027a"); }
    public bool Test91() { return Test(CultureInfo.InvariantCulture, "ABCDE", "ｃDＥ", -1, CompareOptions.None, "028a"); }
    public bool Test92() { return Test(CultureInfo.InvariantCulture, "ABCDE", "ｃD", -1, CompareOptions.None, "029a"); }
    public bool Test93() { return Test(CultureInfo.InvariantCulture, "ABCDE", "c", -1, CompareOptions.None, "030a"); }
    public bool Test94() { return Test(CultureInfo.InvariantCulture, "だ", "た", 1, CompareOptions.None, "031a"); }
    public bool Test95() { return Test(CultureInfo.InvariantCulture, "だ", "ﾀﾞ", 1, CompareOptions.None, "032a"); }
    public bool Test96() { return Test(CultureInfo.InvariantCulture, "だ", "ダ", 1, CompareOptions.None, "033a"); }
    public bool Test97() { return Test(CultureInfo.InvariantCulture, "デタベス", "ﾃﾞﾀﾍﾞｽ", 1, CompareOptions.None, "034a"); }
    public bool Test98() { return Test(CultureInfo.InvariantCulture, "デ", "ﾃﾞ", 1, CompareOptions.None, "035a"); }
    public bool Test99() { return Test(CultureInfo.InvariantCulture, "デタ", "ﾃﾞﾀ", 1, CompareOptions.None, "036a"); }
    public bool Test100() { return Test(CultureInfo.InvariantCulture, "デタベ", "ﾃﾞﾀﾍﾞ", 1, CompareOptions.None, "037a"); }
    public bool Test101() { return Test(CultureInfo.InvariantCulture, "タ", "ﾀ", 1, CompareOptions.None, "038a"); }
    public bool Test102() { return Test(CultureInfo.InvariantCulture, "ﾃﾞｰﾀﾍﾞｰｽ", "でーたべーす", -1, CompareOptions.None, "039a"); }
    public bool Test103() { return Test(CultureInfo.InvariantCulture, "森鴎外", "森鷗外", -1, CompareOptions.None, "040a"); }
    public bool Test104() { return Test(CultureInfo.InvariantCulture, "森鷗外", "森鷗外", 0, CompareOptions.None, "041a"); }
    public bool Test105() { return Test(CultureInfo.InvariantCulture, "’’’’", "''''", 1, CompareOptions.None, "042a"); }
    public bool Test106() { return Test(CultureInfo.InvariantCulture, "’", "'", 1, CompareOptions.None, "043a"); }
    public bool Test107() { return Test(CultureInfo.InvariantCulture, "", "'", -1, CompareOptions.None, "044a"); }
    public bool Test108() { return Test(CultureInfo.InvariantCulture, "一", "１", 1, CompareOptions.None, "045a"); }
    public bool Test109() { return Test(CultureInfo.InvariantCulture, "Ⅰ", "１", 1, CompareOptions.None, "046a"); }
    public bool Test110() { return Test(CultureInfo.InvariantCulture, "0", "０", -1, CompareOptions.None, "047a"); }
    public bool Test111() { return Test(CultureInfo.InvariantCulture, "10", "1０", -1, CompareOptions.None, "048a"); }
    public bool Test112() { return Test(CultureInfo.InvariantCulture, "1０", "1０", 0, CompareOptions.None, "049a"); }
    public bool Test113() { return Test(CultureInfo.InvariantCulture, "9999９10", "1０", 1, CompareOptions.None, "050a"); }
    public bool Test114() { return Test(CultureInfo.InvariantCulture, "9999９1010", "1０", 1, CompareOptions.None, "051a"); }
    public bool Test115() { return Test(CultureInfo.InvariantCulture, "'　'", "' '", 1, CompareOptions.None, "052a"); }
    public bool Test116() { return Test(CultureInfo.InvariantCulture, "'　'", "''", 1, CompareOptions.None, "053a"); }
    public bool Test117() { return Test(CultureInfo.InvariantCulture, "；", ";", 1, CompareOptions.None, "054a"); }
    public bool Test118() { return Test(CultureInfo.InvariantCulture, "（", "(", 1, CompareOptions.None, "055a"); }
    public bool Test119() { return Test(CultureInfo.InvariantCulture, "ー", "ｰ", 0, CompareOptions.None, "056a"); }
    public bool Test120() { return Test(CultureInfo.InvariantCulture, "ー", "－", 1, CompareOptions.None, "057a"); }
    public bool Test121() { return Test(CultureInfo.InvariantCulture, "ー", "ー", 0, CompareOptions.None, "058a"); }
    public bool Test122() { return Test(CultureInfo.InvariantCulture, "ー", "―", 1, CompareOptions.None, "059a"); }
    public bool Test123() { return Test(CultureInfo.InvariantCulture, "ー", "‐", 1, CompareOptions.None, "060a"); }
    public bool Test124() { return Test(CultureInfo.InvariantCulture, "/", "／", -1, CompareOptions.None, "061a"); }
    public bool Test125() { return Test(CultureInfo.InvariantCulture, "'", "\uFF07", -1, CompareOptions.None, "062a"); }
    public bool Test126() { return Test(CultureInfo.InvariantCulture, "\"", "\uFF02", -1, CompareOptions.None, "063a"); }

    public bool Test127() { return Test(hungarian, "dzsdzs", "ddzs", 0, CompareOptions.None, "064"); }
    public bool Test128() { return TestOrd(hungarian, "dzsdzs", "ddzs", 1, CompareOptions.Ordinal, "065"); }
    public bool Test129() { return Test(CultureInfo.InvariantCulture, "dzsdzs", "ddzs", 1, CompareOptions.None, "066"); }
    public bool Test130() { return TestOrd(CultureInfo.InvariantCulture, "dzsdzs", "ddzs", 1, CompareOptions.Ordinal, "067"); }

    public bool Test131() { return Test(turkish, "i", "I", 1, CompareOptions.IgnoreCase, "068"); }
    public bool Test132() { return Test(CultureInfo.InvariantCulture, "i", "I", 0, CompareOptions.IgnoreCase, "069"); }
    public bool Test133() { return Test(turkish, "i", "\u0130", 0, CompareOptions.IgnoreCase, "070"); }
    public bool Test134() { return Test(CultureInfo.InvariantCulture, "i", "\u0130", -1, CompareOptions.IgnoreCase, "071"); }
    public bool Test135() { return Test(turkish, "i", "I", 1, CompareOptions.None, "072"); }
    public bool Test136() { return Test(CultureInfo.InvariantCulture, "i", "I", -1, CompareOptions.None, "073"); }
    public bool Test137() { return Test(turkish, "i", "\u0130", -1, CompareOptions.None, "074"); }
    public bool Test138() { return Test(CultureInfo.InvariantCulture, "i", "\u0130", -1, CompareOptions.None, "075"); }

    public bool Test139() { return Test(CultureInfo.InvariantCulture, "\u00C0", "A\u0300", 0, CompareOptions.None, "076"); }
    public bool Test140() { return TestOrd(CultureInfo.InvariantCulture, "\u00C0", "A\u0300", 1, CompareOptions.Ordinal, "077"); }
    public bool Test141() { return Test(CultureInfo.InvariantCulture, "\u00C0", "a\u0300", 0, CompareOptions.IgnoreCase, "078"); }
    public bool Test142() { return TestOrd(CultureInfo.InvariantCulture, "\u00C0", "a\u0300", 1, CompareOptions.OrdinalIgnoreCase, "079"); }
    public bool Test143() { return Test(CultureInfo.InvariantCulture, "\u00C0", "a\u0300", 1, CompareOptions.None, "080"); }
    public bool Test144() { return TestOrd(CultureInfo.InvariantCulture, "\u00C0", "a\u0300", 1, CompareOptions.Ordinal, "081"); }

    public bool Test145() { return Test(CultureInfo.InvariantCulture, "FooBar", "Foo\u0400Bar", 0, CompareOptions.None, "082"); }
    public bool Test146() { return TestOrd(CultureInfo.InvariantCulture, "FooBar", "Foo\u0400Bar", -1, CompareOptions.Ordinal, "083"); }
	public bool Test147() { return Test(CultureInfo.InvariantCulture, "FooBar", "Foo\u0400Bar", 0, CompareOptions.IgnoreNonSpace, "084"); }
	public bool Test148() { return Test(CultureInfo.InvariantCulture, "FooBA\u0300R", "Foo\u0400B\u00C0R", 0, CompareOptions.IgnoreNonSpace, "085"); }

    public bool Test149() { return Test(CultureInfo.InvariantCulture, "Test's", "Tests", 0, CompareOptions.IgnoreSymbols, "086"); }
    public bool Test150() { return Test(CultureInfo.InvariantCulture, "Test's", "Tests", 1, CompareOptions.None, "087"); }
    public bool Test151() { return Test(CultureInfo.InvariantCulture, "Test's", "Tests", -1, CompareOptions.StringSort, "088"); }

    public bool Test152() { return TestExc(CultureInfo.InvariantCulture, "Test's", "Tests", typeof(ArgumentException), (CompareOptions)(-1), "090"); }
    public bool Test153() { return TestOrd(CultureInfo.InvariantCulture, null, "Tests", -1, CompareOptions.None, "091"); }
    public bool Test154() { return TestOrd(CultureInfo.InvariantCulture, "Test's", null, 1, CompareOptions.None, "092"); }
    public bool Test155() { return TestOrd(CultureInfo.InvariantCulture, null, null, 0, CompareOptions.None, "093"); }

    public bool Test156() { return Test(CultureInfo.InvariantCulture, new string('a', 5555), new string('a', 5555), 0, CompareOptions.None, "094"); }
    public bool Test157() { return Test(CultureInfo.InvariantCulture, new string('a', 5555), new string('a', 5554) + "b", -1, CompareOptions.None, "095"); }

    public bool Test(CultureInfo culture, string str1, string str2, int expected, CompareOptions options, string id)
    {
		if (!Utilities.IsVistaOrLater || !culture.Name.Equals("tr-TR")) //Due Windows 7 bug 130925
			expected = GlobLocHelper.OSCompare(culture, str1, 0, str1.Length, str2, 0, str2.Length, options);

        CompareInfo ci = culture.CompareInfo;
        bool result = true;
        if (str1 == null || str2 == null || (str1.Length < 100 && str2.Length < 100))
            TestFramework.BeginScenario(id + ": Comparing " + ((str1 == null) ? "null" : str1) + " / " + ((str2 == null) ? "null" : str2) + "; options: " + options + "; culture: " + ci.Name);
        else
            TestFramework.BeginScenario(id + ": Comparing LongStr (" + str1.Length + ") / LongStr(" + str2.Length + "); options: " + options + "; culture: " + ci.Name);
        try
        {
            int i = ci.Compare(str1, str2, options);
            i = (i == 0) ? 0 : i / Math.Abs(i); // We don't care what i is, just whether it's =,>, or < 0
            if (i != expected)
            {
                result = false;
                TestFramework.LogError("001", "Error in " + id + ", unexpected comparison result. Actual: " + i + ", Expected: " + expected);
            }
            i = ci.Compare(str2, str1, options);
            i = (i == 0) ? 0 : i / Math.Abs(i); // We don't care what i is, just whether it's =,>, or < 0
            if (i != (0 - expected))
            {
                result = false;
                TestFramework.LogError("002", "Error in " + id + ", unexpected comparison result. Actual: " + i + ", Expected: " + (0 - expected));
            }
        }
        catch (Exception exc)
        {
            result = false;
            TestFramework.LogError("003", "Unexpected exception in " + id + ", excpetion: " + exc.ToString());
        }
        return result;
    }

    public bool TestOrd(CultureInfo culture, string str1, string str2, int expected, CompareOptions options, string id)
    {
        CompareInfo ci = culture.CompareInfo;
        bool result = true;
        if (str1 == null || str2 == null || (str1.Length < 100 && str2.Length < 100))
            TestFramework.BeginScenario(id + ": Comparing " + ((str1 == null) ? "null" : str1) + " / " + ((str2 == null) ? "null" : str2) + "; options: " + options + "; culture: " + ci.Name);
        else
            TestFramework.BeginScenario(id + ": Comparing LongStr (" + str1.Length + ") / LongStr(" + str2.Length + "); options: " + options + "; culture: " + ci.Name);
        try
        {
            int i = ci.Compare(str1, str2, options);
            i = (i == 0) ? 0 : i / Math.Abs(i); // We don't care what i is, just whether it's =,>, or < 0
            if (i != expected)
            {
                result = false;
                TestFramework.LogError("001z", "Error in " + id + ", unexpected comparison result. Actual: " + i + ", Expected: " + expected);
            }
            i = ci.Compare(str2, str1, options);
            i = (i == 0) ? 0 : i / Math.Abs(i); // We don't care what i is, just whether it's =,>, or < 0
            if (i != (0 - expected))
            {
                result = false;
                TestFramework.LogError("002z", "Error in " + id + ", unexpected comparison result. Actual: " + i + ", Expected: " + (0 - expected));
            }
        }
        catch (Exception exc)
        {
            result = false;
            TestFramework.LogError("003z", "Unexpected exception in " + id + ", excpetion: " + exc.ToString());
        }
        return result;
    }

    public bool TestExc(CultureInfo culture, string str1, string str2, Type expected, CompareOptions options, string id)
    {
        CompareInfo ci = culture.CompareInfo;
        bool result = true;
        TestFramework.BeginScenario(id + ": Comparing " + str1 + " / " + str2 + "; options: " + options + "; culture: " + ci.Name);
        try
        {
            int i = ci.Compare(str1, str2, options);
            result = false;
            TestFramework.LogError("004", "Error in " + id + ", expected exception did not occur. Comparison result: " + i);
        }
        catch (Exception exc)
        {
            if (!exc.GetType().Equals(expected))
            {
                result = false;
                TestFramework.LogError("005", "Unexpected exception in " + id + ", excpetion: " + exc.ToString());
            }
        }
        return result;
    }
}