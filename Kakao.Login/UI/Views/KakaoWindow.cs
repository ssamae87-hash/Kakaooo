﻿using System.Windows;

namespace Kakao.Login.UI.Views
{
    public class KakaoWindow : Window
    {
        static KakaoWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KakaoWindow), new FrameworkPropertyMetadata(typeof(KakaoWindow)));
        }
    }
}
