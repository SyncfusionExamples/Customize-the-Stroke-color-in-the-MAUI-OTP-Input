namespace OTPInputSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OtpInput_ValueChanged(object sender, Syncfusion.Maui.Toolkit.OtpInput.OtpInputValueChangedEventArgs e)
        {
            string enteredOtp = e.NewValue;

            if (string.IsNullOrEmpty(enteredOtp))
            {
                OtpInput.InputState = Syncfusion.Maui.Toolkit.OtpInput.OtpInputState.Default;
            }
            else if (enteredOtp.Length == OtpInput.Length)
            {
                if (enteredOtp == "1234")
                {
                    OtpInput.InputState = Syncfusion.Maui.Toolkit.OtpInput.OtpInputState.Success;
                }
                else
                {
                    OtpInput.InputState = Syncfusion.Maui.Toolkit.OtpInput.OtpInputState.Error;

                }
            }
            else
            {
                OtpInput.InputState = Syncfusion.Maui.Toolkit.OtpInput.OtpInputState.Warning;
            }
        }
    }
}
