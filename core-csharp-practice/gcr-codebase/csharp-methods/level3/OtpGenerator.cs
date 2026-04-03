using System;

// Class name clearly indicates purpose
class OtpGenerator
{
    private const int OtpLength = 6;
    private const int OtpCount = 10;

    // Method to generate a 6-digit OTP
    public static int GenerateSixDigitOtp()
    {
        Random random = new Random();
        return random.Next(100000, 1000000); // 6-digit OTP
    }

    // Method to generate OTPs and store them in an array
    public static int[] GenerateOtpArray()
    {
        int[] otps = new int[OtpCount];

        for (int index = 0; index < otps.Length; index++)
        {
            otps[index] = GenerateSixDigitOtp();
        }

        return otps;
    }

    // Method to check whether all OTPs are unique
    public static bool AreOtpsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    // Main Method
    static void Main(string[] args)
    {
        int[] otpNumbers = GenerateOtpArray();

        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otpNumbers)
        {
            Console.WriteLine(otp);
        }

        Console.WriteLine();

        // Validate uniqueness
        bool isUnique = AreOtpsUnique(otpNumbers);

        Console.WriteLine("Are all OTPs unique: " + isUnique);
    }
}
