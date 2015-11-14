using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1 {

    //「依存処理」のインターフェース定義
    public interface IMyToast {
        void Show(string message);
    }

    public class App : Application {
        public App() {
            // The root page of your application
            MainPage = new MyPage();
        }
    }

    class MyPage : ContentPage {
        public MyPage() {
            
            // iOSだけ、上部に余白をとる
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            // ボタンを生成する
            var button = new Button() {
                Text = "Toast"
            };

            // ボタンにタッチした際に、インターフェースIToastのShowを呼ぶ
            button.Clicked += (s, e) => {
                DependencyService.Get<IMyToast>().Show("Developers.IO");
            };
            // 画面にボタンを配置する
            Content = new StackLayout {
                Children = { button }
            };
                
        }
    }
}
