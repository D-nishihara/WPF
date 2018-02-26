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
        int counter = 0;
        bool textreadonly = false;
        //xml出力用の保存用クラスのインスタンス生成
        Class1 test = new Class1();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TextBoxのインスタンス生成
            TextBox textBox = new TextBox();
            var value = textvalue.Text;

            //Radioボタンのインスタンス生成
            RadioButton radio = new RadioButton();


            if (value == null)
            {
                MessageBox.Show("登録内容を入力してからボタンを押下してください。");
            }
            else
            {
                //テキスト内容をxmlに出力するメソッド呼出
                Class2 class2 = new Class2();
                class2.Xmlwrite(value);

                //TextBox1の内容をTextBox2にコピー
                //textinsertvalue.Text = value;

                ////動的にTextBoxを作成
                //grid1.Children.Add(textinsertvalue);


                //動的に作成するTextBoxの表示位置を設定
                //textBox.SetValue(Canvas.TopProperty, 30.0 * counter + 300);
                //textBox.SetValue(Canvas.LeftProperty, 250.0);

                //20180226追加
                StackPanel panel = new StackPanel();
                stack2.Children.Add(textBox);
                stack2.Children.Add(radio);

                //動的に作成したTextBoxに値を代入
                textBox.Text = value;
                
                //動的に作成したTextBoxを読み取り専用にする
                textBox.IsReadOnly = true;

                ////RadioButtonを動的に作成
                //radio.SetValue(Canvas.TopProperty, 30.0 * counter + 300);
                //radio.SetValue(Canvas.LeftProperty, 300.0);
                //canvas1.Children.Add(radio);

                //Radioボタンのクリックイベント追加
                radio.Click += Radio_Click;
                
                counter++;

                //MessageBox.Show("登録が完了しました。");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //if (textinsertvalue == 0)
            //{
            //    return;
            //}
            //else
            //{
            //    listvalue.Items.RemoveAt(listvalue.SelectedIndex);
            //    MessageBox.Show("登録内容を削除しました。");
            //}
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //if (listvalue.SelectedItems.Count == 0)
            //{
            //    return;
            //}
            //else
            //{
            //    //listvalue.Items.RemoveAt(listvalue.SelectedIndex);
            //    //listvalue.Items.Add(textvalue.Text);

            //    //var a = listvalue.SelectedItems;
            //    //a = textvalue.Text;
                
            //    MessageBox.Show("登録内容を編集しました。");
            //}
        }

        private void Radio_Click(object sender, RoutedEventArgs e)
        {   
            if (RadioButton.IsCheckedProperty == null)
            {
            }
        }
    }
}