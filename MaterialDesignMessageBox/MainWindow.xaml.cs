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
using MaterialDesignThemes.Wpf;

namespace MaterialDesignMessageBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MDMessageBox : Window
    {
        public string Message { get; set; }
        UIElement MessageTypeSymbol
        {
            get
            {
                switch (MessageType)
                {
                    case MessageTypes.Alert:
                        return new PackIcon
                        { Kind = PackIconKind.AlertCircle };
                    case MessageTypes.Info:
                        return new PackIcon
                        { Kind = PackIconKind.Information };
                    case MessageTypes.Error:
                        return new PackIcon
                        { Kind = PackIconKind.CloseCircle };
                    case MessageTypes.Critical:
                        return new PackIcon
                        { Kind = PackIconKind.Exclamation };
                }
                return new PackIcon();
            }
        }
        public enum MessageTypes
        {
            Error,
            Info,
            Alert,
            Critical
        }
        public MessageTypes MessageType { get; set; }
        public MDMessageBox()
        {
            InitializeComponent();
            (MessageTypeSymbol as PackIcon).Margin = new Thickness(20);
            MessageGrid.Children.Add(MessageTypeSymbol);
        }
    }
}
