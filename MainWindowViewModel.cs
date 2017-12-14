using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using LocusCommon.Windows.ViewModels;

using WPFDialogSample.Samples;

namespace WPFDialogSample
{
    public class MainWindowViewModel : ExtendedViewModelBase
    {
        // 非公開フィールド
        private DelegateCommand sampleButton1Command;
        private DelegateCommand sampleButton2Command;
        private DelegateCommand sampleButton3Command;


        // 公開プロパティ :: バインディングプロパティ

        public string SampleDialogResultText
        {
            get => this.GetBindingValue<string>();
            set => this.SetBindingValueQuick(value);
        }


        // 公開プロパティ :: コマンド

        public ICommand SampleButton1Command
        {
            get => this.sampleButton1Command;
        }

        public ICommand SampleButton2Command
        {
            get => this.sampleButton2Command;
        }

        public ICommand SampleButton3Command
        {
            get => this.sampleButton3Command;
        }


        // コンストラクタ

        /// <summary>
        /// 新しい MainWindowViewModel クラスのインスタンスを初期化します．
        /// </summary>
        public MainWindowViewModel()
        {
            this.SampleDialogResultText = "Please click any button.";

            this.sampleButton1Command = new DelegateCommand(param => this.SampleDialogResultText = SimpleDialogSample.ShowSampleDialog());
            this.sampleButton2Command = new DelegateCommand(param => { });
            this.sampleButton3Command = new DelegateCommand(param => { });
        }
    }
}
