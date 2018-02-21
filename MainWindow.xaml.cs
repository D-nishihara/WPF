using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Textクラスのインスタンスを生成
        //TextBox instance = new TextBox();

        //Labelクラスのインスタンス生成
        //Label label = new Label();

        //xmlの保存用クラスのインスタンス生成
        Class1 test = new Class1();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var value = textvalue.Text;

            if (value == null)
            {
                MessageBox.Show("登録内容を入力してからボタンを押下してください。");
            }
            else
            {
                Class2 class2 = new Class2();
                class2.Xmlwrite(value);

                //labelvalue.Content = value;
                listvalue.Items.Add(value);

                //grid1.Children.Add(textvalue);

                MessageBox.Show("登録が完了しました。");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (listvalue.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                listvalue.Items.RemoveAt(listvalue.SelectedIndex);
                MessageBox.Show("登録内容を削除しました。");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (listvalue.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                //listvalue.Items.RemoveAt(listvalue.SelectedIndex);
                //listvalue.Items.Add(textvalue.Text);

                //var a = listvalue.SelectedItems;
                //a = textvalue.Text;
                
                MessageBox.Show("登録内容を編集しました。");
            }
        }

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textvalue = (TextBox)sender;

            if (textvalue.Text == "")
            {
                textvalue.Opacity = 0.5;
            }
            else
            {
                textvalue.Opacity = 1.0;
            }

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (CheckBox.IsCheckedProperty == null)
            {

            }

        }
    }
}