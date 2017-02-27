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
        UIElement MessageTypeSymbol { get; set; }
        public enum MessageTypes
        {
            Error,
            Info,
            Alert,
            Critical
        }
        public MessageTypes MessageType
        {
            get { return MessageType; }
            set
            {
                switch (MessageType)
                {
                    case MessageTypes.Alert:
                        MessageTypeSymbol = new PackIcon
                        { Kind = PackIconKind.AlertCircle };
                        break;
                    case MessageTypes.Info:
                        MessageTypeSymbol = new PackIcon
                        { Kind = PackIconKind.Information };
                        break;
                    case MessageTypes.Error:
                        MessageTypeSymbol = new PackIcon
                        { Kind = PackIconKind.CloseCircle };
                        break;
                    case MessageTypes.Critical:
                        MessageTypeSymbol = new PackIcon
                        { Kind = PackIconKind.Exclamation };
                        break;
                }
                return;
            }
        }
        public MDMessageBox()
        {
            InitializeComponent();
        }
    }
}
