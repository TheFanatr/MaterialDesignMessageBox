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
                        {
                            Kind = PackIconKind.AlertCircle,
                            Margin = new Thickness(10)
                        };
                    case MessageTypes.Info:
                        return new PackIcon
                        {
                            Kind = PackIconKind.Information,
                            Margin = new Thickness(10)
                        };
                    case MessageTypes.Error:
                        return new PackIcon
                        {
                            Kind = PackIconKind.CloseCircle,
                            Margin = new Thickness(10)
                        };
                    case MessageTypes.Critical:
                        return new PackIcon
                        {
                            Kind = PackIconKind.EmoticonSad,
                            Margin = new Thickness(10)
                        };
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
        }
        public void Start()
        {
            MessageGrid.Children.Add(MessageTypeSymbol);
            Show();
        }
        public static void Start(string Message)
        {
            (new MDMessageBox { Message = Message }).Start();
        }
        public static void Start(string Message, MessageTypes MessageType)
        {
            (new MDMessageBox { Message = Message, MessageType = MessageType }).Start();
        }
        public static void Start(string Message, MessageTypes MessageType, string Title)
        {
            (new MDMessageBox { Message = Message, MessageType = MessageType, Title = Title }).Start();
        }
    }
}
