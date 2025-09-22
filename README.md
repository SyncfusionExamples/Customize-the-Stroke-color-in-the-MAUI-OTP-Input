# Customize-the-Stroke-color-in-the-MAUI-OTP-Input

This sample demonstrates how to customize the input stroke color of the .NET MAUI OTP Input control within a .NET MAUI application.

## Sample

```xaml
    <StackLayout Padding="30" Spacing="20" HorizontalOptions="Center">
        <Label Text="Enter your OTP" FontSize="24" HorizontalOptions="Center" FontAttributes="Bold"/>
        <Syncfusion:SfOtpInput x:Name="OtpInput" Length="4" ValueChanged="OtpInput_ValueChanged" HorizontalOptions="Center" />
    </StackLayout>
```

```App.xaml
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Resources/Styles/Colors.xaml" />
                <ResourceDictionary Source="Resources/Styles/Styles.xaml" />
            </ResourceDictionary.MergedDictionaries>
            <Color x:Key="SfOtpInputDefaultStroke">Gray</Color>
            <Color x:Key="SfOtpInputSuccessStroke">#35B44A</Color>
            <Color x:Key="SfOtpInputErrorStroke">#D63D2C</Color>
            <Color x:Key="SfOtpInputWarningStroke">#FFF100</Color>
        </ResourceDictionary>
    </Application.Resources>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples
