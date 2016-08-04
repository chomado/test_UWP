using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace test_UWP
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if (this.InputTextBox.Text != "TextBox")
            {
                //this.TitleLabel.Text = this.InputTextBox.Text + "飲みましょう"; //DateTime.Now.ToString();
                this.SakeListView.Items.Add(this.InputTextBox.Text);

            }
            else
            {
                await new MessageDialog("ちゃんと入力してください").ShowAsync();
            }
        }

        private void SakeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.SakeListView.Items.Remove(this.SakeListView.SelectedItem);
            //this.SakeListView.Items.RemoveAt(this.SakeListView.SelectedIndex);
        }
    }
}
