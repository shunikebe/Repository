﻿using System;
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

namespace WpfApplication1
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

        //ABCを押したときの処理
        private void ABC_Click(object sender, RoutedEventArgs e)
        {
            //ラベルにテキストボックスのテキストを表示するsdsdss
            labelM.Content = textBox.Text + "さん　こんにちは";
           
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            labelM.Content = "";
        }
    }
}
