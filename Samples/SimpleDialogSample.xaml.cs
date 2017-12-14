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
using System.Windows.Shapes;

namespace WPFDialogSample.Samples
{
    // コードビハインドに直接記述していく方式のダイアログ

    /// <summary>
    /// SimpleDialogSample.xaml の相互作用ロジック
    /// </summary>
    public partial class SimpleDialogSample : Window
    {
        /// <summary>
        /// 新しい SimpleDialogSample クラスのインスタンスを初期化します．
        /// </summary>
        public SimpleDialogSample()
        {
            InitializeComponent();
        }


        // 静的公開メソッド

        /// <summary>
        /// サンプルダイアログを表示します．
        /// </summary>
        /// <returns>クリックされたボタンのテキスト</returns>
        public static string ShowSampleDialog()
        {
            var instance = new SimpleDialogSample();
            string result = null;
            RoutedEventHandler clickAction = (sender, e) =>
            {
                // ボタンがクリックされたときのアクションを定義
                // クリックされたボタンのテキストを取得
                result = ((Button)sender).Content as string;
                instance.Close();
            };

            // 配置されているすべてのボタンにさっき定義したアクションを関連付け
            foreach (var button in instance.mainStackPanel.Children.OfType<Button>())
                button.Click += clickAction;

            instance.ShowDialog();
            return result;
        }
    }
}
