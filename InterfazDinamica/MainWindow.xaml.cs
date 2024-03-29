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

namespace InterfazDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch(cbNuevo.SelectedIndex)
            {
                case 0:
                    grdTexto.Children.Add(new Alumno());
                    btnGuardar.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                    break;
                case 1:
                    grdTexto.Children.Add(new Maestro());
                    btnGuardar.Visibility = Visibility.Visible;
                    btnCancelar.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void CbNuevo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdTexto.Children.Clear();
            switch(cbNuevo.SelectedIndex)
            {
                case 0:
                    btnGuardar.Visibility = Visibility.Hidden;
                    btnCancelar.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    btnGuardar.Visibility = Visibility.Hidden;
                    btnCancelar.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;
            }
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            grdTexto.Children.Clear();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdTexto.Children.Clear();
        }
    }
}
