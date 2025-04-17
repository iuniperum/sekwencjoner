using System;
using System.Numerics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;

namespace lab7;

public partial class MainWindow : Window 
{
    private string input = "";
    
    private string czworki = "";
    private string[] lista;
    private string sprawdzana = "";
    private string test = "";
    
    private string output = "";
    
    private int licznik = 0;
    public MainWindow() {
        InitializeComponent();
    }
    
    private void zlicz(object sender, RoutedEventArgs e) {
        input = Convert.ToString(sekwencja.Text);
        for (int i = 0; i < (input.Length - 3); i++) {
            czworki = czworki + input.Substring(i, 4) + " ";
        }
        lista = czworki.Split(" ");
        
        for (int i = 0; i < (lista.Length); i++) {
            if (lista[i] != "xxxx") {
                sprawdzana = lista[i];
                for (int j = 0; j < (lista.Length); j++) {
                    if (lista[j] == sprawdzana) {
                        licznik += 1;
                        lista[j] = "xxxx";
                    }
                    output = output + sprawdzana + ": " + licznik + "\n";
                    licznik = 0;
                }
            }
        }
        for (int j = 0; j < (lista.Length); j++) {
            test +=  lista[j] + "/";
        }
        wynik.InnerLeftContent = output;
    }
}