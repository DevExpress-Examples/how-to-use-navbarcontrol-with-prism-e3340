﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.NavBar;
using System.ComponentModel.Composition;

namespace NavBarAndPrism.Views {
    [Export]
    public partial class ModuleBView : NavBarGroup {
        public ModuleBView() {
            InitializeComponent();
        }
    }
}
