# MauiBlazor-Music-Cast
hybrid App Play Music mp3 [.....]
# Tham khảo
https://github.com/microsoft/dotnet-podcasts/

# Android WAKE_LOCK | sửa lỗi click play running không phát âm thanh
<?xml version="1.0" encoding="utf-8"?>
<manifest xmlns:android="http://schemas.android.com/apk/res/android">
    <application 
	android:allowBackup="true" 
	android:icon="@mipmap/appicon" 
	android:roundIcon="@mipmap/appicon_round" 
	android:supportsRtl="true"
	android:networkSecurityConfig="@xml/network_security_config"
	></application>
    <uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
    <uses-permission android:name="android.permission.INTERNET" />
	<uses-permission android:name="android.permission.WAKE_LOCK" />
</manifest>