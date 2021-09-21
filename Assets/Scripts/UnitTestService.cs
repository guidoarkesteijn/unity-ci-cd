public static class UnitTestService
{
    public static bool GetInverted(bool value) => !value;

    public static int GetInverted(int value) => -value;

    public static float GetInverted(float value) => -value;
}
