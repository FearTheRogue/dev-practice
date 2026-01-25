public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string areaCode = phoneNumber.Substring(0,3);
        string middleDigits = phoneNumber.Substring(4,3);
        string lastFourDigits = phoneNumber.Substring(8,4);

        bool isNewYork = areaCode == "212";
        bool isFake = middleDigits == "555";
        
        return (isNewYork, isFake, lastFourDigits);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
