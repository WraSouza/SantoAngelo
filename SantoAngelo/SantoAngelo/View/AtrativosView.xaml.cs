﻿using SantoAngelo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SantoAngelo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AtrativosView : ContentPage
    {
        public AtrativosView()
        {
            InitializeComponent();

            BindingContext = new AtrativosViewModel(Navigation);
        }        
    }
}