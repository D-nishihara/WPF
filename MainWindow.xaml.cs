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

        bool _textreadonly = true;

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
                //後でコンストラクタで実施するように書き換える
                XmlManager xmlmanager = new XmlManager();
                xmlmanager.Xmlcreater(textBox);

                //動的にTextBoxとラジオボタンを追加
                StackPanel panel = new StackPanel();
                panel.Orientation = Orientation.Horizontal;
                radio.GroupName = "name";
                panel.Children.Add(textBox);
                panel.Children.Add(radio);
                stack2.Children.Add(panel);
                
                //動的に作成したTextBoxに値を代入
                textBox.Text = value;
                
                //動的に作成したTextBoxを読み取り専用にする
                textBox.IsReadOnly = _textreadonly;

                //RadioButtonのタグプロパティにTextBoxをセット
                radio.Tag = textBox;

                //Radioボタンのクリックイベント追加
                radio.Click += Radio_Click;

                //登録完了メッセージ
                //MessageBox.Show("登録が完了しました。");
            }
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            StackPanel stack = null;

            foreach (var panel in stack2.Children.OfType<StackPanel>())
            {
                foreach (var test in panel.Children.OfType<RadioButton>())
                {
                    if (test.IsChecked == true)
                    {
                        stack = panel;
                        break;
                    }
                    
                }
            }

            if (stack != null)
            {
                stack2.Children.Remove(stack);
                //    MessageBox.Show("登録内容を削除しました。");
            }
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
            foreach (var panel in stack2.Children.OfType<StackPanel>())
            {
                foreach (var test in panel.Children.OfType<RadioButton>())
                {

                    //RadioButtonのTagに格納されているTextをキャスト
                    var textcast = (TextBox)test.Tag;

                    if (test.IsChecked == true)
                    {
                        textcast.IsReadOnly = false;
                    }
                    else
                    {
                        textcast.IsReadOnly = true;
                    }
                }
            }
            //if (((RadioButton)sender).IsChecked == true)
            //{
                 
            //}
        }
    }
}