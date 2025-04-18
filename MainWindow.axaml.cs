using System;
using System.Numerics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Linq;

namespace lab7;

public partial class MainWindow : Window 
{
    private string input = "";
    
    private string czworki = "";
    //private string[] lista;
    //private string[] unikalne;
    private string sprawdzana = "";
    private string test = "";
    
    private string output = "";
    
    private int licznik = 0;
    public MainWindow() {
        InitializeComponent();
    }
    
    private void zlicz(object sender, RoutedEventArgs e) {
        List<string> lista = new List<string>();
        List<string> unikalne = new List<string>();
        input = Convert.ToString(sekwencja.Text);
        for (int i = 0; i < (input.Length - 3); i++) {
            czworki = czworki + input.Substring(i, 4) + " ";
        }
        lista = czworki.Split(" ").ToList();
        unikalne = lista.Distinct().ToList();
        
        for (int i = 0; i < (unikalne.Count - 1); i++) {
            output += unikalne[i];
            output += ": ";
            for (int j = 0; j < lista.Count; j++) {
                if (lista[j] == unikalne[i]) {
                    licznik += 1;
                }
            }
            output += licznik.ToString();
            output += "\n";
            licznik = 0;
        }
        for (int j = 0; j < (unikalne.Count); j++) {
            test +=  unikalne[j] + "/";
        }
        wynik.InnerLeftContent = output;
    }
}