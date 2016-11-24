using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MyControles
{
    public sealed partial class Hamburguesa : UserControl
    {
        

        /// <summary>
        /// Establece eltitulo del control Hamburgusea. De solo escritura
        /// </summary>
      
        public string TituloHamburguesa
        {
            set { this.TitleTextBlock.Text = value; }
        }
        public string Opcion1Name
        {
            set
            {
                Texto_Opcion1.Text = value;
            }
        }
        public string Opcion2Name
        {
            set
            {
                Texto_Opcion2.Text = value;
            }
        }
        public string Opcion3Name
        {
            set
            {
                Texto_Opcion3.Text = value;
            }
        }
        public string Opcion1Icono
        {
            set
            {
                MDL2_Opcion1.Text=value;
            }
        }
        public string Opcion2Icono
        {
            set
            {
                MDL2_Opcion2.Text = value;
            }
        }
        public string Opcion3Icono
        {
            set
            {
                MDL2_Opcion3.Text = value;
            }
        }

        public Hamburguesa()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            //Abrir o cerrar la lista de opciones del control
             MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;

           
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
