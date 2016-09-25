using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSHtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            //SSH接続処理

        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            string path = FileOpen();
            textBoxPath.Text = path;
        }

        //*****************************************************//
        //サブルーチン
        //ファイルを開く関数
        private string FileOpen()
        {
            OpenFileDialog ofd = new OpenFileDialog();  //インスタンスを作成

            //はじめのファイル名を指定
            //はじめに[ファイル名」で表示されるファイル名
            ofd.FileName = "id_rsa";

            //はじめに表示されるフォルダ
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = "";

            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "";

            //[ファイルの種類]ではじめに選択されるものを指定する
            //1番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 1;

            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";

            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;

            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;

            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を返す
                return ofd.FileName;
            }
            else
            {
                //キャンセルボタンをクリックしたとき、もともと入っていたパスを保持
                return textBoxPath.Text;
            }
        }
    }
}
