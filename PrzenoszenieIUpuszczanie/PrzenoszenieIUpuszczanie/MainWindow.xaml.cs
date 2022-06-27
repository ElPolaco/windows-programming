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

namespace PrzenoszenieIUpuszczanie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBox listBox = sender as ListBox;    
            ListBoxItem przenoszonyElement=listBox.GetItemAt(e.GetPosition(listBox));
            if (przenoszonyElement != null)
            {
                DataObject dane = new DataObject();
                // dane.SetData("Format_Lista",listBox);
                //dane.SetData("Format_Element_Listy",przenoszonyElement);
                dane.SetData(DataFormats.StringFormat,przenoszonyElement.Content as string);   
                DragDrop.DoDragDrop(listBox, dane, DragDropEffects.Copy | DragDropEffects.Move);

                if (!Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                {
                    listBox.Items.Remove(przenoszonyElement);
                }
            }
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.KeyStates.HasFlag(DragDropKeyStates.ControlKey)){
                e.Effects=DragDropEffects.Copy;
            }
            else
            {
                e.Effects=DragDropEffects.Move; 
            }
        }

        private void ListBox_Drop(object sender, DragEventArgs e)
        {
            ListBox lbSender=sender as ListBox;
         //   ListBox lbSource = e.Data.GetData("Format_Lista") as ListBox;
         //   ListBoxItem przenoszonyElement = e.Data.GetData("Format_Element_Listy") as ListBoxItem;
            /*
            if (!e.KeyStates.HasFlag(DragDropKeyStates.ControlKey))
            {
                lbSource.Items.Remove(przenoszonyElement);
            }
            else
                przenoszonyElement = new ListBoxItem() { Content=przenoszonyElement.Content};
            */
            string etykieta=e.Data.GetData(DataFormats.StringFormat) as string;
            ListBoxItem przenoszonyElement = new ListBoxItem() { Content=etykieta};
            int indeks=lbSender.IndexFromPoint(e.GetPosition(lbSender));
            if (indeks < 0)
            {
                lbSender.Items.Add(przenoszonyElement);
            }
            else
            {
                lbSender.Items.Insert(indeks, przenoszonyElement);  
            }

        }
    }
}
